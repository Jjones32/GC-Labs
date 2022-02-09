using System;

namespace NumberAnalyzerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = true;
            
            


                Console.WriteLine("Hello, Please enter your name");
                var name = Console.ReadLine();

                Console.WriteLine("Hello, " + name + " please enter a number between 1 and 100");
                Console.WriteLine(" ");
                string userInput = Console.ReadLine();
                Console.WriteLine(" ");
                int numInput = int.Parse(userInput);
                var answr = numInput % 2;
                    Console.WriteLine("Would you like to run the analyzer again? (y/n)");  



                if (answr == 0)
                {
                    Console.WriteLine("Number is Even,");
                }
                if (answr != 0)
                {
                    Console.WriteLine("Number is Odd");
                }
                if (numInput >= 2 && numInput <= 24)
                {
                    Console.WriteLine("Your number " + numInput + " is even and less than 25!");
                }
                if (numInput >= 26 && numInput <= 60)
                {
                    Console.WriteLine("Your number " + numInput + " is even and between 26 and 60!");
                }
                if (numInput >= 60)
                {
                    Console.WriteLine("Your number " + numInput + " is even greater than 60!");
                }
              
                    if (numInput <= 60 && numInput >= 1)
                    {
                        Console.WriteLine("Your number " + name + numInput + " is odd and less than 60!");
                    }
                    if (numInput >= 60)
                    {
                        Console.WriteLine("Your number " + numInput + " is odd and greater than 60!");

                    }


        }
    }
}
