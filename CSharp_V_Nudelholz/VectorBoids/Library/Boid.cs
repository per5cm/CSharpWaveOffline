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
        foreach (var flok in boids)
        {
            if (flok == this) continue;
            double distance = Vector2.Vector.Distance(Position, flok.Position);

            if (distance < 5)
            {
                double awayX = Position.X - flok.Position.X;
                double awayY = Position.Y - flok.Position.Y;
                
                Vector2.Vector awayDirection = new Vector2.Vector(awayX, awayY);
                Vector2.Vector normalised = Vector2.Vector.Normalise(awayDirection);
                Velocity = Vector2.Vector.Add(Velocity, normalised);
            }
        }
    }
}