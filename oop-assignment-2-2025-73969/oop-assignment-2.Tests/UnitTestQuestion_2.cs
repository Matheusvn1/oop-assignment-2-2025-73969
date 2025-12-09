using Xunit;
using oop_assignment_2_2025_000000.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_2
    {
        [Fact]
        public void Test1()
        {
            string resultA1 = ExamQuestion_2.Divide(10, 2);
            Assert.Equal("5", resultA1);

 
            string resultA2 = ExamQuestion_2.Divide(10, 0);
            Assert.Equal("Cannot divide by zero.", resultA2);


            string resultB1 = ExamQuestion_2.ConvertStringToInt("987");
            Assert.Equal("987", resultB1);

            string resultB2 = ExamQuestion_2.ConvertStringToInt("abc");
            Assert.Equal("Invalid number.", resultB2);

            string resultC1 = ExamQuestion_2.RegisterUser(25);
            Assert.Equal("Registration successful.", resultC1);

            string resultC2 = ExamQuestion_2.RegisterUser(15);
            Assert.Equal("User must be at least 18 to register.", resultC2);
        }
    }
