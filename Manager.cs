using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotter
{
    public class Manager : Employee
    {
        public string DepartmentName { get; set; }

        public static void MakeEntryManager(List<Manager> listManager)
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
            var departmentName = "ERROR";
            CheckDepartmentName(departmentName);
            try
            {
                AddManager(listManager, surname, forename, birthYear, phoneNumber, departmentName);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: {0} Exception caught.", e);
            }
            Console.WriteLine("Entry successfully  created!");
        }

        public static string CheckDepartmentName(string departmentName)
        {
            Console.Write("Manager (full name): ");
            departmentName = Console.ReadLine();
            if (!((departmentName.Length > 0) && (departmentName.Length < 45)))
            {
                Console.WriteLine("ERROR: Name of department can't be longer than 45 symbols");
                CheckDepartmentName(departmentName);
            }

            return departmentName;
        }

        public static void AddManager(List<Manager> listManager, string surname, string forename, int birthYear, string phoneNumber, string departmentName)
        {
            var newbieManager = new Manager
            {
                Surname = surname,
                Forename = forename,
                BirthYear = birthYear,
                PhoneNumber = phoneNumber,
                DepartmentName = departmentName
            };

            listManager.Add(newbieManager);
        }
    }
}
