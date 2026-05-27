using System;

using VectorBoids.Library;

namespace VectorBoids
{
    internal class Program
    {
        private static List<Boids> BoidsList = new();
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                BoidsList.Add(new Boids(new Vector2.Vector(i, 0), new Vector2.Vector(0, 1)));
            }
        }
    }
}