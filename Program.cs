using System.Security.Cryptography.X509Certificates;

namespace Prog120_S24_L6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a whole number: ");

            int number;
            bool isValid = false;

            while(!isValid)
            {

            }

            // Iterative Loops
            // While
            // Do While
            // For



            // Foreach


            // Main




            // While
            // While Example
            // Validating Numbers
            // Try Parse

            // Do While
            // Do While Example
            // Password Checker

            // For Loop
            // For Loop Example
            // Sum and Average Numbers

            // Method
            static void MathClassExample()
            {
                // Math Library (Class)   
                // Area = 
                double radius = 2.5;
                int radiusInt = (int)radius;
                double areaDouble = Math.PI * (Math.Pow(radius, 2));
                double areaInt = Math.PI * (Math.Pow(radiusInt, 2));
                Console.WriteLine("Are with Double: " + areaDouble);
                Console.WriteLine("Are with Int: " + areaInt);
            } // MathClassExample

            static void WhileLoopExample()
            {
                int count = 0;

                // while(condition)

                while (count <= 10)
                {
                    Console.WriteLine(count);
                    count++; // Incrementer
                } // while
            } // WhileLoopExample


        }
    } // class
} // namespace

