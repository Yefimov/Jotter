using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotter
{
    public class Employee
    {
        //A read-write instance property:
        public string Surname { get; set; } = "ERROR";
        public string Forename { get; set; } = "ERROR";
        public int BirthYear { get; set; } = 0;
        public string PhoneNumber { get; set; } = "ERROR";
        public string Manager { get; set; } = "ERROR";

        public static void MakeEntryEmployee(List<Employee> listEmployee)
        {
            Console.WriteLine();
            var surname = "ERROR";
            var forename = "ERROR";
            var birthYear = 0;
            var phoneNumber = "555-2368";
            var manager = "ERROR";
            try
            {
                AddEmployee(listEmployee, CheckSurname(surname), CheckForename(forename), CheckBirthYear(birthYear), CheckPhone(phoneNumber), CheckManager(manager));
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: {0} Exception caught.", e);
            }
            Console.WriteLine("Entry successfully  created!");
        }

        public static void AddEmployee(List<Employee> listEmployee, string surname, string forename, int birthYear, string phoneNumber, string manager)
        {
            var newbieEmployee = new Employee
            {
                Surname = surname,
                Forename = forename,
                BirthYear = birthYear,
                PhoneNumber = phoneNumber,
                Manager = manager
            };

            listEmployee.Add(newbieEmployee);
        }

        #region Checking the entered values
        public static string CheckSurname(string surname)
        {
            Console.Write("Surname: ");
            surname = Console.ReadLine();
            if (!((surname.Length > 0) && (surname.Length < 20)))
            {
                Console.WriteLine("ERROR: Surname can't be longer than 20 symbols");
                return CheckSurname(surname);
            }

            return surname;
        }

        public static string CheckForename(string forename)
        {
            Console.Write("Forename: ");
            forename = Console.ReadLine();
            if (!((forename.Length > 0) && (forename.Length < 20)))
            {
                Console.WriteLine("ERROR: Forename can't be longer than 20 symbols");
                return CheckForename(forename);
            }

            return forename;
        }

        public static int CheckBirthYear(int birthYear)
        {
            Console.Write("Birth year: ");
            var inputString = Console.ReadLine();
            var rgx = new Regex(@"[0-9]{4}$");
            if (rgx.IsMatch(inputString))
            {
                birthYear = Convert.ToInt32(inputString);
                var todayDate = DateTime.Today;
                if (!((todayDate.Year - birthYear <= 150) && (todayDate.Year - birthYear >= 18)))
                {
                    Console.WriteLine("ERROR: Employee can't be younger than 18 yo and older than 150. In your own interest, please take care to enter the correct data to avoid typing errors!");
                    return CheckBirthYear(birthYear);
                }
            }
            else
            {
                Console.WriteLine("ERROR: Please, enter birth year in format \"XXXX\" (without quotes)");
                return CheckBirthYear(birthYear);
            }

            return birthYear;
        }

        public static string CheckPhone(string phoneNumber)
        {
            Console.Write("Phone number: ");
            phoneNumber = Console.ReadLine();
            if (!IsPhone(phoneNumber))
            {
                Console.WriteLine("ERROR: Please, enter phone number in format \"+XXXXXXXXXXX\" (without quotes)");
                return CheckPhone(phoneNumber);
            }
            else
            {
                return phoneNumber;
            }
        }

        public static bool IsPhone(string rawNumber)
        {
            // https://en.wikipedia.org/wiki/E.164
            var rgx = new Regex(@"^\+[1-9]{1}[0-9]{3,14}$");
            return rgx.IsMatch(rawNumber) ? true : false;
        }

        public static string CheckManager(string manager)
        {
            Console.Write("Manager (full name): ");
            manager = Console.ReadLine();
            if (!((manager.Length > 0) && (manager.Length < 45)))
            {
                Console.WriteLine("ERROR: Manager's name can't be longer than 45 symbols");
                return CheckManager(manager);
            }

            return manager;
        }
        #endregion

        public static void RemoveEntry(List<Employee> listEmployee)
        {
            Console.Write("Enter the number from employees list: ");
            var inputString = Console.ReadLine();
            var rgx = new Regex(@"[1-9]$");
            if (rgx.IsMatch(inputString))
            {
                var numberInTheList = Convert.ToInt32(inputString);
                DeleteEmployee(listEmployee, numberInTheList);
            }
            else
            {
                Console.WriteLine("ERROR: Please, enter the correct number.");
                RemoveEntry(listEmployee);
            }
        }

        public static void DeleteEmployee(List<Employee> listEmployee, int numberInTheList)
        {
            if (listEmployee[numberInTheList] != null)
            {
                Console.WriteLine("Are you sure you want to delete entry #{0}? [Y]/[N]", numberInTheList);
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                    case "Y":
                        listEmployee.Remove(listEmployee[numberInTheList]);
                        Console.WriteLine("Entry successfully deleted!");
                        break;
                    case "2":
                    case "N":
                        Console.WriteLine("Deleting canceled.");
                        break;
                    default:
                        Console.WriteLine("ERROR: Unknown command.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR: Employees list doesn't contain entry with this number.");
            }
        }
        
        public virtual void ShowEntry()
        {
            Console.Write("{0} {1}, {2}, {3}. Manager: {4}\n", Surname, Forename, BirthYear, PhoneNumber, Manager);
        }
    }
}
