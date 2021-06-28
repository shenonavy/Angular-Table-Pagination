using System.Collections.Generic;
using API.Models;

namespace API.SeedData
{
    public static class Seeds
    {
        public static List<Employee> LoadData()
        {
            var empList = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alan", Gender = "Male", ContactNumber = "45545487454" },
                new Employee { Id = 2, Name = "Kane", Gender = "Male", ContactNumber = "468498454" },
                new Employee { Id = 3, Name = "Hulie", Gender = "Female", ContactNumber = "898415615" },
                new Employee { Id = 4, Name = "Joe", Gender = "Male", ContactNumber = "847544515" },
                new Employee { Id = 5, Name = "Martin", Gender = "Male", ContactNumber = "131586465" },
                new Employee { Id = 6, Name = "Jhone", Gender = "Male", ContactNumber = "6548897844" },
                new Employee { Id = 7, Name = "Marrie", Gender = "Female", ContactNumber = "9899554465" },
                new Employee { Id = 8, Name = "Anne", Gender = "Female", ContactNumber = "9526546457" },
                new Employee { Id = 9, Name = "Kelly", Gender = "Female", ContactNumber = "325646844" },
                new Employee { Id = 10, Name = "Watson", Gender = "Male", ContactNumber = "2546884684" },
                new Employee { Id = 11, Name = "Ruby", Gender = "Female", ContactNumber = "6584984542" },
                new Employee { Id = 12, Name = "Alex", Gender = "Male", ContactNumber = "5654889414" },
                new Employee { Id = 13, Name = "Sana", Gender = "Female", ContactNumber = "9898878454" },
                new Employee { Id = 14, Name = "Wile", Gender = "Male", ContactNumber = "5554848798" },
                new Employee { Id = 15, Name = "Roy", Gender = "Male", ContactNumber = "66556554888" },
                new Employee { Id = 16, Name = "Nove", Gender = "Male", ContactNumber = "6665655644" },
                new Employee { Id = 17, Name = "Ausie", Gender = "Female", ContactNumber = "66222224555" }
            };
            return empList;
        }
    }
}