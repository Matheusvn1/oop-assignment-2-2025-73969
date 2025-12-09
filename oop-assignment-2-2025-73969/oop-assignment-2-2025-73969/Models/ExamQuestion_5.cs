using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_000000.Models
{
    public static class ExamQuestion_5
    {
        public static void Run()
        {
            SampleQuestionMethod();

           
            DateTime dateA = new DateTime(2025, 7, 4);
            Console.WriteLine($"Q5.A Input {dateA}: {FormatDateToDDMMYYYY(dateA)}"); 

           
            Console.WriteLine($"Q5.B Current Time: {GetCurrentTime12HrFormat()}");

            string dateString = "2025-11-30";
            Console.WriteLine($"Q5.C Input '{dateString}': {ParseAndFormatDate(dateString)}"); // Expected: Sunday, 30 November 2025
        }

        public static void SampleQuestionMethod()
        {
            Console.WriteLine("SampleMethod");
        }
        public static string FormatDateToDDMMYYYY(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public static string GetCurrentTime12HrFormat()
        {
            return DateTime.Now.ToString("hh:mm tt");
        }
        public static string ParseAndFormatDate(string dateString)
        {
            DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return date.ToString("dddd, dd MMMM yyyy");
        }
    }
}