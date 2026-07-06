using System;
using System.Security.Cryptography;
using VectorBoids.FieldController;
using VectorBoids.View;

namespace VectorBoids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vector Boids";
            
            double width = Console.WindowWidth;
            double height = Console.WindowHeight;
            int boidCount = 100;
            double padding = 5;
            double turn = 0.5;

            var field = new Field(width, height, boidCount);
            var renderer = new Renderer((int)width, (int)height);

            while (true)
            {
                Console.Clear();
                renderer.Draw(field.GetBoids());
                field.Update(padding, turn);
                Thread.Sleep(100); //frame delay
            }
        }
    }
}