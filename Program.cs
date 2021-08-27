using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program variables 
            string ProgramName = "Learn C#";
            string ProgramVersion = "1.0.0";
            string ProgramAuthor = "Digi Kris";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out program info
            Console.WriteLine("{0} Version {1} by {2}", ProgramName, ProgramVersion, ProgramAuthor);

            //Reset program color
            Console.ResetColor();

            //break
            Console.WriteLine();

            Console.WriteLine("Hello, World!\n");

            //Variables and values
            Console.WriteLine("VARIABLES AND VALUES.");
            short var1 = 32767;
            byte var2 = 255;
            float var3 = 3.402823e38F;
            char var4 = 'X';
            bool var5 = true;
            ulong var6 = 18446744073709551615UL;
            decimal var7 = 7.9M;
            sbyte var8 = 127;
            long var9 = 9223372036854775807L;
            ushort var10 = 65535;
            double var11 = 1.79769313486232308D;
            Console.WriteLine("short: " + var1);
            Console.WriteLine("byte: " + var2);
            Console.WriteLine("float: " + var3);
            Console.WriteLine("char: " + var4);
            Console.WriteLine("bool: " + var5);
            Console.WriteLine("ulong: " + var6);
            Console.WriteLine("decimal: " + var7);
            Console.WriteLine("sbyte: " + var8);
            Console.WriteLine("long: " + var9);
            Console.WriteLine("ushort: " + var10);
            Console.WriteLine("double: " + var11);

            //break
            Console.WriteLine();

            sbyte var12 = 127;
            long var13 = 9223372036854775807L;
            ushort var14 = 65535;
            double var15 = 1.79769313486232308D;

            if (var12.GetType() == typeof(SByte))
            {
                Console.WriteLine("var12 type ok.");
            }
            if (var13.GetType() == typeof(Int64))
            {
                Console.WriteLine("var13 type ok.");
            }
            if (var14.GetType() == typeof(UInt16))
            {
                Console.WriteLine("var14 type ok.");
            }
            if (var15.GetType() == typeof(Double))
            {
                Console.WriteLine("var15 type ok.");
            }

            //Operators 

            //break
            Console.WriteLine();

            Console.WriteLine("OPERATORS");
            int a = 6;
            int b = 7;
            int c = 5;

            if ((a != b) && (a < b))
            {
                if (a > c)
                    Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("try once more");
            }

            //Declare and assign values to the variables x, y, z and b so that the program outputs “Success!”.

            int x = 12;
            int y = 10;
            int z = 11;
            string s = "C";

            if (((x >= y) && (y < z)) || ((x > y) && (s == "A")))
            {
                if (s == "C")
                {
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("Almost there!");
                }
            }
            else
            {
                Console.WriteLine("Not quite, try once more!");
            }

            //break
            Console.WriteLine();

            //Casting vote 

            Console.WriteLine("VOTE CASTING");
            int age;
            Console.Write("Enter your age: ");
            //Remove int age; and while loop if you don't want the while loop
            //add int age = Convert.ToInt32(Console.ReadLine()); if you don't want the while loop
            //Don't close program when a letter is input, accept only numbers
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is not valid input.");
                Console.ResetColor();
                Console.Write("Please enter a number: ");
            }
            if (age >= 21)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else Console.WriteLine("You are not allowed to play this game.");

            //break
            Console.WriteLine();

            //user to input two integers and then tells which of the numbers is greater or if they are equal.

            Console.WriteLine("INPUT TWO NUMBERS AND THE PROGRAM WILL TELL YOU WHICH OF THE NUMBERS IS GREATER OR IF THEY ARE EQUAL.");
            int int1, int2;
            Console.Write("Please input the first number: ");
            while (!int.TryParse(Console.ReadLine(), out int1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is not valid input.");
                Console.ResetColor();
                Console.Write("Please enter a number: ");
            }
            Console.Write("Please input the second number: ");
            while (!int.TryParse(Console.ReadLine(), out int2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is not valid input.");
                Console.ResetColor();
                Console.Write("Please enter a number: ");
            }
            if (int1 < int2)
                Console.WriteLine("Number {1} is greater than number {0}", int1, int2);
            if (int1 > int2) Console.WriteLine("Number {0} is greater than number {1}", int1, int2);
            if (int1 == int2)
                Console.WriteLine("Numbers are equal.");

            //break
            Console.WriteLine();

            //Question and answer

            Console.WriteLine("QUESTION AND ANSWER.");
            string fruit;
            Console.Write("What is your favourite fruit? ");
            fruit = Console.ReadLine();
            Console.WriteLine("Your favourite fruit is " + fruit);

            //break
            Console.WriteLine();

            //Selection 

            Console.WriteLine("SELECTION.");
            Console.WriteLine("Please choose your desired product, write the number.");
            Console.WriteLine("1. Hamburger");
            Console.WriteLine("2. Cheese Burger");
            Console.WriteLine("3. 2 dollar hot dog and 1 dollar water");

            int Selection = int.Parse(Console.ReadLine());

            switch (Selection)
            {

                case 1:
                    Console.WriteLine("Hamburger.");
                    break;

                case 2:
                    Console.WriteLine("Cheese Burger.");
                    break;

                case 3:
                    Console.WriteLine("A wise decision.");
                    break;

                default:
                    Console.WriteLine("Unknown choice.");
                    break;

            }

            //break
            Console.WriteLine();

            //Finding the quadrant 

            Console.WriteLine("QUADRANTS.");
            Console.WriteLine("Write numbers for X and Y axis to find the quadrant for a point in x-y axis:");

            Console.Write("X coordinate: ");
            int co1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y coordinate: ");
            int co2 = Convert.ToInt32(Console.ReadLine());


            if (co1 > 0 && co2 > 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) is in the First quadrant.", co1, co2);
            }
            else if (co1 < 0 && co2 > 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) is in the Second quadrant.", co1, co2);
            }
            else if (co1 < 0 && co2 < 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) is in the Third quadrant.", co1, co2);
            }
            else if (co1 > 0 && co2 < 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) is in the Fourth quadrant.", co1, co2);
            }
            else if (co1 == 0 && co2 == 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) is is at the origin.", co1, co2);
            }

            //break
            Console.WriteLine();

            //Summing the Inputs

            Console.WriteLine("SUMMING THE INPUTS.");
            Console.WriteLine("Your goal is to reach a sum the program is looking for.");

            int index = 0;
            int total = 0;
            int target = 200;


            while (total <= target)
            {
                Console.Write("Sum is now {0}. ", total);
                Console.Write("Input: ", index);
                total += Convert.ToInt32(Console.ReadLine());
                index++;
            }

            while (total == target) ;
            Console.WriteLine("Congratulations, the goal was {0}. The total was {1}.", target, total);

            //break
            Console.WriteLine();

            //6.1 Repeating Numbers

            Console.WriteLine("REPEATING NUMBERS.");

            int i, j, rows;

            Console.Write("Display the pattern as right angle triangle using number:\n");
            Console.Write("-----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }

            //break
            Console.WriteLine();

            //List of Numbers

            Console.WriteLine("LIST OF NUMBERS");
            int input;
            List<int> numbers = new List<int>();
            Console.WriteLine("Program asks for numbers untill a negative or zero number is input.");
            do
            {
                Console.Write("Input a number:");
                input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }
            while (input > 0);
            numbers.Remove(-1);
            numbers.Remove(-100);
            Console.Write("Your input: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            //break
            Console.WriteLine();
            //break
            Console.WriteLine();

            //Modifying a List

            Console.WriteLine("MODIFYING A LIST");
            List<string> names = new List<string> { "Torvalds", "Musk", "Gates", "Buffet", "Dorsey" };

            names[names.FindIndex(ind => ind.Equals("Torvalds"))] = "Jobs";
            names[names.FindIndex(ind => ind.Equals("Gates"))] = "McAfee";
            names[names.FindIndex(ind => ind.Equals("Dorsey"))] = "Wozniak";

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //break
            Console.WriteLine();
            //break
            Console.WriteLine();

            //6.3 Printing Characters

            Console.WriteLine("PRINTING CHARACTERS.");
            Console.WriteLine("'L', 'e', 'a', 'r', 'n', 'C', '#'.\n");
            char[] characters = { 'L', 'e', 'a', 'r', 'n', 'C', '#' };
            foreach (char ch in characters)
            {
                Console.Write(ch);
            }

            //break
            Console.WriteLine();
            //break
            Console.WriteLine();

            Console.WriteLine("BUBBLE SORT.");
            int[] arr = { 1, 2, 9, 100, 33, 81, 22 };
            int temp;
            for (int k = 0; k <= arr.Length - 2; k++)
            {
                for (int f = 0; f <= arr.Length - 2; f++)
                {
                    if (arr[f] > arr[f + 1])
                    {
                        temp = arr[f + 1];
                        arr[f + 1] = arr[f];
                        arr[f] = temp;
                    }
                }
            }

            foreach (int p in arr)
                Console.Write(p + " ");

            //break
            Console.WriteLine();
            //break
            Console.WriteLine();

            Console.WriteLine("THAT IS THE END OF THIS PROGRAM, TSAU!");
            Console.ReadLine();
        }
    }
}