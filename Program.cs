using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotter
{
    class Program
    {
        public static void ShowMenu(List<Employee> listEmployee, List<Manager> listManager)
        {
            Console.Write("\nMENU:\nAdd [E]mployee\nAdd [M]anager\n[D]elete entry\nSearch by [S]urname\nSearch by [F]orename\nSearch by [P]hone\nSort by s[U]rename\nSort by birth [Y]ear\n[Q]uit\n\n>");
            
            switch (Console.Read())
            {
                case 'E':
                    Employee.MakeEntryEmployee(listEmployee);
                    ShowMenu(listEmployee, listManager);
                    break;
                case 'M':
                    Manager.MakeEntryManager(listManager);
                    ShowMenu(listEmployee, listManager);
                    break;
                case 'S':
                    Console.WriteLine("S");
                    break;
                case 'F':
                    Console.WriteLine("F");
                    break;
                case 'P':
                    Console.WriteLine("P");
                    break;
                case 'U':
                    Console.WriteLine("U");
                    break;
                case 'Y':
                    Console.WriteLine("Y");
                    break;
                case 'Q':
                    Console.WriteLine("Q");
                    break;
                default:
                    ShowMenu(listEmployee, listManager); // TODO solve the problem when he Read every char in "teststring"
                    break;
            }
        }

        static void Main(string[] args)
        {
            var listEmployee = new List<Employee>();
            var listManager = new List<Manager>();
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
            var listAll = new List<Employee>();
            listAll.AddRange(listEmployee);
            listAll.AddRange(listManager);
            Console.WriteLine("Welcome to Jotter.exe!\nThere are {0} entries at this moment.\nOf which {1} are managers.", listAll.Capacity, listManager.Capacity);
            ShowMenu(listEmployee, listManager);
            //Console.ReadKey(true);
        }
    }
}
