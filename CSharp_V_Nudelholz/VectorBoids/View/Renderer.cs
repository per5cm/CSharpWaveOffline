using System.Text;
using VectorBoids.Library;
using VectorBoids.FieldController;

namespace VectorBoids.View;

public class Renderer
{
    private readonly int _width;
    private readonly int _height;

    internal Renderer(int width, int height)
    {
        _width = width;
        _height = height;
    }

    internal void Draw(IEnumerable<(double X, double Y)> positions)
    {
        char[,] grid = new char [_height, _width];
        
        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _width; x++)
                grid[y, x] = ' ';
        }
        
        foreach (var position in positions)
        {
            int column = (int)position.X;
            int row = (int)position.Y;

            if (column >= 0 && column <= _width - 1 && row >= 0 && row <= _height - 1)
                grid[row, column] = '*';
        }

        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _width; x++)
                Console.Write(grid[y, x]);
            Console.WriteLine();
        }
    }
}