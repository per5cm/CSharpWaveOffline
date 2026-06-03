namespace VectorBoids.Library;

internal readonly struct Vector2D
{
    internal double X { get; }
    internal double Y { get; }

    internal Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    internal static Vector2D Add(Vector2D vector1, Vector2D vector2)
    {
        double newX = vector1.X + vector2.X;
        double newY = vector1.Y + vector2.Y;
        return new Vector2D(newX, newY);
    }

    internal static double Length(Vector2D vector)
    {
        double length = (vector.X * vector.X + vector.Y * vector.Y);
        return Math.Sqrt(length);
    }

    internal static Vector2D Normalise(Vector2D vector)
    {
        double vectorLength = Length(vector);
        if (vectorLength < 0) return new Vector2D(0, 0);
        return new Vector2D (vector.X / vectorLength, vector.Y / vectorLength);
    }

    internal static double Distance(Vector2D vector1, Vector2D vector2)
    {
        double newX = vector1.X - vector2.X;
        double newY = vector1.Y - vector2.Y;
        return Math.Sqrt(newX * newX + newY * newY);
    }
}
