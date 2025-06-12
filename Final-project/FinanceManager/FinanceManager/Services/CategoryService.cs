using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FinanceManager.Models;

namespace FinanceManager.Services
{
    internal class CategoryService
    {
        //private readonly string filePath = "Data/categories.json";
        private readonly string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Data", "categories.json");

        public List<Category> LoadCategories()
        {
            if (!File.Exists(filePath))
                return CreateDefaultCategories();

            string json = File.ReadAllText(filePath);
            var categories = JsonSerializer.Deserialize<List<Category>>(json);

            return categories ?? CreateDefaultCategories();
        }

        private List<Category> CreateDefaultCategories()
        {
            var defaultCategories = new List<Category>
            {
                new Category { Id = 1, Name = "Food" },
                new Category { Id = 2, Name = "Transport" },
                new Category { Id = 3, Name = "Bills" },
                new Category { Id = 4, Name = "Shopping" },
                new Category { Id = 5, Name = "Entertainment" },
                new Category { Id = 6, Name = "Other" }
            };

            SaveCategories(defaultCategories);
            return defaultCategories;
        }

        public void SaveCategories(List<Category> categories)
        {
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string json = JsonSerializer.Serialize(categories, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void AddCategory(string name)
        {
            var categories = LoadCategories();

            bool exists = categories.Exists(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (exists)
            {
                Console.WriteLine("Category already exists.!!!");
                return;
            }

            int newId = categories.Count > 0 ? categories[^1].Id + 1 : 1;

            categories.Add(new Category
            {
                Id = newId,
                Name = name
            });

            SaveCategories(categories);
            Console.WriteLine("Category added successfully.");
        }

        public void ShowCategories()
        {
            var categories = LoadCategories();

            Console.WriteLine("Categories:");
            foreach (var cat in categories)
            {
                Console.WriteLine($" {cat.Id}: {cat.Name}");
            }
        }

       
    }
}
