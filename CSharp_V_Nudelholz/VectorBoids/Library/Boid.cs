namespace VectorBoids.Library;

public class Boid
{
    private Vector2.Vector Position { get; set; }
    private Vector2.Vector Velocity { get; set; }

    public Boid(Vector2.Vector position, Vector2.Vector velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    internal void Update()
    {
        Vector2.Vector newPosition = Vector2.Vector.Add(Position, Velocity);
        Position = newPosition;
    }
}