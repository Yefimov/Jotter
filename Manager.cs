using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Jotter
{
    [Serializable]
    public class Manager : Employee
    {
        public string DepartmentName { get; set; }

        /// <summary>
        /// Make Manager entry with DepartmentName, not normal Employee entry with ManagerName
        /// </summary>
        /// <param name="listEmployee">Collection of entries</param>
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

        /// <summary>
        /// User have to enter the correct name of department.
        /// </summary>
        /// <param name="departmentName">Name of manager's department</param>
        /// <returns>Checked name of department</returns>
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
        
        /// <summary><seealso cref="Manager.MakeEntryManager(List{Employee})"/> uses it.</summary>
        /// <param name="listEmployee">Collection of entries</param>
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

        // Polymorphism example.
        /// <summary>
        /// Display Manager object on screen. Necessary for <seealso cref="Program.ShowList(List{Employee})"/>
        /// </summary>
        public override void ShowEntry()
        {
            Console.Write("{0} {1}, {2}, {3}. Department: {4}\n", Surname, Forename, BirthYear, PhoneNumber, DepartmentName);
        }
    }
}
