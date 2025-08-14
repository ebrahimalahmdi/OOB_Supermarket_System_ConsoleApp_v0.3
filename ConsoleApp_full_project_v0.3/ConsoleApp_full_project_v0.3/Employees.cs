using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_full_project_v0._3
{
    /*
==============================================
==   I will write property (الخصائص ) == Encapsulation 
==  in the property I can Access in the the varibles About private --> get and set 
==============================================
*/
    // peroperty  مبدا الخصائص 
    class Employee : prson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }


    class Employees
    {
        //===================================================
        //- List<DataType> listName = new List<DataType>();
        //====================================================
        static List<Employee> employees = new List<Employee>();


        static public void DisplayData()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("==============================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- Add employees");
                Console.WriteLine("2- Edit employees");
                Console.WriteLine("3- Remove employees");
                Console.WriteLine("4- List employees");
                Console.WriteLine("5- Exit");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("==============================");


                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        EditEmployee();
                        break;
                    case 3:
                        RemoveEmployee();
                        break;
                    case 4:
                        ListEmployees();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");  // اختيار غير صالح
                        break;
                }
            }
        }

        static public void AddEmployee()
        {
            Console.WriteLine("Enter employee id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee salary:");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee department:");
            string department = Console.ReadLine();

            employees.Add(new Employee { Id = id, Name = name, Salary = salary, Department = department });

            Console.WriteLine("Employee added successfully");
        }

        static void EditEmployee()
        {
            Console.WriteLine("Enter employee id:");
            int id = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(e => e.Id == id);
            // Employee employeess= employees.Find(b => b.Id == id);
            //employee ==> متغير جديد 

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }  // إذا الموظفين يساوي نل  اخرج واكمل باقي الداله 

            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee salary:");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee department:");
            string department = Console.ReadLine();

            employee.Name = name;
            employee.Salary = salary;
            employee.Department = department;


            Console.WriteLine("Employee updated successfully");
        }

        static public void RemoveEmployee()
        {
            Console.WriteLine("Enter employee id:");
            int id = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(e => e.Id == id);
            // employee===> متغير 

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }

            employees.Remove(employee);

            Console.WriteLine("Employee removed successfully");
        }

        static public void ListEmployees()
        {
                // هاذا افضل الالوان 
            Console.ForegroundColor = ConsoleColor.DarkRed;


            Console.WriteLine("===================================|");

            Console.WriteLine(" Id\t|Name\t|Salary\t|Department|");

            Console.WriteLine("-----------------------------------|");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(" " + $"{employee.Id}\t{employee.Name}\t{employee.Salary}\t{employee.Department}");


                Console.WriteLine("===================================|");

                // footer_Employees footer_Employees = new footer_Employees();
                // footer_Employees.footer_();
            }



            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

//            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.ForegroundColor = ConsoleColor.DarkRed;

            ABOUT_US ABOUT_US = new ABOUT_US();
            Console.ReadKey();
        }
    }
}
