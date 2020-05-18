using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {

            bool isRunning = true;


            while (isRunning)
            {
                int results = 0;
                Console.WriteLine("Type 1 to add\nType 2 to substract\nType 3 to multiple\nType 4 to divide");
                Console.WriteLine("write exit to exit");
                string input = Console.ReadLine();
                if (input == "exit")

                {
                    break;
                }

                Console.WriteLine("Write a number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Write a second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int add(int firstNumber, int secondNumber)
                {

                    return firstNumber + secondNumber;
                }

                int sub(int firstNumber, int secondNumber)
                {

                    return firstNumber - secondNumber;
                }
                int mul(int firstNumber, int secondNumber)
                {

                    return firstNumber * secondNumber;
                }
                int div(int firstNumber, int secondNumber)
                {

                    return firstNumber / secondNumber;
                }


                if (input == "1")
                {

                    results = add(firstNumber, secondNumber);
                }
                else if (input == "2")
                {
                    results = sub(firstNumber, secondNumber);
                }
                else if (input == "3")
                {
                    results = mul(firstNumber, secondNumber);
                }
                else if (input == "4")
                {
                    results = div(firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("prøv en anden funktion");

                }
                Console.WriteLine(results);
            }
        }
        static int add(int firstNumber, int secondNumber)
        {

            return firstNumber + secondNumber;
        }

        static int sub(int firstNumber, int secondNumber)
        {

            return firstNumber - secondNumber;
        }
        static int mul(int firstNumber, int secondNumber)
        {

            return firstNumber * secondNumber;
        }
        static int div(int firstNumber, int secondNumber)
        {

            return firstNumber / secondNumber;
        }
    }
}