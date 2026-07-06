using VectorBoids.Library;

namespace VectorBoids.FieldController;

public class Field
{
    private readonly double _width;
    private readonly double _height;
    private readonly List<Boid> _boidsList = new();
    private readonly Random _random = new();

    internal Field(double width, double height, int boidCount)
    {
        _width = width;
        _height = height;

        for (int i = 0; i < boidCount; i++)
        {
            _boidsList.Add(new Boid(
                new Position(_random.NextDouble() * _width, _random.NextDouble() * _height),
                new Velocity(_random.NextDouble() * 2, _random.NextDouble() * 3)
            ));
        }
    }
    
    internal void Update(List<Boid> boids, double width, double height, double padding, double turn)
    {
        foreach (var boid in boids)
        {
            boid.Separation(boids, 20, .001);
            boid.Alignment(boids, 50, .01);
            boid.Cohesion(boids, 50, .003);
        }

        foreach (var boid in boids)
        {
            boid.Velocity.Speed(3);
            boid.Position.Move(boid.Velocity.X, boid.Velocity.Y);

            BorderWall(boid,width, height, padding, turn);
        }
    }
    
    private void BorderWall(Boid boid,double width, double height, double padding, double turn)
    {
        if (boid.Position.X < padding) boid.Velocity.X += turn;
        if (boid.Position.Y < padding) boid.Velocity.Y += turn;
        
        if (boid.Position.X > width - padding) boid.Velocity.X -= turn;
        if (boid.Position.Y > height - padding) boid.Velocity.Y -= turn;
    }
}

