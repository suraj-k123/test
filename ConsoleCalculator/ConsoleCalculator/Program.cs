using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            string Continue;
            do
            {
                Console.WriteLine("********Console Calculator Options********");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("Please select your operation : (1, 2, 3, 4)");
                Console.WriteLine();
                string s = Console.ReadLine();

                switch (s)
                {
                    case "1":

                        Console.Write("Please Enter value1 : ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please Enter Value2 : ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Sum is : ");
                        Console.WriteLine(num1 + num2);
                        Console.ReadLine();


                        break;

                    case "2":

                        Console.Write("Please Enter value1 : ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please Enter Value2 : ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Sub is: ");
                        Console.WriteLine(num1 - num2);
                        Console.ReadLine();
                        break;

                    case "3":

                        Console.Write("Please Enter value1 : ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please Enter Value2 : ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Product is : ");
                        Console.WriteLine(num1 * num2);
                        Console.ReadLine();
                        break;

                    case "4":

                        Console.Write("Please Enter value1 : ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please Enter Value2 : ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Div is: ");
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        Console.ReadLine();
                        break;
                }


                Console.Write(" Do you wish to perform another operation: y/n?");
                Continue = Console.ReadLine();
            }
            while (Continue != "n");



        }


    }
}
