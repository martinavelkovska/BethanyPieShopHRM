using BethanyPieShopHRM.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BethanyPieShopHRM
{
    internal class Utilities
    {
        private static string directory = @"C:\Users\Martina\Documents\New folder\";
        private static string fileName = "employees.txt";

        internal static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("Creating an employee");

            Console.WriteLine("What type of employee do you want to register?");
            Console.WriteLine("1. Employee\n2. Manager\n3. Store manager\n4. Researcher\n5. Junior researcher");
            Console.WriteLine("Your selection: ");
            string employeeType = Console.ReadLine();

            if(employeeType !="1" && employeeType !="2" && employeeType !="3" && employeeType !="4" && employeeType !="5")
            {
                Console.WriteLine("Invalid selection!");
                return;
            }

            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the email: ");
            string email = Console.ReadLine();

            Console.Write("Enter the birth day: ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = null;

            switch (employeeType)
            {
                case "1":
                    employee = new Employee(firstName, lastName, email, birthDay, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, birthDay, rate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, birthDay, rate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, birthDay, rate);
                    break;
                case "5":
                    employee = new JuniorResreacher(firstName, lastName, email, birthDay, rate);
                    break;

            }
            employees.Add(employee);

            Console.WriteLine("Employee created!\n\n");

        }

        internal static void CheckForExisitingEmployeeFile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TODO: write code to check if file exists");
            Console.ResetColor();

            string path = $"{directory}{fileName}";
            bool existingFileFound = File.Exists(path);
            if (existingFileFound)
            {
                Console.WriteLine("An existing file with Employee file is found");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Directory is ready for saving files");
                    Console.ResetColor();
                }
            }
        }

        internal static void ViewAllEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].DisplayEmployeeDetails();
           

            }
        }

        internal static void LoadEmployees(List<Employee> employees) {
            string path = $"{directory}{fileName}";
            if (File.Exists(path))
            {
                employees.Clear();

                //now read the file:
                string[] employeesAsString = File.ReadAllLines(path);
                for(int i=0; i < employeesAsString.Length; i++)
                {
                    string[] employeeSplits = employeesAsString[i].Split(';');
                    string firstName = employeeSplits[0].Substring(employeeSplits[0].IndexOf(':') + 1);
                    string lastName = employeeSplits[1].Substring(employeeSplits[1].IndexOf(':') + 1);
                    string email = employeeSplits[2].Substring(employeeSplits[2].IndexOf(':') + 1);
                    DateTime birthDay = DateTime.Parse(employeeSplits[3].Substring(employeeSplits[3].IndexOf(':') + 1));
                    double hourlyRate = double.Parse(employeeSplits[4].Substring(employeeSplits[4].IndexOf(':') + 1));
                    string employeeType = employeeSplits[5].Substring(employeeSplits[5].IndexOf(':') + 1);

                    Employee employee = null;

                    switch (employeeType)
                    {
                        case "1":
                            employee = new Employee(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "2":
                            employee = new Manager(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "3":
                            employee = new StoreManager(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "4":
                            employee = new Researcher(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "5":
                            employee = new JuniorResreacher(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                    }
                    employees.Add(employee);

                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Loaded {employees.Count} employees! \n\n");
                Console.ResetColor();
            }
        }    

        internal static void SaveEmployees(List<Employee> employees) {
            string path = $"{directory}{fileName}";
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Employee employee in employees)
            {
                string type = GetEmployeeType(employee);
                stringBuilder.Append($"firstName: {employee.FirstName}");
                stringBuilder.Append($"lastName: {employee.LastName}");
                stringBuilder.Append($"email: {employee.Email}");
                stringBuilder.Append($"birthDay: {employee.BirthDay.ToShortDateString()}");
                stringBuilder.Append($"hourlRate: {employee.HourlyRate}");
                stringBuilder.Append($"employeeType:{type}");
                stringBuilder.Append(Environment.NewLine);
            }
            File.WriteAllText(path, stringBuilder.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved employees successfully");
            Console.ResetColor();
        }

        private static string GetEmployeeType(Employee emp)
        {
            if (emp is Manager)
                return "2";
            else if (emp is StoreManager)
                return "3";
            else if (emp is JuniorResreacher)
                return "5";
            else if(emp is Researcher)
                return "4";
            else if (emp is Employee)
                return "1";
            return "0";
        }

    }
}
