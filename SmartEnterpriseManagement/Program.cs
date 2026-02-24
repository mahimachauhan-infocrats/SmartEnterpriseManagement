using SmartEnterprise.Models;
using SmartEnterprise.Models;
using SmartEnterprise.Services;
using SmartEnterprise.Services.IService;
using SmartEnterprise.Services.Service;
using SmartEnterprise.Services.Service;
using SmartEnterpriseManagement.Models;
using SmartEnterpriseManagement.Services.IService;
using SmartEnterpriseManagement.Services.Service;
using SmartEnterpriseManagement.Utilities;
using System;

namespace SmartEnterprise
{
    class Program
    {
        static EmployeeService employeeService = new EmployeeService();
        static ProjectService projectService = new ProjectService();
        //static TaskService taskService = new TaskService();
        static IProductService productService = new ProductService();
        //static ClientService clientService = new ClientService();

        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        static void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n==== SMART ENTERPRISE SYSTEM ====");
                Console.WriteLine("1. Employee Module");
                Console.WriteLine("2. Project Module");
                Console.WriteLine("3. Task Module");
                Console.WriteLine("4. Inventory Module");
                Console.WriteLine("5. Client Module");
                Console.WriteLine("0. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": RunEmployeeModule(); break;
                    case "2": RunProjectModule(); break;
                    case "3": RunTaskModule(); break;
                    case "4": RunProductModule(); break;
                    case "5": RunClientModule(); break;
                    case "0": return;
                }
            }
        }

        // ================= EMPLOYEE ================
        static void RunEmployeeModule()
        {
            Console.WriteLine("\n--- Employee Module ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Search By Department");
            Console.WriteLine("4. Promote Employee");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Role: ");
                    var role = Console.ReadLine();
                    Console.Write("Department: ");
                    var department = Console.ReadLine();

                    employeeService.Add(new EmployeeModel
                    {
                        Id = new Random().Next(1, 1000),
                        Name = name,
                        Role = role,
                        Department = department
                    });

                    Console.WriteLine("Employee Added!");
                    break;

                case "2":
                    foreach (var e in employeeService.GetAll())
                        Console.WriteLine($"{e.Id} - {e.Name} - {e.Role}");
                    break;
                case "3":
                    Console.Write("Department: ");
                    var dept = Console.ReadLine();
                    var employees = employeeService.GetByDepartment(dept);
                    foreach (var emp in employees)
                    {
                        Console.WriteLine(emp);
                    }
                    break;
                case "4":
                    Console.Write("Enter Employee Id to Promote: ");
                    int id = int.Parse(Console.ReadLine());

                    employeeService.PromoteEmployee(id);
                    break;
            }
        }

        // ================= PROJECT =================
        static void RunProjectModule()  
        {
            Console.WriteLine("\n--- Project Module ---");
            Console.WriteLine("1. Add Project");
            Console.WriteLine("2. View Projects");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Title: ");
                    var title = Console.ReadLine();

                    projectService.CreateProject(new SmartEnterpriseManagement.Model.Project
                    {
                        Id = new Random().Next(1, 1000),
                        Title = title
                    });

                    Console.WriteLine("Project Added!");
                    break;

                case "2":
                    foreach (var p in projectService.GetProjects())
                        Console.WriteLine($"{p.Id} - {p.Title}");
                    break;
            }
        }

        // ================= TASK =================
        static void RunTaskModule()
        {
            Console.WriteLine("\n--- Task Module ---");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");

            var choice = Console.ReadLine();

            //switch (choice)
            //{
            //    case "1":
            //        Console.Write("Description: ");
            //        var desc = Console.ReadLine();

            //        taskService.Add(new WorkTask
            //        {
            //            Id = new Random().Next(1, 1000),
            //            Description = desc,
            //            Status = "Pending"
            //        });

            //        Console.WriteLine("Task Added!");
            //        break;

            //    case "2":
            //        foreach (var t in taskService.GetAll())
            //            Console.WriteLine($"{t.Id} - {t.Description} - {t.Status}");
            //        break;
            //}
        }

        // ================= INVENTORY =================
        static void RunProductModule()
        {
            Console.WriteLine("\n--- Inventory Module ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Delete Product");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Product Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Select Category:");
                    Console.WriteLine("0 - Electronics");
                    Console.WriteLine("1 - Furniture");
                    Console.WriteLine("2 - Grocery");
                    Console.WriteLine("3 - Clothing");
                    Console.WriteLine("4 - Other");

                    var category = (ProductCategory)int.Parse(Console.ReadLine());

                    productService.AddProduct(new ProductModel
                    {
                        ProductId = new Random().Next(1, 1000),
                        ProductName = name,
                        Quantity = quantity,
                        Category = category
                    });

                    break;

                case "2":
                    var products = productService.GetAllProducts();

                    foreach (var product in products)
                    {
                        Console.WriteLine(product);
                    }
                    break;

                case "3":
                    Console.Write("Enter Product Id to Delete: ");
                    int id = int.Parse(Console.ReadLine());
                    productService.DeleteProduct(id);
                    break;
            }
        }
        // ================= CLIENT =================
        static void RunClientModule()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n--- Client Module ---");
                Console.WriteLine("1. Add Client");
                Console.WriteLine("2. View Clients");
                Console.WriteLine("3. Add Project To Client");
                Console.WriteLine("4. Add Revenue To Client");
                Console.WriteLine("5. Search Client By Name");
                Console.WriteLine("6. Remove Client");
                Console.WriteLine("0. Back");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Client Name: ");
                        var name = Console.ReadLine();

                        Console.Write("Email: ");
                        var email = Console.ReadLine();

                        Console.Write("Phone: ");
                        var phone = Console.ReadLine();

                        Console.Write("Company Name: ");
                        var company = Console.ReadLine();

                        Console.Write("Assign Account Manager Id (optional): ");
                        var managerInput = Console.ReadLine();
                        int? managerId = string.IsNullOrWhiteSpace(managerInput)
                                            ? null
                                            : int.Parse(managerInput);

                        clientService.Add(new Client
                        {
                            Name = name,
                            Email = email,
                            Phone = phone,
                            CompanyName = company,
                            AccountManagerId = managerId,
                            TotalRevenue = 0
                        });

                        Console.WriteLine("Client Added Successfully!");
                        break;

                    case "2":
                        var clients = clientService.GetAll();

                        if (clients.Count == 0)
                        {
                            Console.WriteLine("No clients found.");
                        }
                        else
                        {
                            foreach (var c in clients)
                            {
                                Console.WriteLine("=================================");
                                Console.WriteLine($"ID: {c.Id}");
                                Console.WriteLine($"Name: {c.Name}");
                                Console.WriteLine($"Email: {c.Email}");
                                Console.WriteLine($"Phone: {c.Phone}");
                                Console.WriteLine($"Company: {c.CompanyName}");
                                Console.WriteLine($"Revenue: {c.TotalRevenue}");
                                Console.WriteLine($"Created: {c.CreatedDate}");
                                Console.WriteLine($"Projects Count: {c.Projects.Count}");
                                Console.WriteLine("=================================");
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Enter Client Id: ");
                        int clientId = int.Parse(Console.ReadLine());

                        var client = clientService.GetById(clientId);

                        if (client == null)
                        {
                            Console.WriteLine("Client not found!");
                            break;
                        }

                        Console.Write("Enter Project Name: ");
                        var projectName = Console.ReadLine();

                        client.Projects.Add(projectName);
                        clientService.Update(client);

                        Console.WriteLine("Project Added To Client!");
                        break;

                    case "4":
                        Console.Write("Enter Client Id: ");
                        int revenueClientId = int.Parse(Console.ReadLine());

                        var revenueClient = clientService.GetById(revenueClientId);

                        if (revenueClient == null)
                        {
                            Console.WriteLine("Client not found!");
                            break;
                        }

                        Console.Write("Enter Revenue Amount: ");
                        decimal amount = decimal.Parse(Console.ReadLine());

                        revenueClient.TotalRevenue += amount;
                        clientService.Update(revenueClient);

                        Console.WriteLine("Revenue Updated!");
                        break;

                    case "5":
                        Console.Write("Enter Name to Search: ");
                        var search = Console.ReadLine();

                        var result = clientService.GetAll()
                                    .Where(c => c.Name.Contains(search,
                                           StringComparison.OrdinalIgnoreCase))
                                    .ToList();

                        foreach (var c in result)
                        {
                            Console.WriteLine($"{c.Id} - {c.Name}");
                        }
                        break;

                    case "6":
                        Console.Write("Enter Client Id to Remove: ");
                        int removeId = int.Parse(Console.ReadLine());

                        clientService.Remove(removeId);
                        Console.WriteLine("Client Removed!");
                        break;


                    case "0":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}