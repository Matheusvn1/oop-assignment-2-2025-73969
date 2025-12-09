using Xunit;
using System;
using System.Globalization;
using oop_assignment_2_2025_000000.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_5
    {
        [Fact]
        public void Test1()
        {
            DateTime dateA = new DateTime(2025, 7, 4);
            string resultA = ExamQuestion_5.FormatDateToDDMMYYYY(dateA);
            Assert.Equal("04/07/2025", resultA, userMessage: "Q5A Error: Date format failed to produce 'dd/MM/yyyy'.");


            DateTime dateA2 = new DateTime(2025, 12, 15);
            string resultA2 = ExamQuestion_5.FormatDateToDDMMYYYY(dateA2);
            Assert.Equal("15/12/2025", resultA2, userMessage: "Q5A Error: Date format failed for non-padded values.");


            string resultB = ExamQuestion_5.GetCurrentTime12HrFormat()
                resultB,
                "hh:mm tt",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out parsedTime
            );
            Assert.True(isValidFormat, userMessage: "Q5B Error: Current time format failed to match 'hh:mm tt'.");
            string dateStringC = "2025-11-30";
            string resultC = ExamQuestion_5.ParseAndFormatDate(dateStringC);
            Assert.Equal("Sunday, 30 November 2025", resultC, userMessage: "Q5C Error: Date parsing or final formatting failed for the example date.");

            string dateStringC2 = "2025-12-01";
            string resultC2 = ExamQuestion_5.ParseAndFormatDate(dateStringC2);
            Assert.Equal("Monday, 01 December 2025", resultC2, userMessage: "Q5C Error: Failed to format a different date correctly.");
        }
    }
