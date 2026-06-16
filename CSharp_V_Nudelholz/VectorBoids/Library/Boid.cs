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

    internal void Update(List<Boid> boid, double width, double height, double padding, double turn)
    {
        Separation(boid, 20, .001);
        Alignment(boid,  50,.01);
        Cohesion(boid, 50, .003);
        
        Velocity.Speed(3);
        Position.Move(Velocity.X , Velocity.Y);
        
        BorderWall(width, height, padding, turn);
    }

    private void Separation(List<Boid> boid, double vision, double steer)
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

    private void Alignment(List<Boid> boid, double vision, double steer)
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

    private void Cohesion(List<Boid> boid, double vision, double steer)
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

    private void BorderWall(double width, double height, double padding, double turn)
    {
        if (Position.X < padding) Velocity.X += turn;
        if (Position.Y < padding) Velocity.Y += turn;
        
        if (Position.X > width - padding) Velocity.X -= turn;
        if (Position.Y > height - padding) Velocity.Y -= turn;
    }
}