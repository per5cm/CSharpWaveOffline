using System;

using VectorBoids.Library;

namespace VectorBoids
{
    internal class Program
    {
        private static readonly List<Boids> BoidsList = new();
        
        static void Main(string[] args)
        {
            for (int bird = 0; bird < 25; bird++)
            {
                BoidsList.Add(new Boids(new Vector2D.Vector(bird, 1), new Vector2D.Vector(0, 2)));
            }

            foreach (var flock in BoidsList)
            {
                // flock.Separation(BoidsList);
                flock.Update(BoidsList);
            }
        }
    }
}