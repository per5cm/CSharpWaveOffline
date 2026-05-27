using System;

using VectorBoids.Library;

namespace VectorBoids
{
    internal class Program
    {
        internal static List<Boids> BoidsList = new();
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                BoidsList.Add(new Boids(new Vector2.Vector(i, 1), new Vector2.Vector(0, 2)));
            }

            foreach (var flok in BoidsList)
            {
                Console.WriteLine(flok);
                flok.Separation(BoidsList);
                flok.Update();
            }
        }
    }
}