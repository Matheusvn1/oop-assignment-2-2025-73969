using Xunit;
using System.Collections.Generic;
using oop_assignment_2_2025_000000.Models;
namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_3
    {
        private readonly List<Product> testProducts = new List<Product>
        {
            new Product("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
            new Product("Headphones", new List<int> { 4, 3, 5 }),
            new Product("Keyboard", new List<int> { 5, 5, 5, 4 }),
            new Product("Mouse", new List<int> { 3, 3, 4 }),
            new Product("EmptyItem", new List<int> { }),
            new Product("AnotherTop", new List<int> { 5, 5, 5, 5, 5 })
        };

        [Fact]
        public void Test1()
        {
            Assert.Equal(4.2, ExamQuestion_3.CalculateAverageRating(testProducts[0].Ratings), precision: 6, userMessage: "Q3.1 Error: Laptop average should be 4.2.");

            Assert.Equal(4.75, ExamQuestion_3.CalculateAverageRating(testProducts[2].Ratings), precision: 6, userMessage: "Q3.1 Error: Keyboard average should be 4.75.");

            Assert.Equal(3.3333333333333335, ExamQuestion_3.CalculateAverageRating(testProducts[3].Ratings), precision: 6, userMessage: "Q3.1 Error: Mouse average calculation failed.");

            Assert.Equal(0.0, ExamQuestion_3.CalculateAverageRating(testProducts[4].Ratings), userMessage: "Q3.3 Error: Empty list should return 0.0.");

            Assert.Equal(0.0, ExamQuestion_3.CalculateAverageRating(null), userMessage: "Q3.3 Error: Null list should return 0.0.");

            Product topRatedProduct = null;
            double highestAverage = -1;

            foreach (var product in testProducts)
            {
                double average = ExamQuestion_3.CalculateAverageRating(product.Ratings);
                {
                    highestAverage = average;
                    topRatedProduct = product;
                }
            }
            Assert.NotNull(topRatedProduct);
            Assert.Equal("AnotherTop", topRatedProduct.Name, userMessage: "Q3.2 Error: Did not correctly identify the highest-rated product.");
            Assert.Equal(5.0, highestAverage, precision: 6, userMessage: "Q3.2 Error: Highest average calculation is incorrect.");
        }
    }
