using System;
using System.Reflection.Metadata.Ecma335;

namespace LambdaExpressions
{
    class Lambda
    {
        internal static void Main (string[] args)
        {
            var lambda = new Lambda ();

            //Most important ways people write lambdas

            //C#x => x * 2

            //x => { return x * 2; }

            //(int x) => x * 2

            //x => DoSomething(x)

            //() => Console.WriteLine("hello")

            //(x, y) => x + y

            //_ => 42               // ignore parameter
            IsPositive();
        }

        public bool IsPositive(int number)
        {
            => return number > 0;
        }
    }
}