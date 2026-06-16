namespace VectorBoids.Library;

internal struct Position
{
    internal double X;
    internal double Y;

    internal Position(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    internal void Move(double x, double y)
    {
        X += x;
        Y += y;
    }

    internal double Distance(Position position)
    {
        position.X -= X;
        position.Y -= Y;
        return Math.Sqrt (position.X * position.X + position.Y * position.Y);
    }

    internal static Position Normalize(Position vector)
    {
        double length = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        if (length <= 0) return new Position(0, 0);
        return new Position (vector.X / length, vector.Y / length);
    }
}
