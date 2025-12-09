using Xunit;
using oop_assignment_2_2025_000000.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_4
    {
        [Fact]
        public void Test1()
        {
            string resultA1 = ExamQuestion_4.FormatInteger(42);
            Assert.Equal("00042", resultA1, userMessage: "Q4A Error: Input 42 should be padded to '00042'.");

            string resultA2 = ExamQuestion_4.FormatInteger(5);
            Assert.Equal("00005", resultA2, userMessage: "Q4A Error: Input 5 should be padded to '00005'.");

            string resultA3 = ExamQuestion_4.FormatInteger(12345);
            Assert.Equal("12345", resultA3, userMessage: "Q4A Error: Input 12345 should remain '12345'.");

            string resultB1 = ExamQuestion_4.FormatPrice(1234.5m);
            Assert.Equal("€1,234.50", resultB1, userMessage: "Q4B Error: Price 1234.5 failed to format to '€1,234.50'.");

            string resultB2 = ExamQuestion_4.FormatPrice(9.9m);
            Assert.Equal("€9.90", resultB2, userMessage: "Q4B Error: Price 9.9 failed to format to '€9.90'.");

            string resultB3 = ExamQuestion_4.FormatPrice(1000000.75m);
            Assert.Equal("€1,000,000.75", resultB3, userMessage: "Q4B Error: Price 1000000.75 failed to format correctly.");
        }
    }
