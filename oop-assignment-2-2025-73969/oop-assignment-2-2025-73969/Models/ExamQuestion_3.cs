using System;
using System.Collections.Generic;
using System.Text;
namespace oop_assignment_2_2025_000000.Models
{
    public class Product
    {
        public string Name { get; set; }
        public List<int> Ratings { get; set; }

        public Product(string name, List<int> ratings)
        {
            Name = name;
            Ratings = ratings;
        }
    }
}