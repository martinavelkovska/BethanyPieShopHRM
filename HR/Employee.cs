using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;
using System.Text;

namespace BethanyPieShopHRM.HR
{
    public class Employee: IEmployee
    {
        private string firstName;
        private string lastName;
        private string email;
        private int age;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate; // to allows us null

        private DateTime birthDay;

        private const int minimalHoursWorkedUnit = 1;

        //private EmployeeType employeeType;

        private Address address;

        private static double taxRate = 0.15;



        public string FirstName
        {
            get {
                return firstName;
            }
            set {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
           protected set //private setter is hidden for outside consumers, protected allow aceess for inherit class
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            private set
            {
                wage = value;
            }
        }

        public double? HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        public int MinimalHoursWorkedUnit
        {
            get
            {
                return minimalHoursWorkedUnit;
            }
        }
        //public EmployeeType EmployeeType
        //{
        //    get
        //    {
        //        return employeeType;
        //    }
        //    set
        //    {
        //        employeeType = value;
        //    }
        //}

        public double TaxRate
        {
            get
            {
                return taxRate;
            }
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName, lastName, email, birthDay, 0) //overloading constructor with only 4 parametes.instead of
                                                                                                                                     //giving body that sets the data field, i am using keyword his so from this constructor call the bellow constructor
        {

        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
            //EmployeeType = employeeType;
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
            Address = new Address(street, houseNumber, zip, city);
            //EmployeeType = employeeType;
        }


        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
     
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
            {
                bonus *= 2;
            }
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        //public int CaluclateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{
        //    if (numberOfHoursWorked > 10)
        //    {
        //        bonus *= 2;
        //    }

        //    if (bonus >= 200)
        //    {
        //        bonusTax = bonus / 10;
        //        bonus -= bonusTax;

        //    }
        //    Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
        //    return bonus;
        //}
        public static void UsingACustomType()
        {
            List<string> list = new List<string>();


        }

        public double CalculateWage()
        {
           WageCalculations wageCalculations = new WageCalculations();
            double caluclatedValue = wageCalculations.ComplexWageCalculation(wage, taxRate, 3, 42);
            return caluclatedValue;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public int CaluclateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;

            }
            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }
        public double ReceiveWage(bool resetHours = true)
        {
            // //   wage = numberOfHoursWorked * hourlyRate;
            // double wageBeforeTax = 0.0;

            // if (EmployeeType == EmployeeType.Manager)
            // {
            //     Console.WriteLine($"An extra was added to the wage since {FirstName} is a manager!");
            ////     wage = numberOfHoursWorked * hourlyRate * 1.25;
            //     wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value * 1.25;
            // }
            // else
            // {
            //     //  wage = numberOfHoursWorked * hourlyRate;
            //     wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            // }
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;

            double taxAmount = wageBeforeTax * TaxRate;
            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {wage} for {NumberOfHoursWorked} hours of work.");
            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }
            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail:\t\t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}\nTax rate: \t{TaxRate}");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You've done a great job, {FirstName}");
        }
    }
}
