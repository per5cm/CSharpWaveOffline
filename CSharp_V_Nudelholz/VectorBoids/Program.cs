using System;

using VectorBoids.Library;

namespace VectorBoids
{
    internal class Program
    {
        private static readonly List<Boid> BoidsList = new();
        
        static void Main(string[] args)
        {
            for (int bird = 0; bird < 25; bird++)
            {
                BoidsList.Add(new Boid(new Vector2D(bird, 10), new Vector2D(0, 2)));
            }
            
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            foreach (var flock in BoidsList)
            {
                // flock.Separation(BoidsList);
                flock.Update(BoidsList, width, height);
            }

            while (true)
            {
                Console.Clear();
                foreach (var flock in BoidsList)
                {
                    flock.Update(BoidsList, width, height);
                    Console.SetCursorPosition((int)flock.Position.X, (int)flock.Position.Y);
                    Console.Write("o");
                }
                Thread.Sleep(100);
            }
        }
    }
}