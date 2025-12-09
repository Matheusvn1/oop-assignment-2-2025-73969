using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
namespace oop_assignment_2_2025_000000.Models
{
    public static class Constants
    {
        public const string IrishMobile = @"^(083|085|089)\d{7}$";
    }

    public static class ExamQuestion_1
    {
        public static void Run()
        {
            SampleQuestionAMethod();
            SampleQuestionBMethod();
            Console.WriteLine($"Bronze Discount: {GetDiscountPercentage("Bronze")}%");
        }

        public static void SampleQuestionAMethod()
        {
            Console.WriteLine("SampleMethod A");
        }

        public static void SampleQuestionBMethod()
        {

            Console.WriteLine("SampleMethod B");
        }
        public static int GetDiscountPercentage(string level)
        {
            return level switch
            {
                "Bronze" => 1,
                "Silver" => 5,
                "Gold" => 10,
                "Platinum" => 15,
                "Diamond" => 20,
                "Elite" => 25,
                "VIP" => 30,
                _ => 0,
            };
        }
    }
}
