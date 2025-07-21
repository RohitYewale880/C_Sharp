using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the statements =>

            //Console.Write("Enter The word you want to display : ");
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            //Console.ReadLine();    


            // Addition of two numbers =>

            //int a = 12;            
            //int b = 12;            
            //Console.Write("Addition of two number is => ");
            //Console.WriteLine(a + b);
            //Console.ReadLine();    


            // print your name user gives the name what he wants to prints =>

            //Console.WriteLine("Enter Your name =>");
            //string name = Console.ReadLine();
            //Console.WriteLine("My name is " + name + ".");
            //Console.Read();

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Operators in C# =>

            // Arthmetic operaters =
            //int a = 4, b = 2;
            //Console.WriteLine("Calculation result of 4 + 2 is = " + (a + b));
            //Console.WriteLine("Calculation result of 4 - 2 is = " + (a - b));
            //Console.WriteLine("Calculation result of 4 * 2 is = " + (a * b));
            //Console.WriteLine("Calculation result of 4 / 2 is = " + (a / b));
            //Console.WriteLine("Calculation result of 4 % 2 is = " + (a % b));
            //Console.ReadLine();


            //Assignment Operater
            //int a = 4, b = a;
            //Console.WriteLine(( b +=4 ));
            //Console.WriteLine(( b -= 4));
            //Console.WriteLine(( b *= 4));
            //Console.WriteLine(( b /= 4));
            //Console.WriteLine(( b %= 4));
            //Console.ReadLine();

            //Comparision Operater
            //int a = 4, b = 2;
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a <= b);
            //Console.ReadLine();

            //logical Operater
            //Console.WriteLine(true && true);
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////


            // Math classes in the C# =>

            //Console.WriteLine(Math.Abs(-5));
            //Console.WriteLine(Math.Ceiling(4.5));
            //Console.WriteLine(Math.Floor(4.8));
            //Console.WriteLine(Math.Round(4.5));
            //Console.WriteLine(Math.Max(10,20));
            //Console.WriteLine(Math.Min(10,20));
            //Console.WriteLine(Math.Sqrt(25));
            //Console.WriteLine(Math.Pow(2,3));
            //Console.WriteLine(Math.Sin(Math.PI/2));
            //Console.WriteLine(Math.Cos(0));
            //Console.WriteLine(Math.Tan(0));
            //Console.WriteLine(Math.Log(Math.E));
            //Console.WriteLine(Math.Log10(100));
            //Console.WriteLine(Math.Truncate(3.75));
            ////Maths Constants in the C#
            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.E);
            //Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //String in C# =>

            //string name = " Rohit Yewale";
            //Console.WriteLine(name);
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name.Substring(3,3));
            //Console.WriteLine(name.Replace("R","M"));
            //Console.WriteLine(name.Contains("hit"));
            //Console.WriteLine(name.IndexOf("t"));
            //Console.WriteLine(name.Split(' '));
            //Console.ReadLine();

            //string concatination
            //string first = "rohit";
            //string secound = "yewale";
            //string result = first + " " + secound;
            //Console.WriteLine(result);
            //Console.ReadLine();

            //srting interpolation
            //string name = "Rohit";
            //string interpolated = $"Hello {name}!";
            //Console.WriteLine(interpolated);
            //Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Decision control in C#

            //Console.WriteLine("Enter your age to know you can drive or not");
            //string Wage = (Console.ReadLine());
            //int age = Convert.ToInt32(Wage);

            //    if(age < 2)
            //    {
            //        Console.WriteLine("you are just born");
            //    }
            //    else if (age < 18)
            //    {
            //        Console.WriteLine("wait for you become a 18 years old");
            //    }
            //    else if (age > 75)
            //    {
            //        Console.WriteLine("it is risk to drive, please dont drive!!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("yea you can drive...");
            //    }

            //Console.ReadLine();



            //Switch control in C#

            Console.WriteLine("Enter your age to know you can drive or not");
            int age = Convert.ToInt32(Console.ReadLine());

            // Categorize age into groups
            string ageGroup;

            if (age < 2)
                ageGroup = "baby";
            else if (age < 18)
                ageGroup = "minor";
            else if (age > 75)
                ageGroup = "senior";
            else
                ageGroup = "adult";

            // Use switch to decide message
            switch (ageGroup)
            {
                case "baby":
                    Console.WriteLine("You are just born");
                    break;
                case "minor":
                    Console.WriteLine("Wait until you become 18 years old");
                    break;
                case "senior":
                    Console.WriteLine("It is risky to drive, please don't drive!!!");
                    break;
                case "adult":
                    Console.WriteLine("Yes, you can drive...");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
