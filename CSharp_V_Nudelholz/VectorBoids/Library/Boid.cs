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

    internal void Update(List<Boid> boid, int width, int height)
    {
        Separation(boid);
        Alignment(boid);
        Cohesion(boid);
        Speed();
        
        Position = Vector2D.Add(Position, Velocity);
        
        BorderWall(width, height);
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
                var normalised = Vector2D.Normalize(awayDirection);
                Velocity = Vector2D.Add(Velocity, new Vector2D(normalised.X * 3, normalised.Y * 3));
            }
        }
    }

    private void Alignment(List<Boid> boid)
    {
        int neighborCount = 0;
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
                neighborCount++;
            }
        }

        if (neighborCount > 0)
        {
            double averageX = currentX / neighborCount;
            double averageY = currentY / neighborCount;
            
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
                
            Vector2D steeringDirection = new (averageX - Position.X, averageY - Position.Y);
            var normalised = Vector2D.Normalize(steeringDirection);
            Velocity = Vector2D.Add(Velocity, new Vector2D(normalised.X * 1, normalised.Y * 1));
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

    private void BorderWall(int width, int height)
    {
        double newX = Position.X;
        double newY = Position.Y;
        
        if (Position.X < 0) newX = width - 1;
        if (Position.X > width) newX = 0;
        if (Position.Y < 0) newY = height - 1;
        if (Position.Y > height) newY = 0;
        
        Position = new Vector2D(newX, newY);
    }
}