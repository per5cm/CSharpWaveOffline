using System.Numerics;

namespace VectorBoids.Library;

internal class Boids
{
    internal Vector2D.Vector Position { get; private set; }
    internal Vector2D.Vector Velocity { get; private set; }

    internal Boids(Vector2D.Vector position, Vector2D.Vector velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    internal void Update(List<Boids> boids)
    {
        var newPosition = Vector2D.Vector.Add(Position, Velocity);
        Position = newPosition;
        Separation(boids);
        Alignment(boids);
        Cohesion(boids);
        Speed();
        Canvas();
    }

    private void Separation(List<Boids> boids)
    {
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2D.Vector.Distance(Position, flock.Position);

            if (distance < 30)
            {
                double awayX = Position.X - flock.Position.X;
                double awayY = Position.Y - flock.Position.Y;
                
                Vector2D.Vector awayDirection = new Vector2D.Vector(awayX, awayY);
                Vector2D.Vector normalised = Vector2D.Vector.Normalise(awayDirection);
                Velocity = Vector2D.Vector.Add(Velocity, normalised);
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
            
            if (distance < 20)
            {
                currentX += flock.Velocity.X;
                currentY += flock.Velocity.Y;
                neighborCount++;
            }
        }

        if (neighborCount > 0)
        {
            double averageX = (currentX / neighborCount);
            double averageY = (currentY / neighborCount);
            
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

            if (distance < 20)
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
                Velocity = Vector2D.Vector.Add(Velocity, normalised);
            }
        }
    }
    
    private void Speed()
    {
        double speed = Vector2D.Vector.Length(Velocity);
        if (speed > 3)
        {
            Vector2D.Vector velocity = Vector2D.Vector.Normalise(Velocity);
            Velocity = new Vector2D.Vector(velocity.X * 3, velocity.Y * 3);
        }
    }

    private void Canvas()
    {
        int width = Console.WindowWidth - 1;
        int height = Console.WindowHeight - 1;

        if (Position.X < 0 || Position.X >= width || Position.Y < 0 || Position.Y >= height)
        {
            Position = new Vector2D.Vector(Math.Clamp(Position.X, 0, width), Math.Clamp(Position.Y, 0, height));
        }
    }
}