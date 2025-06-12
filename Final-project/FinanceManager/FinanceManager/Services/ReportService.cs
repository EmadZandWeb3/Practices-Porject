using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.Models;
using Spectre.Console;

namespace FinanceManager.Services
{
    public class ReportService
    {
        private readonly TransactionService transactionService;

        public ReportService(TransactionService ts)
        {
            transactionService = ts;
        }

        public void MonthlySummary()
        {
            var transactions = transactionService.LoadTransactions();

            var grouped = transactions.GroupBy(t => new { t.Date.Year, t.Date.Month }).OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Month);

            foreach (var group in grouped)
            {
                var monthLabel = $"{group.Key.Year}/{group.Key.Month:D2}";
                var income = group.Where(t => t.Type.ToLower() == "income").Sum(t => t.Amount);
                var expense = group.Where(t => t.Type.ToLower() == "expense").Sum(t => t.Amount);

                var chart = new BarChart()
                    .Width(60)
                    .Label($"[bold yellow]Summary for {monthLabel}[/]")
                    .CenterLabel()
                    .AddItem("Income", (float)income, ConsoleColor.Green)
                    .AddItem("Expense", (float)expense, ConsoleColor.Red);

                AnsiConsole.Write(chart);
                AnsiConsole.MarkupLine($"[green]Total Income[/]: {income:C}");
                AnsiConsole.MarkupLine($"[red]Total Expense[/]: {expense:C}\n");
            }
        }

        public void ExpenseByCategory()
        {
            var transactions = transactionService.LoadTransactions();
            var expenses = transactions.Where(t => t.Type.ToLower() == "expense");

            if (!expenses.Any())
            {
                AnsiConsole.MarkupLine("[red]No expense transactions found.[/]");
                return;
            }

            var grouped = expenses.GroupBy(e => e.Category).Select(g => new { Category = g.Key, Total = g.Sum(t => t.Amount) }).OrderByDescending(g => g.Total);

            var chart = new BarChart()
                .Width(60)
                .Label("[bold yellow]Expenses by Category[/]")
                .CenterLabel();

            var colors = new[]
            {
                  ConsoleColor.Red,
                  ConsoleColor.Blue,
                  ConsoleColor.Yellow,
                  ConsoleColor.Green,
                  ConsoleColor.Cyan,
                  ConsoleColor.Magenta,
                  ConsoleColor.White
            };

            int colorIndex = 0;

            foreach (var item in grouped)
            {
                chart.AddItem(item.Category, (float)item.Total, colors[colorIndex % colors.Length]);
                colorIndex++;
            }

            AnsiConsole.Write(chart);

            AnsiConsole.WriteLine();
            foreach (var item in grouped)
            {
                AnsiConsole.MarkupLine($"[blue]{item.Category}[/]: {item.Total:C}");
            }
        }
        public void DailyBalance()
        {
            var transactions = transactionService.LoadTransactions();

            if (!transactions.Any())
            {
                AnsiConsole.MarkupLine("[red]No transactions found.[/]");
                return;
            }

            var grouped = transactions.GroupBy(t => t.Date.Date).OrderBy(g => g.Key);

            decimal balance = 0;

            var table = new Table();
            table.Border = TableBorder.Rounded;
            table.AddColumn("[bold]Date[/]");
            table.AddColumn("[green]Income[/]");
            table.AddColumn("[red]Expense[/]");
            table.AddColumn("[yellow]Balance[/]");

            foreach (var day in grouped)
            {
                var income = day.Where(t => t.Type.Equals("Income", StringComparison.OrdinalIgnoreCase)).Sum(t => t.Amount);

                var expense = day.Where(t => t.Type.Equals("Expense", StringComparison.OrdinalIgnoreCase)).Sum(t => t.Amount);

                balance += income - expense;

                table.AddRow(
                    day.Key.ToString("yyyy-MM-dd"),
                    income.ToString("C"),
                    expense.ToString("C"),
                    balance.ToString("C")
                );
            }

            AnsiConsole.Write(new Markup("[bold yellow] Daily Balance[/]\n"));
            AnsiConsole.Write(table);
        }
    }
}
