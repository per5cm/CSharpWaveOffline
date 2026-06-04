using System.Numerics;

namespace VectorBoids.Library;

internal class Boid
{
    internal Vector2D Position { get; private set; }
    private Vector2D Velocity { get; set; }

    internal Boid(Vector2D position, Vector2D velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    internal void Update(List<Boid> boid, int width, int height, double padding, double turn)
    {
        Separation(boid);
        Alignment(boid);
        Cohesion(boid);
        Speed();
        
        Position = Vector2D.Add(Position, Velocity);
        
        BorderWall(width, height, padding, turn);
    }

    private void Separation(List<Boid> boid)
    {
        foreach (var flock in boid)
        {
            if (flock == this) continue;
            double distance = Vector2D.Distance(Position, flock.Position);

            if (distance < 20)
            {
                double awayX = Position.X - flock.Position.X;
                double awayY = Position.Y - flock.Position.Y;
                
                Vector2D awayDirection = new(awayX, awayY);
                var pushDirection = Vector2D.Normalize(awayDirection);
                Velocity = Vector2D.Add(Velocity, new Vector2D(pushDirection.X * 3, pushDirection.Y * 3));
            }
        }
    }

    private void Alignment(List<Boid> boid)
    {
        int count = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boid)
        {
            if (flock == this) continue;
            double distance = Vector2D.Distance(Position, flock.Position);
            
            if (distance < 40)
            {
                currentX += flock.Velocity.X;
                currentY += flock.Velocity.Y;
                count++;
            }
        }

        if (count > 0)
        {
            double averageX = currentX / count;
            double averageY = currentY / count;
            
            Vector2D averageDirection = new(averageX, averageY);
            var normalised = Vector2D.Normalize(averageDirection);
            Velocity = Vector2D.Add(Velocity, normalised);
        }
    }

    private void Cohesion(List<Boid> boid)
    {
        int countObjects = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boid)
        {
            if (flock == this) continue;
            double distance = Vector2D.Distance(Position, flock.Position);

            if (distance < 40)
            {
                currentX += flock.Position.X;
                currentY += flock.Position.Y;
                countObjects++;
            }
        }
        
        if (countObjects > 0)
        {
            double averageX = (currentX / countObjects);
            double averageY = (currentY / countObjects);
                
            Vector2D centerDirection = new (averageX - Position.X, averageY - Position.Y);
            var steering = Vector2D.Normalize(centerDirection);
            Velocity = Vector2D.Add(Velocity, new Vector2D(steering.X * 0.5, steering.Y * 0.5));
        }
    }
    
    private void Speed()
    {
        double speed = Vector2D.Length(Velocity);
        if (speed > 3)
        {
            var velocity = Vector2D.Normalize(Velocity);
            Velocity = new Vector2D(velocity.X * 3, velocity.Y * 3);
        }
    }

    private void BorderWall(double width, double height, double padding, double turn)
    {
        if (Position.X < padding) Velocity  = new Vector2D(Velocity.X + turn , Velocity.Y);
        if (Position.Y < padding) Velocity  = new Vector2D(Velocity.X, Velocity.Y + turn);
        
        if (Position.X > width - padding) Velocity = new Vector2D(Velocity.X - turn, Velocity.Y);
        if (Position.Y > height - padding) Velocity  = new Vector2D(Velocity.X, Velocity.Y - turn);
    }
}