namespace VectorBoids.Library;

public struct Velocity
{
    internal double X;
    internal double Y;

    internal Velocity(double x, double y)
    {
        X = x;
        Y = y;
    }

    internal void Speed(double speed)
    {
        var currentVelocity = Math.Sqrt(X * X + Y * Y);

        if (currentVelocity <= 0) return;

        if (currentVelocity >= speed)
        {
            X = (X / currentVelocity) * speed;
            Y = (Y / currentVelocity) * speed;
        }
    }
}