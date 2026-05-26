namespace VectorBoids.Library;

public class Vector2
{
    internal readonly struct Vector
    {
        private double X { get; }
        private double Y { get; }

        internal Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        internal static Vector Add(Vector vector1, Vector vector2)
        {
            return new Vector (vector1.X + vector2.X + vector2.Y + vector1.Y);
        }

        internal static Vector Length(Vector vector1, Vector vector2)
        {
            return new Vector (vector1.X * vector1.X) + (vector2.Y * vector1.Y);
        }

        internal static Vector Normalise(Vector vector1, Vector vector2)
        {
            return new Vector (vector1.X / vector2.Y);
        }
    }
}