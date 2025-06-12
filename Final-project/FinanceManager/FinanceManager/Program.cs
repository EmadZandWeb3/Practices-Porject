using FinanceManager.Models;
using FinanceManager.Services;
using Spectre.Console;

Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

UserService userService = new UserService();
TransactionService transactionService = new TransactionService();
CategoryService categoryService = new CategoryService();
ReportService reportService = new ReportService(transactionService);

User activeUser = null;

while (true)
{
    AnsiConsole.Clear();
    AnsiConsole.MarkupLine("[bold yellow]Personal Finance Manager[/]");
    if (activeUser != null)
        AnsiConsole.MarkupLine($"[green]Active User:[/] {activeUser.Name} ({activeUser.Email})");
    else
        AnsiConsole.MarkupLine("[red]No active user selected.[/]");

    var option = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select an [green]option[/]:")
            .PageSize(10)
            .AddChoices(new[]
            {
                "1. Users",
                "2. Transaction",
                "3. Categories",
                "4. Reports",
                "0. Exit"
            }));

    switch (option.Split('.')[0])
    {
        case "1":
            bool inUserMenu = true;

            while (inUserMenu)
            {
                Console.Clear();
                AnsiConsole.MarkupLine("[bold cyan]User Menu[/]");               

                var userOption = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose an option:")
                        .AddChoices(new[]
                        {
                            "1. Add New User",
                            "2. View All Users",
                            "3. Change Active User",
                            "0. Back to Main Menu"
                        }));

                switch (userOption.Split('.')[0])
                {
                    case "1":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        userService.AddUser(name, email);
                        break;

                    case "2":
                        userService.ShowUsers();
                        break;

                    case "3":
                        var users = userService.LoadUsers();
                        if (users.Count == 0)
                        {
                            Console.WriteLine("No users available.");
                            break;
                        }

                        var selectedName = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title("Select a user:")
                                .AddChoices(users.Select(u => $"{u.Id}: {u.Name} ({u.Email})")));

                        int selectedId = int.Parse(selectedName.Split(':')[0]);
                        activeUser = users.FirstOrDefault(u => u.Id == selectedId);

                        Console.WriteLine($"Active user set to: {activeUser.Name}");
                        break;


                    case "0":
                        inUserMenu = false;
                        break;
                }

                if (inUserMenu)
                {
                    AnsiConsole.MarkupLine("\n[grey]Press any key to return...[/]");
                    Console.ReadKey();
                }
            }
            break;

        case "2":
            bool inTransactionMenu = true;

            while (inTransactionMenu)
            {
                Console.Clear();
                AnsiConsole.MarkupLine("[bold cyan] Transaction Menu[/]");

                var transOption = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose an option:")
                        .AddChoices(new[]
                        {
                            "1. Add Transaction",
                            "2. View Transactions",
                            "3. Edit Transaction",
                            "4. Delete Transaction",
                            "0. Back to Main Menu"
                        }));

                switch (transOption.Split('.')[0])
                {
                    case "1":
                        if (activeUser == null)
                        {
                            Console.WriteLine(" No active user selected. Please select a user first.");
                            break;
                        }
                        int userId = activeUser.Id;


                        string type = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title("Transaction Type:")
                                .AddChoices("Income", "Expense")
                        );

                        var categories = categoryService.LoadCategories();
                        string category = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title("Select Category:")
                                .AddChoices(categories.Select(c => c.Name))
                        );

                        Console.Write("Amount: ");
                        decimal amount = decimal.Parse(Console.ReadLine());

                        Console.Write("Description: ");
                        string desc = Console.ReadLine();

                        Console.Write("Date (yyyy,mm,dd): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        transactionService.AddTransaction(userId, type, amount, category, desc, date);
                        break;

                    case "2":
                        transactionService.ShowTransactions();
                        break;

                    case "3":
                        transactionService.ShowTransactions();
                        Console.Write("Enter Transaction ID to edit: ");
                        int editId = int.Parse(Console.ReadLine());
                        transactionService.EditTransaction(editId);
                        break;

                    case "4":
                        transactionService.ShowTransactions();
                        Console.Write("Enter Transaction ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        transactionService.DeleteTransaction(deleteId);
                        break;

                    case "0":
                        inTransactionMenu = false;
                        break;
                }

                if (inTransactionMenu)
                {
                    AnsiConsole.MarkupLine("\n[grey]Press any key to return...[/]");
                    Console.ReadKey();
                }
            }
            break;

        case "3":
            bool inCategoryMenu = true;

            while (inCategoryMenu)
            {
                Console.Clear();
                AnsiConsole.MarkupLine("[bold cyan]Category Menu[/]");

                var catOption = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose an option:")
                        .AddChoices(new[]
                        {
                          "1. View Categories",
                          "2. Add New Category",
                          "0. Back to Main Menu"
                        }));

                switch (catOption.Split('.')[0])
                {
                    case "1":
                        categoryService.ShowCategories();
                        break;

                    case "2":
                        Console.Write("Category name: ");
                        string categoryInput = Console.ReadLine()?.Trim();
                        if (string.IsNullOrWhiteSpace(categoryInput))
                        {
                            Console.WriteLine("Category name cannot be empty.");
                            break;
                        }
                        categoryService.AddCategory(categoryInput);
                        break;

                    case "0":
                        inCategoryMenu = false;
                        break;
                }

                if (inCategoryMenu)
                {
                    AnsiConsole.MarkupLine("\n[grey]Press any key to return...[/]");
                    Console.ReadKey();
                }
            }
            break;
        case "4":
            bool inReportMenu = true;

            while (inReportMenu)
            {
                Console.Clear();
                AnsiConsole.MarkupLine("[bold cyan]Report Menu[/]");

                var reportOption = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose a report:")
                        .AddChoices(new[]
                        {
                             "1. Monthly Summary",
                             "2. Expenses by Category",
                             "3. Daily Balance",
                             "0. Back to Main Menu"
                        }));

                switch (reportOption.Split('.')[0])
                {
                    case "1":
                        reportService.MonthlySummary();
                        break;

                    case "2":
                        reportService.ExpenseByCategory();
                        break;

                    case "3":
                        reportService.DailyBalance();
                        break;

                    case "0":
                        inReportMenu = false;
                        break;
                }

                if (inReportMenu)
                {
                    AnsiConsole.MarkupLine("\n[grey]Press any key to return...[/]");
                    Console.ReadKey();
                }
            }
            break;

        case "0":
            return;
    }

    AnsiConsole.MarkupLine("\n[grey]Press any key to return to main menu...[/]");
    Console.ReadKey();
}
