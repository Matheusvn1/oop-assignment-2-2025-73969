using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_000000.Models
{
    public static class ExamQuestion_4
    {
        public static void Run()
        {
            SampleQuestionMethod();
            Console.WriteLine($"Q4.A Input 42: {FormatInteger(42)}");       
            Console.WriteLine($"Q4.A Input 12345: {FormatInteger(12345)}"); 

            Console.WriteLine($"Q4.B Input 1234.5: {FormatPrice(1234.5m)}"); 
            Console.WriteLine($"Q4.B Input 9.99: {FormatPrice(9.99m)}");     
        }

        public static void SampleQuestionMethod()
        {
            Console.WriteLine("SampleMethod");
        }

      name="number">The integer input.</param>
        public static string FormatInteger(int number)
        {

            return number.ToString("D5");
        }

        name="price">The decimal price input.</param>
        public static string FormatPrice(decimal price)
        {
            var euroCulture = new CultureInfo("IE");

            return price.ToString("C2", euroCulture);
        }
    }
}