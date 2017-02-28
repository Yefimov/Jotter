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

        public static void MakeEntryManager(List<Employee> listManager)
        {
            Console.WriteLine();
            var surname = "ERROR";
            var forename = "ERROR";
            var birthYear = 0;
            var phoneNumber = "555-2368";
            var departmentName = "ERROR";
            try
            {
                AddManager(listManager, CheckSurname(surname), CheckForename(forename), CheckBirthYear(birthYear), CheckPhone(phoneNumber), CheckDepartmentName(departmentName));
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: {0} Exception caught.", e);
            }
            Console.WriteLine("Entry successfully  created!");
        }

        public static string CheckDepartmentName(string departmentName)
        {
            Console.Write("Department name: ");
            departmentName = Console.ReadLine();
            if (!((departmentName.Length > 0) && (departmentName.Length < 45)))
            {
                Console.WriteLine("ERROR: Name of department can't be longer than 45 symbols");
                return CheckDepartmentName(departmentName);
            }

            return departmentName;
        }

        public static void AddManager(List<Employee> listManager, string surname, string forename, int birthYear, string phoneNumber, string departmentName)
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

        public override void ShowEntry()
        {
            Console.Write("{0} {1}, {2}, {3}. Department: {4}\n", Surname, Forename, BirthYear, PhoneNumber, DepartmentName);
        }
    }
}
