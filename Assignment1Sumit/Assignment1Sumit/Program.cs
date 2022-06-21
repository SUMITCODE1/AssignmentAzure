using System;

namespace Assignment1Sumit
{
    class Program
    {
        static void Main(string[] args)
        {

            int fatherAge = 40;

            int SonAge = 22;

            int Diff=fatherAge-SonAge;

            string X = "surya";

            string Y = "arvind";
            X = X.ToUpper();
            Y = Y.ToUpper();

            //Convert father and son names as uppercase

            Console.WriteLine( $"Father name is {X} And his present age is { fatherAge } ");

            Console.WriteLine( $"Son name is { Y } And his present age is { SonAge } ");

            Console.WriteLine( $"What is the difference between father and son: { Diff}");

            Console.Read();

        }
    }
}
