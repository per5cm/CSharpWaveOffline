using VectorBoids.Library;

namespace VectorBoids.FieldController;

public class Field
{
    private readonly double _width;
    private readonly double _height;
    private readonly List<Boid> _boids = new();
    private readonly Random _random = new();

    internal Field(double width, double height, int boidCount)
    {
        _width = width;
        _height = height;

        for (int i = 0; i < boidCount; i++)
        {
            _boids.Add(new Boid(
                new Position(_random.NextDouble() * _width, _random.NextDouble() * _height),
                new Velocity(_random.NextDouble() * 2, _random.NextDouble() * 3)
            ));
        }
    }
    
    internal void Update(double padding, double turn)
    {
        foreach (var boid in _boids)
        {
            boid.Separation(_boids, 20, .001);
            boid.Alignment(_boids, 50, .01);
            boid.Cohesion(_boids, 50, .003);
            boid.Velocity.Speed(3);
        }

        foreach (var boid in _boids)
        {
            boid.Position.Move(boid.Velocity.X, boid.Velocity.Y);

            BorderWall(boid, padding, turn);
        }
    }
    
    private void BorderWall(Boid boid, double padding, double turn)
    {
        if (boid.Position.X < padding) boid.Velocity.X += turn;
        if (boid.Position.Y < padding) boid.Velocity.Y += turn;
        
        if (boid.Position.X > _width - padding) boid.Velocity.X -= turn;
        if (boid.Position.Y > _height - padding) boid.Velocity.Y -= turn;
    }
    
    internal IEnumerable<(double X, double Y)> Positions()
    {
        return new List<(double X, double Y)>();
    }
}

