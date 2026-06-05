using System;

using VectorBoids.Library;

namespace VectorBoids
{
    internal class Program
    {
        private static readonly List<Boid> BoidsList = new();
        private readonly Random _random = new();
        
        static void Main(string[] args)
        {
            for (int bird = 0; bird < 25; bird++)
            {
                BoidsList.Add(new Boid(new Vector2D(bird, 10), new Vector2D(0, 3)));
            }
            
            var width = Console.WindowWidth;
            var height = Console.WindowHeight;

            foreach (var flock in BoidsList)
            {
                // flock.Separation(BoidsList);
                flock.Update(BoidsList, width, height, 40, 0.5);
            }

            while (true)
            {
                Console.Clear();
                foreach (var flock in BoidsList)
                {
                    flock.Update(BoidsList, width, height, 10, 0.1);
                    Console.SetCursorPosition(left:Math.Max(0, (int)flock._position.X), top: Math.Max(0, (int)flock._position.Y));
                    Console.Write("o");
                }
                Thread.Sleep(100);
            }
        }
    }
}