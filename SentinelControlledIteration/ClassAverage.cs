using System;

namespace SentinelControlledIteration
{
    class ClassAverage
    {
        static void Main(string[] args)
        {
            // Initialization phase
            int total = 0; // Initalize sum of grades
            int gradeCounter = 0; // Initialize # of grades entered so far

            // Processing phase
            // Prompt for input and read grade from user
            Console.WriteLine("Enter grade or -1 to quit: ");
            int grade = int.Parse(Console.ReadLine());

            // Loop unitl sentinel value is read from user 
            while (grade != -1)
            {
                total = total + grade; // Add grade to total
                gradeCounter = gradeCounter + 1; //  Increment counter

                // Prompt for input and read grade from user
                Console.Write("Enter grade or -1 to quit: ");
                grade = int.Parse(Console.ReadLine());
            }

            // Termination phase
            // If user entered at least one grade . . . 
            if (gradeCounter != 0)
            {
                // Use number with decimal point to calculate average of grades
                double average = (double)total / gradeCounter;

                // Display the total and average (with two digits of precision)
                Console.WriteLine($"\nTotal of the {gradeCounter} grades entered is {total}");
                Console.WriteLine($"Class average is {average:F}");
            }
            else
            {
                Console.WriteLine("No grades were entered");
            }
        }
    }
}
