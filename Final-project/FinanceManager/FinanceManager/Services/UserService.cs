using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FinanceManager.Models;
using System.IO;

namespace FinanceManager.Services
{
    public class UserService
    {
        //private readonly string filePath = "Data/users.json";
        private readonly string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Data", "users.json");


        public List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(filePath, json);
        }

        public void AddUser(string name, string email)
        {
            var users = LoadUsers();
            int newId = users.Count > 0 ? users[^1].Id + 1 : 1;

            User newUser = new User
            {
                Id = newId,
                Name = name,
                Email = email
            };

            users.Add(newUser);
            SaveUsers(users);
            Console.WriteLine("User added successfully!");
        }

        public void ShowUsers()
        {
            var users = LoadUsers();

            if (users.Count == 0)
            {
                Console.WriteLine("No users registered.");
                return;
            }

            Console.WriteLine("List of users:");
            foreach (var user in users)
            {
                Console.WriteLine($" {user.Id}: {user.Name} ({user.Email})");
            }
        }
    }
}
