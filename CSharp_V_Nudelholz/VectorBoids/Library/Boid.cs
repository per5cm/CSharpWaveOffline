using System.Numerics;

namespace VectorBoids.Library;

internal class Boids
{
    internal Vector2D.Vector Position { get; private set; }
    internal Vector2D.Vector Velocity { get; set; }

    internal Boids(Vector2D.Vector position, Vector2D.Vector velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    internal void Update(List<Boids> boids)
    {
        Separation(boids);
        Alignment(boids);
        Cohesion(boids);
        var newPosition = Vector2D.Vector.Add(Position, Velocity);
        Position = newPosition;
    }

    internal void Separation(List<Boids> boids)
    {
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2D.Vector.Distance(Position, flock.Position);

            if (distance < 15)
            {
                double awayX = Position.X - flock.Position.X;
                double awayY = Position.Y - flock.Position.Y;
                
                Vector2D.Vector awayDirection = new Vector2D.Vector(awayX, awayY);
                Vector2D.Vector normalised = Vector2D.Vector.Normalise(awayDirection);
                Velocity = Vector2D.Vector.Add(Velocity, normalised);
            }
        }
    }

    internal void Alignment(List<Boids> boids)
    {
        int countObjects = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2D.Vector.Distance(Position, flock.Position);
            
            if (distance < 15)
            {
                currentX += flock.Velocity.X;
                currentY += flock.Velocity.Y;
                countObjects++;
            }
        }

        if (countObjects > 0)
        {
            double averageX = (currentX / countObjects);
            double averageY = (currentY / countObjects);
            
            Vector2D.Vector averageDirection = new Vector2D.Vector(averageX, averageY);
            Vector2D.Vector normalised = Vector2D.Vector.Normalise(averageDirection);
            Velocity = Vector2D.Vector.Add(Velocity, normalised);
        }
    }

    internal void Cohesion(List<Boids> boids)
    {
        int countObjects = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2D.Vector.Distance(Position, flock.Position);

            if (distance < 15)
            {
                currentX += flock.Position.X;
                currentY += flock.Position.Y;
                countObjects++;
            }

            if (countObjects > 0)
            {
                double averageX = (currentX / countObjects);
                double averageY = (currentY / countObjects);
                
                Vector2D.Vector middle= new Vector2D.Vector(averageX, averageY);
                Vector2D.Vector steeringDirection = Vector2D.Vector.Subtract(middle, Position);
                Vector2D.Vector normalised = Vector2D.Vector.Normalise(steeringDirection);
                Velocity = Vector2D.Vector.Add(Velocity, normalised);
            }
        }
    }
}