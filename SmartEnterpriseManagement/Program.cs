using SmartEnterprise.Models;
using SmartEnterprise.Services;
using SmartEnterprise.Services.Service;
using SmartEnterpriseManagement.Model;
using SmartEnterpriseManagement.Services.Service;
using System;

namespace SmartEnterprise
{
    class Program
    {
        static EmployeeService employeeService = new EmployeeService();
        static ProjectService projectService = new ProjectService();
        //static TaskService taskService = new TaskService();
        //static ProductService productService = new ProductService();
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

        // ================= EMPLOYEE =================
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

                    projectService.CreateProject(new Project
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

            var choice = Console.ReadLine();

            //switch (choice)
            //{
            //    case "1":
            //        Console.Write("Product Name: ");
            //        var name = Console.ReadLine();

            //        productService.Add(new Product
            //        {
            //            Id = new Random().Next(1, 1000),
            //            Name = name,
            //            Quantity = 1
            //        });

            //        Console.WriteLine("Product Added!");
            //        break;

            //    case "2":
            //        foreach (var p in productService.GetAll())
            //            Console.WriteLine($"{p.Id} - {p.Name} - Qty: {p.Quantity}");
            //        break;
            //}
        }

        // ================= CLIENT =================
        static void RunClientModule()
        {
            Console.WriteLine("\n--- Client Module ---");
            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. View Clients");

            var choice = Console.ReadLine();

            //switch (choice)
            //{
            //    case "1":
            //        Console.Write("Client Name: ");
            //        var name = Console.ReadLine();

            //        clientService.Add(new Client
            //        {
            //            Id = new Random().Next(1, 1000),
            //            Name = name
            //        });

            //        Console.WriteLine("Client Added!");
            //        break;

            //    case "2":
            //        foreach (var c in clientService.GetAll())
            //            Console.WriteLine($"{c.Id} - {c.Name}");
            //        break;
            //}
        }
    }
}