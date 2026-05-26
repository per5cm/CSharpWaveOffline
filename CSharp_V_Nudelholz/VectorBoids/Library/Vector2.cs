namespace VectorBoids.Library;

public class Vector2
{
    public readonly struct Vector
    {
        private double X { get; }
        private double Y { get; }

        private Vector(double x, double y)
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

        private static double Length(Vector vector)
        {
            double length = (vector.X * vector.X + vector.Y * vector.Y);
            return Math.Sqrt(length);
        }

        internal static Vector Normalise(Vector vector1)
        {
            double lengthVector = Length(vector1);
            var normalise = new Vector (vector1.X / lengthVector, vector1.Y / lengthVector);
            return normalise;
        }
    }
}