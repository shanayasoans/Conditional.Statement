/*
 Author: Shanaya Soans 
 Date: 1/29/20
 Comments: This C# console application code demonstartes the use of conditional statments 
 after getting inputs from users of the grade they would expect in the course.
*/

using System;

namespace Conditional.Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their input
            Console.WriteLine("Please enter expected grade for ISM 4300");
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /*
                  This input will be used to store grades
                  after the input variable is parsed to integers
                */
                int grade = int.Parse(input);

                if (grade >= 98) Console.WriteLine("Grade: A+");
                else if ((grade >= 92) && (grade <= 97)) Console.WriteLine("Grade: A");
                else if ((grade >= 90) && (grade <= 91)) Console.WriteLine("Grade: A-");
                else if ((grade >= 88) && (grade <= 89)) Console.WriteLine("Grade: B+");
                else if ((grade >= 82) && (grade <= 87)) Console.WriteLine("Grade: B");
                else if ((grade >= 80) && (grade <= 81)) Console.WriteLine("Grade: B-");
                else if ((grade >= 78) && (grade <= 79)) Console.WriteLine("Grade: C+");
                else if ((grade >= 72) && (grade <= 77)) Console.WriteLine("Grade: C");
                else if ((grade >= 70) && (grade <= 71)) Console.WriteLine("Grade: C-");
                else if ((grade >= 68) && (grade <= 69)) Console.WriteLine("Grade: D+");
                else if ((grade >= 62) && (grade <= 67)) Console.WriteLine("Grade: D");
                else if ((grade >= 60) && (grade <= 61)) Console.WriteLine("Grade: D-");
                else if (grade < 60) Console.WriteLine("Grade: F");
                Console.ReadKey(true);

            }
            catch
            {
                Console.WriteLine("Please enter an integer value as your grade");
                Console.WriteLine("Press any key to exit the program and try again..");
                Console.ReadKey(true);
            }
        }
    }
}
