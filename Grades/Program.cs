using System;
using System.IO;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            GetBookName(book);
            AddGrades(book);
            WriteResults(book);
            SaveGrades(book);

            Console.ReadLine();
        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputfile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputfile);
            }
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResults("Average", stats.AverageGrade);
            WriteResults("Highest", (int)stats.HighestGrade);
            WriteResults("Lowest", stats.LowestGrade);
            WriteResults(stats.Description, stats.LetterGrade);
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(95);
            book.AddGrade(65);
            book.AddGrade(79);
            book.AddGrade(88.5f);
            book.AddGrade(77.9f);
            book.AddGrade(91);
            book.AddGrade(82);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a Grade Book Name:");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"{existingName} has changed to: {newName}");
        }

        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
        }

        public static void WriteResults(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }


        public static void WriteResults(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F1}");
        }
    }
}
