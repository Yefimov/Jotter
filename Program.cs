using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotter
{
    class Program
    {
        public static void ShowMenu(List<Employee> listEmployee)
        {
            Console.WriteLine("\nMENU:\nShow employees [L]ist\n[A]dd entry\n[D]elete entry\n[S]earch\nSo[R]t\n[Q]uit");
            CatchUserCommand(listEmployee);
        }

        public static void CatchUserCommand(List<Employee> listEmployee)
        {
            Console.Write("\n>");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "l":
                case "show employees list":
                    ShowList(listEmployee);
                    break;
                case "2":
                case "a":
                case "add entry":
                    MakeEntry(listEmployee);
                    break;
                case "3":
                case "d":
                case "delete entry":
                    Employee.RemoveEntry(listEmployee);
                    break;
                case "4":
                case "s":
                case "search":
                    SearchEntry(listEmployee);
                    break;
                case "5":
                case "r":
                case "sort":
                    SortEntry(listEmployee);
                    break;
                case "6":
                case "q":
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("ERROR: Unknown command.");
                    CatchUserCommand(listEmployee);
                    break;
            }
            ShowMenu(listEmployee);
        }

        static void MakeEntry(List<Employee> listEmployee)
        {
            Console.WriteLine("Add [E]mployee or [M]anager?");
            Console.Write("\n>");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "e":
                case "add employee":
                    Employee.MakeEntryEmployee(listEmployee);
                    break;
                case "2":
                case "m":
                case "add manager":
                    Manager.MakeEntryManager(listEmployee);
                    break;
                default:
                    Console.WriteLine("ERROR: Unknown command.");
                    break;
            }
            ShowMenu(listEmployee);
        }

        static void ShowList(List<Employee> listEmployee)
        {
            Console.WriteLine("There are {0} entries at this moment.", listEmployee.Count);
            if (listEmployee.Count != 0)
            {
                for (var iteration = 0; iteration < listEmployee.Count; iteration++)
                {
                    Console.Write((iteration+1) + ". ");
                    var employee = listEmployee[iteration];
                    employee.ShowEntry();
                }
            }
        }

        static void SearchEntry(List<Employee> listEmployee)
        {
            Console.WriteLine("Search by [S]urname, [F]orename or [P]hone?");
            Console.Write("\n>");
            var results = new List<Employee>();
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1":
                case "s":
                case "surname":
                    Console.Write("\nSurname: ");
                    input = Console.ReadLine();
                    results = listEmployee.FindAll((employee) => employee.Surname == input);
                    break;
                case "2":
                case "f":
                case "forename":
                    Console.Write("\nForename: ");
                    input = Console.ReadLine();
                    results = listEmployee.FindAll((employee) => employee.Forename == input);
                    break;
                case "3":
                case "p":
                case "phone":
                    Console.Write("\nPhone: ");
                    input = Console.ReadLine();
                    results = listEmployee.FindAll((employee) => employee.PhoneNumber == input);
                    break;
                default:
                    Console.WriteLine("ERROR: Unknown command.");
                    break;
            }
            ShowFoundedEntries(listEmployee);
            ShowMenu(listEmployee);
        }

        static void ShowFoundedEntries(List<Employee> listFounded)
        {
            if (listFounded.Count != 0)
            {
                Console.WriteLine("Here is all founded entries:");
                foreach (var entry in listFounded)
                {
                    entry.ShowEntry();
                }
            }
            else
            {
                Console.WriteLine("Nothing found.");
            }
        }

        static void SortEntry(List<Employee> listEmployee)
        {
            Console.WriteLine("Sort by [S]urname or by [B]irth Year?");
            Console.Write("\n>");
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1":
                case "s":
                case "surname":
                    Console.WriteLine("\nHere is sorted by surname employees list: ");
                    listEmployee.Sort((employee1, employee2) => employee1.Surname.CompareTo(employee2.Surname));
                    break;
                case "2":
                case "b":
                case "birth year":
                    Console.WriteLine("\nHere is sorted by birth year employees list: ");
                    listEmployee.Sort((employee1, employee2) => employee1.BirthYear.CompareTo(employee2.BirthYear));
                    break;
                default:
                    Console.WriteLine("ERROR: Unknown command.");
                    break;
            }
            ShowList(listEmployee);
            ShowMenu(listEmployee);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(
                @"

   $$$$$\            $$\     $$\                         
   \__$$ |           $$ |    $$ |                        
      $$ | $$$$$$\ $$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\  
      $$ |$$  __$$\\_$$  _|\_$$  _|  $$  __$$\ $$  __$$\ 
$$\   $$ |$$ /  $$ | $$ |    $$ |    $$$$$$$$ |$$ |  \__|
$$ |  $$ |$$ |  $$ | $$ |$$\ $$ |$$\ $$   ____|$$ |      
\$$$$$$  |\$$$$$$  | \$$$$  |\$$$$  |\$$$$$$$\ $$ |      
 \______/  \______/   \____/  \____/  \_______|\__|      
                                                    ");
            var listEmployee = new List<Employee>();
            Console.WriteLine("Welcome to Jotter.exe!\nThere are {0} entries at this moment.", listEmployee.Count);
            ShowMenu(listEmployee);
            //Console.ReadKey(true);
        }
    }
}