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

            FieldController.Field();
        }
    }
}