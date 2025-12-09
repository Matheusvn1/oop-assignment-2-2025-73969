using Xunit;
using System.Text.RegularExpressions;
using oop_assignment_2_2025_000000.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_1
    {
        private static readonly Regex MobilePattern =
            new Regex(Constants.IrishMobileRegex, RegexOptions.Compiled);

        [Fact]
        public void Test1()
        {
            Assert.True(MobilePattern.IsMatch("0831234567"), "Q1A Match Error: 0831234567 should be valid.");
            Assert.True(MobilePattern.IsMatch("0899988776"), "Q1A Match Error: 0899988776 should be valid.");
            Assert.True(MobilePattern.IsMatch("0851122334"), "Q1A Match Error: 085 prefix should be valid.");

            Assert.False(MobilePattern.IsMatch("0812345678"), "Q1A Non-Match Error: Invalid prefix 081 should be invalid.");
            Assert.False(MobilePattern.IsMatch("083 1234567"), "Q1A Non-Match Error: Spaces should be invalid.");
            Assert.False(MobilePattern.IsMatch("08312345678"), "Q1A Non-Match Error: 11 digits (too long) should be invalid.");
            Assert.False(MobilePattern.IsMatch("089123456"), "Q1A Non-Match Error: 9 digits (too short) should be invalid.");

            Assert.Equal(1, ExamQuestion_1.GetDiscountPercentage("Bronze"), "Q1B Error: Bronze should return 1.");
            Assert.Equal(5, ExamQuestion_1.GetDiscountPercentage("Silver"), "Q1B Error: Silver should return 5.");
            Assert.Equal(10, ExamQuestion_1.GetDiscountPercentage("Gold"), "Q1B Error: Gold should return 10.");
            Assert.Equal(15, ExamQuestion_1.GetDiscountPercentage("Platinum"), "Q1B Error: Platinum should return 15.");
            Assert.Equal(20, ExamQuestion_1.GetDiscountPercentage("Diamond"), "Q1B Error: Diamond should return 20.");
            Assert.Equal(25, ExamQuestion_1.GetDiscountPercentage("Elite"), "Q1B Error: Elite should return 25.");
            Assert.Equal(30, ExamQuestion_1.GetDiscountPercentage("VIP"), "Q1B Error: VIP should return 30.");

            Assert.Equal(0, ExamQuestion_1.GetDiscountPercentage("Unknown"), "Q1B Error: Unknown level should return 0.");
            Assert.Equal(0, ExamQuestion_1.GetDiscountPercentage("Guest"), "Q1B Error: Guest level should return 0.");
            Assert.Equal(0, ExamQuestion_1.GetDiscountPercentage("gold"), "Q1B Error: Lowercase 'gold' should return 0 (case sensitivity).");
            Assert.Equal(0, ExamQuestion_1.GetDiscountPercentage(null), "Q1B Error: Null input should return 0.");
        }
    }
