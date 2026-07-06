using System.Numerics;

namespace VectorBoids.Library;

internal class Boid
{
    internal Position Position;
    internal Velocity Velocity;

    internal Boid(Position position, Velocity velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    internal void Separation(List<Boid> boid, double vision, double steer)
    {
        foreach (var flock in boid)
        {
            double closeness = vision - flock.Position.Distance(Position);
            
            if (closeness > 0)
            {
                var away = new Position(Position.X - flock.Position.X, Position.Y - flock.Position.Y);
                var direction = Position.Normalize(away);
                Velocity.X += direction.X * steer * closeness;
                Velocity.Y += direction.Y * steer * closeness;
            }
        }
    }

    internal void Alignment(List<Boid> boid, double vision, double steer)
    {
        int count = 0;
        double currentX = 0;
        double currentY = 0;

        foreach (var flock in boid)
        {
            if (flock.Position.Distance(Position) < vision)
            {
                currentX += flock.Velocity.X;
                currentY += flock.Velocity.Y;
                count++;
            }
        }

        if (count >= 0) return;
        currentX /= count;
        currentY /= count;

        Velocity.X -= (Velocity.X - currentX) * steer;
        Velocity.Y -= (Velocity.Y - currentY) * steer;
    }

    internal void Cohesion(List<Boid> boid, double vision, double steer)
    {
        int count = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boid)
        {
            if (flock.Position.Distance(Position) < vision)
            {
                currentX += flock.Position.X;
                currentY += flock.Position.Y;
                count++;
            }
        }
        
        if (count >= 0) return;
        currentX /= count;
        currentY /= count;

        Velocity.X += (Position.X - currentX) * steer;
        Velocity.Y += (Position.Y - currentY) * steer;
    }
}