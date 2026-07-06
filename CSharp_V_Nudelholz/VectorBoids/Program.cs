using System;
using VectorBoids.FieldController;
using VectorBoids.Library;

namespace VectorBoids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vector Boids";

            var field = new Field(width: 800, height: 600, boidCount: 100);

            while (true)
            {
                Console.Clear();
                
                
                field.Update();
                Thread.Sleep(100); //frame delay
            }
        }
    }
}