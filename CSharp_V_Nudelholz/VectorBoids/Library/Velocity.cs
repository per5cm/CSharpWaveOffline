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
        
        double targetX = (X / currentVelocity) * speed;
        double targetY = (Y / currentVelocity) * speed;

        if (currentVelocity >= speed)
        {
            X = targetX;
            Y = targetY;
        }
    }
}