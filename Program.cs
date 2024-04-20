using System.Security.Cryptography.X509Certificates;

namespace Prog120_S24_L6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vicky Le
            // Programming 120
            // 4/18/24
            
            string student1Name = "Coby";
            string student2Name = "Hoang";
            string student3Name = "Vicky";

            string[] students = new string[7];
            students[0] = "Coby";
            students[1] = "Brian";
            students[2] = "Vitalii";
            students[3] = "Vicky";
            students[4] = "Carla";
            students[5] = "Hoang";
            students[6] = "Will";

           // index
          
            for (int i = 0; i < students.Length; i++)
            {
                int index = i;
                string currentStudent = students[index];
                Console.WriteLine($"{index} : {currentStudent}");
            }

        } // Main


        // While
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

        // While Example
        // Validating Numbers
        static void ValidDateUserInput()
            {
                Console.Write("Please enter a whole number: ");

                int number = 0;
                bool isValid = false;

                while (!isValid)
                {
                    string userReponse = Console.ReadLine();

                    // If the user enters in a valid number
                    // int.Tryparse will return true
                    // Inside of our if statement, we will switch is valid to true
                    if (int.TryParse(userReponse, out number))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid whole number: ");
                    }


                } // ValidDateUserInput
                // If a variable is not initialized by the time it is used, C# compiler will throw an error
                Console.WriteLine($"Your number was {number}");
                // Try Parse

                // Do While

            }
            // Do While Example
            static void DoWhileExample()
            {
                int count = 11;

                // do while

                do
                {
                    Console.WriteLine(count);
                } while (count <= 10);

                //while(count <= 10)
                //{
                //    Console.WriteLine(count);
                //}
                Console.WriteLine("This is after our while loop");
            } // DoWhileExample
            // Password Checker
            static void PasswordValidation()
            {
                string password;
                bool isValidPassword;

                string userPassword = "Le";

                Console.WriteLine("Enter your password:");
                password = Console.ReadLine();

                // Checking to see if pass is valid
                isValidPassword = password == userPassword;

                do
                {
                    Console.Write("Enter your password:");
                    password = Console.ReadLine();
                    isValidPassword = password == userPassword;

                } while (!isValidPassword);

                Console.WriteLine("You have logged in");

                // If pass is INVALID, ontinue to ask user for their pass
                //while(!isValidPassword)
                //{
                //    Console.WriteLine("Invalid Password.");
                //    Console.Write("Enter your password:");
                //    password = Console.ReadLine();
                //    isValidPassword = password == userPassword;
                //}
            } // 

            // For Loop

            // For Loop Example
            static void ForLoopExample()
        {
            // For loop

            //// Declared our variable
            //int count = 0;

            //// Checked our condition (if true, it ran)
            //while(count < 10)
            //{
            //    // Code to run
            //    Console.WriteLine($"Count: {count}");

            //    // Incremented our variable
            //    count++;
            //}

            // keyword for
            //for(
            //    int i = 0; // Declare our variable
            //    i < 10; // Condition
            //    i++ // Increment
            //    )
            //{
            //    Console.WriteLine(i);
            //} // for

            // Start at 450
            // End at - 25 
            // -4

            for (int i = 450; i > -25; i -= 5)
            {
                Console.WriteLine(i);
            }
        }  // ForLoopExample



        // Sum and Average Numbers
        static void SumAndAverageNumbers()
        {
            // For Loop
            int sum = 0;
            int count = 0;

            // To get the average: sum of of numbers / count of numbers

            for (int i = 0; i < 300; i += 4)
            {
                // Adding i to the sum variable
                sum += i;
                // count is keep track of how many times we loop
                count++;
            }
            Console.WriteLine($"Sum: {sum} - Count: {count}");
            double avg = (double)sum / count;
            Console.WriteLine($"Average: {sum % count}");
        } // SumAndAverageNumbers

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

           
        
    } // class
} // namespace

