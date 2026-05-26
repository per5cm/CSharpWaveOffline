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
}