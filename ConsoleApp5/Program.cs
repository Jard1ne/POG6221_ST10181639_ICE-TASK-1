using System;

namespace ICEtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            Console.Write("Enter the total number of scripts to be marked: ");
            int totalScripts = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of questions constituting the test (1-10): ");
            int numQuestions = int.Parse(Console.ReadLine());

            int[] subtotals = new int[numQuestions];
            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write($"Enter the subtotal for question {i + 1}: ");
                subtotals[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number of lecturers who are going to mark the scripts: ");
            int numLecturers = int.Parse(Console.ReadLine());

            // Calculation
            int totalSubtotal = 0;
            foreach (int subtotal in subtotals)
            {
                totalSubtotal += subtotal;
            }

            int scriptsPerLecturer = totalScripts / numLecturers;
            int remainingScripts = totalScripts % numLecturers;

            int totalTime = (totalSubtotal * totalScripts) / 30; // 2 seconds per tick, 15 ticks per minute
            int timePerLecturer = totalTime / numLecturers;
            int remainingTime = totalTime % numLecturers;

            // Output
            Console.WriteLine($"Each lecturer will mark {scriptsPerLecturer} scripts, except the last one who will mark {scriptsPerLecturer + remainingScripts} scripts.");
            Console.WriteLine($"Each lecturer will take {timePerLecturer / 60} hours and {timePerLecturer % 60} minutes, except the last one who will take {timePerLecturer / 60 + remainingTime} hours and {timePerLecturer % 60 + (remainingTime >= 30 ? 1 : 0)} minutes.");
        }
    }
}