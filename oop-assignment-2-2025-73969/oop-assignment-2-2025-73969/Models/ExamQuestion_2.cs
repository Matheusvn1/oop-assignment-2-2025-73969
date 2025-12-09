using System;
using System.Collections.Generic;
using System.Text;
namespace oop_assignment_2_2025_000000.Models
{
    public static class ExamQuestion_2
    {
        public static void Run()
        {
            SampleQuestionMethod();
            Console.WriteLine($"Divide(10, 2): {Divide(10, 2)}");
            Console.WriteLine($"Divide(10, 0): {Divide(10, 0)}");

            Console.WriteLine($"ConvertStringToInt(\"123\"): {ConvertStringToInt("123")}");
            Console.WriteLine($"ConvertStringToInt(\"abc\"): {ConvertStringToInt("abc")}"); 

            Console.WriteLine($"RegisterUser(25): {RegisterUser(25)}"); 
            Console.WriteLine($"RegisterUser(15): {RegisterUser(15)}"); 

        public static void SampleQuestionMethod()
        {
            
            Console.WriteLine("SampleMethod");
        
        public static string Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by zero.";
            }
        }
        public static string ConvertStringToInt(string input)
        {
            try
            {
                int value = int.Parse(input);
                return value.ToString();
            }
            catch (FormatException)
            {
            catch (ArgumentNullException)
            {
                return "Invalid number.";
            }
            catch (OverflowException)
            {
                return "Invalid number.";
            }
        }

        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(age),
                        "User must be at least 18 years old."
                    );
                }

                return "Registration successful.";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return "User must be at least 18 to register.";
            }
        }
    }
}