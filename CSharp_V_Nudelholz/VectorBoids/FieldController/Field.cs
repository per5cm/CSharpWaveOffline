using VectorBoids.Library;

namespace VectorBoids.FieldController;

public class Field
{
    private readonly double _width;
    private readonly double _height;
    private readonly List<Boid> _boidsList = new();
    private readonly Random _random = new();

    internal Field(double width, double height, int boidCount, bool random)
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

    internal void Step(double padding, double turn)
    {
        
    }

    internal IEnumerable<(double X, double Y)> Positions()
    {
        return new List<(double X, double Y)>();
    }
}
