using System;

namespace StudentGradeSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array 
            string[] StName = new string[25];
            string[] StGrade = new string[25];

            // array length
            Console.WriteLine(" How many student will you enter? ");
            int n = int.Parse(Console.ReadLine());

            // Enter Student Name,Grade loop
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of the student: ");
                StName[i] = Console.ReadLine();

                Console.WriteLine("Enter the grade of the student: ");
                StGrade[i] = Console.ReadLine();


                // print grade passed or failed loop
                for (int j = 1; j < n; ++j)
                {

                        if (int.Parse(StGrade[i]) >= 60)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("The student passed");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The student failed");
                        Console.ResetColor();
                    }         
                        // print all the arrays
            Console.WriteLine(" The student and their grades:");

            foreach (var item in StName.Union(StGrade))
            {
                Console.Write($"   {item}");
            }
                }
         

            }



        }
    }
}