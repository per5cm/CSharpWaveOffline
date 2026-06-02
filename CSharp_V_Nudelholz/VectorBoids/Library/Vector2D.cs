namespace VectorBoids.Library;

internal class Vector2D
{
    internal readonly struct Vector
    {
        internal double X { get; }
        internal double Y { get; }

        internal Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        internal static Vector Add(Vector vector1, Vector vector2)
        {
            double newX = vector1.X + vector2.X;
            double newY = vector1.Y + vector2.Y;
            return new Vector(newX, newY);
        }

        internal static double Length(Vector vector)
        {
            double length = (vector.X * vector.X + vector.Y * vector.Y);
            return Math.Sqrt(length);
        }

        internal static Vector Normalise(Vector vector)
        {
            double lengthVector = Length(vector);
            if (lengthVector <= 0) return new Vector(0, 0);
            var normalise = new Vector (vector.X / lengthVector, vector.Y / lengthVector);
            return normalise;
        }

        internal static double Distance(Vector vector1, Vector vector2)
        {
            double newX = vector1.X - vector2.X;
            double newY = vector1.Y - vector2.Y;
            return Math.Sqrt(newX * newX + newY * newY);
        }
    }
}