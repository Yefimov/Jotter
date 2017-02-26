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
        private string surname;
        private string forename;
        private int birthYear;
        private string phoneNumber;
        private string manager;

        // A read-write instance property:
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public static void MakeEntryEmployee(List<Employee> listEmployee)
        {
            Console.WriteLine();
            var surname = Console.ReadLine();
            CheckSurname(surname);
            var forename = "ERROR";
            CheckForename(forename);
            var birthYear = 0;
            CheckBirthYear(birthYear);
            var phoneNumber = "555-2368";
            CheckPhone(phoneNumber);
            var manager = "ERROR";
            CheckManager(manager);
            try
            {
                AddEmployee(listEmployee, surname, forename, birthYear, phoneNumber, manager);
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
                CheckSurname(surname);
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
                CheckForename(forename);
            }

            return forename;
        }

        public static int CheckBirthYear(int birthYear)
        {
            Console.Write("Birth year: ");
            birthYear = Convert.ToInt32(Console.ReadLine());
            if (!((birthYear > 1870) && (birthYear < 1999)))
            {
                Console.WriteLine("ERROR: Birth year can't be earlier than 1870 and later than 1999");
                CheckBirthYear(birthYear);
            }

            return birthYear;
        }

        public static string CheckPhone(string phoneNumber)
        {
            Console.Write("Phone number: ");
            phoneNumber = Console.ReadLine();
            if (!IsPhone(phoneNumber))
            {
                Console.WriteLine("ERROR: Enter phone number in format \"+XXXXXXXXXXX\" (without quotes)");
                CheckPhone(phoneNumber);
            }

            return phoneNumber;
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
                CheckManager(manager);
            }

            return manager;
        }
        #endregion

        public void RemoveEntryEmployee(List<Employee> listEmployee)
        {
            Console.Write("\nWrite the number of entry you want to remove: ");
            var numberInTheList = Convert.ToInt32(Console.ReadLine());

            DeleteEmployee(listEmployee, numberInTheList);
        }

        public static void DeleteEmployee(List<Employee> listEmployee, int numberInTheList)
        {
            listEmployee.Remove(listEmployee[numberInTheList]);
        }
    }
}
