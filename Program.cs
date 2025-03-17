// See https://aka.ms/new-console-template for more information
using BethanyPieShopHRM;
using BethanyPieShopHRM.Accounting;
using BethanyPieShopHRM.HR;
using System.Net.Sockets;
using System.Security;
using System.Text;

////Console.WriteLine("Hello, World!");

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
////Employee george = new Employee("George", "Smith", "george@snowball.be", new DateTime(1979, 3, 14), 25, EmployeeType.Research);
//Console.WriteLine($"{bethany.ConvertToJson()}");
////bethany.DisplayEmployeeDetails();
////bethany.PerformWork(25);
////int minimumBonus = 100;
////int bonusTax;
////int receiveBonus = bethany.CaluclateBonusAndBonusTax(minimumBonus, out bonusTax);
////Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax}  and {bethany.firstName} has received a bonus of {receiveBonus}");


////string firstName = "Martina";
////string lastName = "Velkovska";
////string onaka = "dutty love";

////StringBuilder stringBuilder = new StringBuilder();
////stringBuilder.Append( "Last name:" );
////stringBuilder.Append(lastName);
////stringBuilder.AppendLine("First name:");
////stringBuilder.Append(firstName);
////stringBuilder.Append(onaka);

////Console.WriteLine(result);

////StringBuilder builder2 = new StringBuilder();

////for(int i=0; i<2500; i++)
////{
////    builder2.Append(i);
////    builder2.Append(" ");
////}
////string list = builder2.ToString();
////Console.WriteLine(list);


//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//Console.WriteLine($"{bethany.firstName}");
//double wage = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid  (message from Program) : {wage}");
//bethany.DisplayEmployeeDetails();
//bethany.CalculateWage();

//Employee george = new Employee("George", "Smith", "george@snowball.be", new DateTime(1974, 6, 12), null, EmployeeType.Research);
//george.PerformWork();
//george.PerformWork();
//george.PerformWork(2);
//george.PerformWork();
//george.PerformWork(3);
//george.DisplayEmployeeDetails();

////double wagegeorge = george.ReceiveWage(true);
////Console.WriteLine($"Wage paid  (message from Program) : {wagegeorge}");

//WorkTask task;
//task.description = "Bake delicious pies";
//task.hours = 3;
//task.PerformWorkTask();


//Customer customer = new Customer();

//Employee mysteryEmployee = null;

//Account account = new Account("123456789");
////account.AccountNumber = "656556" compile error due to immutability

////Arrays:
//int[] sampleArray = new int[5];

//int[] sampleArray1 = new int[] { 21, 1, 2 };
////sampleArray1[3] = 6; isto error

////int[] sampleArray2 = new int[5] { 21, 1, 2 }; // error

//Console.WriteLine("How many employees IDs do you want to register?");

//int lenght = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[lenght];

////int[] niza = new int[]; error

//var testId = employeeIds[0];

//Console.WriteLine($" the test id is : {testId}");
//for(int i=0; i<lenght; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds[i] = id;
//}

//for(int i=0; i< employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i+1}: \t{employeeIds[i]}");
//}
//Array.Sort(employeeIds);
//Console.WriteLine("After sorting:");
//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//int[] employeeIdsCopy = new int[lenght];
//employeeIds.CopyTo(employeeIdsCopy, 0);

//employeeIds.Reverse();
//Console.WriteLine("After reversing:");
//for (int i = 0; i < employeeIdsCopy.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIdsCopy[i]}");
//}

//// creating an array with custom type
//Employee sasha = new Employee("Sasha", "Lunas", "sashalunas@gmail.com", new DateTime(1982, 1, 16), 18, EmployeeType.Research);
//Employee[] employees = new Employee[3];
//employees[0] = bethany;
//employees[1] = george;
//employees[2] = sasha;


//foreach(Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(25);
//    employee.PerformWork(numberOfHoursWorked);
//    employee.ReceiveWage();
//}

////generic list
//List<int> employeesIdsGenericList = new List<int>();

//employeesIdsGenericList.Add(55);
//employeesIdsGenericList.Add(23);
//employeesIdsGenericList.Add(255);
//employeesIdsGenericList.Add(943);
//employeesIdsGenericList.Add(6);

//if (employeesIdsGenericList.Contains(943))
//{
//    Console.WriteLine("943 is found!");
//}

//var employeeIdsArray = employeesIdsGenericList.ToArray();

//employeesIdsGenericList.Clear();

//Console.WriteLine("How many employees Ids do you want to register?");

//int length = int.Parse(Console.ReadLine());

//for(int i=0; i<length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeesIdsGenericList.Add(id);
//}

/////////////////////////////11 OOP/////////////////////////////

/*Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
Employee george = new Employee("George", "Smith", "george@snowball.be", new DateTime(1979, 3, 14), 25);

bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork(3);
bethany.PerformWork();

bethany.FirstName = "John";
string fn = bethany.FirstName;

//Inheritance

Employee mary = new Manager("Mary", "Perry", "mary@snowball.be", new DateTime(1956, 6, 13), 30);
mary.DisplayEmployeeDetails();
mary.PerformWork(25);
mary.PerformWork();
mary.PerformWork();
//mary.AttendManagementMeeting();

Researcher bobJunior = new JuniorResreacher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17); //every juniorreseracher is researcher
bobJunior.ResearchNewPieTastes(5);
bobJunior.DisplayEmployeeDetails();
bobJunior.ResearchNewPieTastes(5);

Employee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New Street", "123", "123456", "Pie Ville");

string streetName = jake.Address.Street;

Console.WriteLine($"Addres of Jake is {streetName}");

//polymporhism

mary.GiveBonus();
Employee ksenija = new StoreManager("Ksenija", "Nikolova", "ksenija@snoball.be", new DateTime(1979, 1, 16), 25);
Manager lara = new Manager("Lara", "Nickas", "lara@snoball.be", new DateTime(1979, 1, 16), 35);
JuniorResreacher martin = new JuniorResreacher("Martin", "Karov", "martin@snoball.be", new DateTime(1984, 1, 16), 36);
StoreManager kevin = new StoreManager("Kevin", "Marks", "kevin@snoball.be", new DateTime(1953, 8, 25), 14);

List<Employee> employees = new List<Employee>();
employees.Add(ksenija);
employees.Add(lara);
employees.Add(kevin);
employees.Add(martin);

foreach(Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
}


IEmployee testEmployee = new StoreManager("Ana", "Nadzakova", "ana@snoball.be", new DateTime(1979, 1, 16), 35); //reference of type IEmployee hat points to StoreManager
IEmployee danna = new Manager("Dana", "Paola", "dana@snoball.be", new DateTime(1979, 1, 16), 35); //reference of type IEmployee hat points to StoreManager
IEmployee maluma = new Developer("Maluma", "Londono", "maluma@snoball.be", new DateTime(1979, 1, 16), 35); //reference of type IEmployee hat points to StoreManager


List<IEmployee> iemployees = new List<IEmployee>();
iemployees.Add(testEmployee);
iemployees.Add(danna);
iemployees.Add(maluma);
foreach (IEmployee emp in iemployees)
{
    emp.DisplayEmployeeDetails();
    emp.GiveBonus();
}
*/

//13:File:

List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***************************");
Console.WriteLine("* Bethany's Pie Shop Employee App *");
Console.WriteLine("****************************");
Console.ForegroundColor= ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExisitingEmployeeFile();
do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("*****************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("******************");

    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
        case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection.Please try again");
            break;
    }
}
while (userSelection != "9");

Console.WriteLine("Thanks for using this app.");