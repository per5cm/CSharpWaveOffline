namespace VectorBoids.Library;

internal class Boids
{
    private Vector2.Vector Position { get; set; }
    private Vector2.Vector Velocity { get; set; }

    internal Boids(Vector2.Vector position, Vector2.Vector velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    internal void Update()
    {
        var newPosition = Vector2.Vector.Add(Position, Velocity);
        Position = newPosition;
    }

    internal void Separation(List<Boids> boids)
    {
        foreach (var flock in boids)
        {
            if (flock == this) continue;
            double distance = Vector2.Vector.Distance(Position, flock.Position);

            if (distance < 15)
            {
                double awayX = Position.X - flock.Position.X;
                double awayY = Position.Y - flock.Position.Y;
                
                Vector2.Vector awayDirection = new Vector2.Vector(awayX, awayY);
                Vector2.Vector normalised = Vector2.Vector.Normalise(awayDirection);
                Velocity = Vector2.Vector.Add(Velocity, normalised);
            }
        }
    }
}