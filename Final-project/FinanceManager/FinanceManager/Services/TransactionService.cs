using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using FinanceManager.Models;


namespace FinanceManager.Services
{
    public class TransactionService
    {
        //private readonly string filePath = "Data/transactions.json";
        private readonly string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Data", "transactions.json");


        public List<Transaction> LoadTransactions()
        {
            if (!File.Exists(filePath))
                return new List<Transaction>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Transaction>>(json) ?? new List<Transaction>();
        }

        public void SaveTransactions(List<Transaction> transactions)
        {
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void AddTransaction(int userId, string type, decimal amount, string category, string description, DateTime date)
        {
            var transactions = LoadTransactions();
            int newId = transactions.Count > 0 ? transactions[^1].Id + 1 : 1;

            Transaction newTransaction = new Transaction    
            {
                Id = newId,
                UserId = userId,
                Type = type,
                Amount = amount,
                Category = category,
                Description = description,
                Date = date
            };

            transactions.Add(newTransaction);
            SaveTransactions(transactions);
            Console.WriteLine("Transaction added successfully.");
        }

        public void ShowTransactions()
        {
            var transactions = LoadTransactions();

            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions found.");
                return;
            }

            Console.WriteLine("All Transactions:");
            foreach (var t in transactions)
            {
                Console.WriteLine($"{t.Id}: [{t.Type}] {t.Amount:C} | {t.Category} | {t.Description} | {t.Date.ToShortDateString()} | User ID: {t.UserId}");
            }
        }
        public void DeleteTransaction(int id)
        {
            var transactions = LoadTransactions();
            var transaction = transactions.FirstOrDefault(t => t.Id == id);

            if (transaction == null)
            {
                Console.WriteLine("Transaction not found.");
                return;
            }

            transactions.Remove(transaction);
            SaveTransactions(transactions);
            Console.WriteLine("Transaction deleted successfully.");
        }
        public void EditTransaction(int id)
        {
            var transactions = LoadTransactions();
            var transaction = transactions.FirstOrDefault(t => t.Id == id);

            if (transaction == null)
            {
                Console.WriteLine("Transaction not found.");
                return;
            }

            Console.Write("New Type (Income/Expense): ");
            string type = Console.ReadLine();

            Console.Write("New Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("New Category: ");
            string category = Console.ReadLine();

            Console.Write("New Description: ");
            string description = Console.ReadLine();

            Console.Write("New Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            transaction.Type = type;
            transaction.Amount = amount;
            transaction.Category = category;
            transaction.Description = description;
            transaction.Date = date;

            SaveTransactions(transactions);
            Console.WriteLine("Transaction updated successfully.");
        }

    }
}
