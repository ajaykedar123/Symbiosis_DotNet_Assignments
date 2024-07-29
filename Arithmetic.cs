using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public delegate void Operation(int n1, int n2);  
    internal class Arithmetic
    {
        int n1, n2;
        public void AddNumbers(int n1, int n2) 
        {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }
        public void MultiplyNumbers(int n1, int n2)
        {
            Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            int n1, n2, ch;
            //Object of arithmetic Class
            Arithmetic arithmetic = new Arithmetic();

            // Delegate Reference
            Operation operation = null;

            //Accept the user input
            Console.WriteLine("Enter first number: ");
            n1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            n2=Convert.ToInt32(Console.ReadLine());

            //accept user choice
            do
            {
                Console.Write("\nChoose and Operations:\n1.Addition\n2.Multiplication\n3.Both Operations\n4.Exit\nEnter the Choice:");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1 : //Addition
                        operation = arithmetic.AddNumbers;
                        Console.WriteLine($"\n---Addition of {n1} + {n2}---");
                        operation.Invoke(n1, n2);
                        break;

                    case 2 : //Multiplication
                        operation = arithmetic.MultiplyNumbers;
                        Console.WriteLine($"\n---Multiplication of {n1} x {n2}---");
                        operation.Invoke(n1, n2);
                        break;

                    case 3 : //Both
                        operation = arithmetic.AddNumbers;
                        Console.WriteLine($"\n---Addition of {n1} + {n2}---");
                        operation.Invoke(n1, n2);

                        operation = arithmetic.MultiplyNumbers;
                        Console.WriteLine($"\n---Multiplication of {n1} x {n2}---");
                        operation.Invoke(n1, n2);

                        break;
                    case 4: //exit
                        Console.WriteLine("\nPress enter to exit...");
                        break;

                    default: //default
                        Console.WriteLine("Invalid Choice!");
                        break;

                }
            } while (ch != 4);

        }
    }
}

