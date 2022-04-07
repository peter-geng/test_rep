using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace proj1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            Console.Write(s1[0]);

            //add logic here
            Console.WriteLine("Enter an integer value: ");
            Console.WriteLine("I read: " + Console.ReadLine());

            Console.WriteLine("Enter an integer value: ");
            int num1 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter an operator [ Subtract -, Plus + , Multiply * or Division / ]:");
            String oper = Console.ReadLine();

            Console.WriteLine("Enter another integer value: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (oper == "+")
            {
                Console.WriteLine(num1 + " plus " + num2 + "equals" + (num1 + num2));
            }
            else if (oper == "-")
            {
                Console.WriteLine(num1 + " minus " + num2 + "equals" + (num1 - num2));
            }
            else if (oper == "*")
            {
                Console.WriteLine(num1 + " minus " + num2 + "equals" + (num1 * num2));
            }
            else if (oper == "/")
            {
                Console.WriteLine(num1 + " minus " + num2 + "equals" + (num1 / num2));
            }

        }
     }
 }

