using System.Numerics;

namespace VectorBoids.Library;

internal class Boids
{
    internal Vector2D.Vector Position { get; private set; }
    private Vector2D.Vector Velocity { get; set; }

    internal Boids(Vector2D.Vector position, Vector2D.Vector velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    internal void Update(List<Boids> boids, int width, int height)
    {
        var newPosition = Vector2D.Vector.Add(Position, Velocity);
        Position = newPosition;
        Separation(boids);
        Alignment(boids);
        Cohesion(boids);
        Speed();
        Canvas(width, height);
    }

    private void Separation(List<Boids> boids)
    {
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2D.Vector.Distance(Position, flock.Position);

            if (distance < 40)
            {
                double awayX = Position.X - flock.Position.X;
                double awayY = Position.Y - flock.Position.Y;
                
                Vector2D.Vector awayDirection = new Vector2D.Vector(awayX, awayY);
                Vector2D.Vector normalised = Vector2D.Vector.Normalise(awayDirection);
                Velocity = Vector2D.Vector.Add(Velocity, new Vector2D.Vector(normalised.X * 3, normalised.Y * 3));
            }
        }
    }

    private void Alignment(List<Boids> boids)
    {
        int neighborCount = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2D.Vector.Distance(Position, flock.Position);
            
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
            
            Vector2D.Vector averageDirection = new Vector2D.Vector(averageX, averageY);
            Vector2D.Vector normalised = Vector2D.Vector.Normalise(averageDirection);
            Velocity = Vector2D.Vector.Add(Velocity, normalised);
        }
    }

    private void Cohesion(List<Boids> boids)
    {
        int countObjects = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2D.Vector.Distance(Position, flock.Position);

            if (distance < 40)
            {
                currentX += flock.Position.X;
                currentY += flock.Position.Y;
                countObjects++;
            }

            if (countObjects > 0)
            {
                double averageX = (currentX / countObjects);
                double averageY = (currentY / countObjects);
                
                Vector2D.Vector steeringDirection = new Vector2D.Vector(averageX - Position.X, averageY - Position.Y);
                Vector2D.Vector normalised = Vector2D.Vector.Normalise(steeringDirection);
                Velocity = Vector2D.Vector.Add(Velocity, new Vector2D.Vector(normalised.X * 1, normalised.Y * 1));
            }
        }
    }
    
    private void Speed()
    {
        double speed = Vector2D.Vector.Length(Velocity);
        if (speed > 2)
        {
            Vector2D.Vector velocity = Vector2D.Vector.Normalise(Velocity);
            Velocity = new Vector2D.Vector(velocity.X * 2, velocity.Y * 2);
        }
    }

    private void Canvas(int width, int height)
    {
        double newX = Position.X;
        double newY = Position.Y;
        
        if (Position.X < 0) newX = width - 1;
        if (Position.X > width) newX = 0;
        if (Position.Y < 0) newY = height - 1;
        if (Position.Y > height) newY = 0;
        
        Position = new Vector2D.Vector(newX, newY);
    }
}