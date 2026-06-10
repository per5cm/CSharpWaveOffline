using System.Numerics;

namespace VectorBoids.Library;

internal class Boid
{
    internal Position Position;
    internal Velocity Velocity;

    internal Boid(double positionX, double positionY, double velocityX, double velocityY)
    {
        Position = new Position(positionX, positionY);
        Velocity = new Velocity(velocityX, velocityY);
    }

    internal void Update(List<Boid> boid, double width, double height, double padding, double turn)
    {
        Separation(boid);
        Alignment(boid);
        Cohesion(boid);
        
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
                Velocity.X = (Position.X - flock.Position.X) * steer * closeness;
                Velocity.Y = (Position.Y - flock.Position.Y) * steer * closeness;
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
        
        var averageX = currentX /= count;
        var averageY = currentY /= count;

        var averageDirection = (averageX, averageY);
        var normalisation = Position.Normalize(averageDirection);
        Velocity = Position.Move(Velocity, normalisation);

        // Velocity.X += (currentX - Position.X) * steer;
        // Velocity.Y += (currentY - Position.Y) * steer;
    }

    private void Cohesion(List<Boid> boid)
    {
        int countObjects = 0;
        double currentX = 0;
        double currentY = 0;
        
        foreach (var flock in boid)
        {
            if (flock == this) continue;
            double distance = Position.Distance(flock.Position);

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
                
            var centerDirection = (averageX - Position.X, averageY - Position.Y);
            var steering = Position.Normalize(centerDirection);
            Library.Velocity = Vector2D.Add(Library.Velocity, new Vector2D(steering.X * 0.5, steering.Y * 0.5));
        }
    }

    private void BorderWall(double width, double height, double padding, double turn)
    {
        if (Position.X < padding) Velocity.X += turn;
        if (Position.Y < padding) Velocity.Y += turn;
        
        if (Position.X > width - padding) Velocity.X -= turn;
        if (Position.Y > height - padding) Velocity.Y -= turn;
    }
}