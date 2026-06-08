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

    internal Position Normalize(Position vector)
    {
        double vectorDirection = Distance(vector);
        if (vectorDirection <= 0) return new Position(0, 0);
        return new Position (vector.X / vectorDirection, vector.Y / vectorDirection);
    }
}
