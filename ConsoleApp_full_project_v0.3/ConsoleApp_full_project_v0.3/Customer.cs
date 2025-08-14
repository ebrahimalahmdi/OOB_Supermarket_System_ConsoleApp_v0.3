using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
==============================================
==   I will write property (الخصائص ) == Encapsulation 
==  in the property I can Access in the the varibles About private --> get and set 
==============================================
*/

/*
==============================================
==  this is  class  about Customers   
==   I Write here tow classes 
==  1- class Customer ---> without S in the last char
== this class is inheritance from class prson 
==  2- class  Customers in this class I design a loat of functions 
==     1- DisplayData  ---> chack from the inside users What he's need 
==     2- AddCustomers --->I can inside the new customers 
==     3- EditCustomers --->I can er intthing  from the  customers 
==     4- RemoveCustomers ---> I can delete any Customers عبرعبر ال  id
==     5- ListCustomers   --->  print All Datea
==============================================
*/

namespace ConsoleApp_full_project_v0._3
{
    internal class Customer : prson
    {
        public int Id { get; set; }
        public string Name { get; set; }
      //  public double Salary { get; set; }
        public double THE_Quantity { get; set; }//  الكميه 

        public string the_Customer_request { get; set; }  // طلاب الاعملاء 

    }

    internal class Customers
    {
        //===================================================
        //- List<DataType> listName = new List<DataType>();
        //====================================================
        static List<Customer> cstomers = new List<Customer>();

        static public void DisplayData()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("==============================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- Add Customers");
                Console.WriteLine("2- Edit Customers");
                Console.WriteLine("3- Remove Customers");
                Console.WriteLine("4- List Customers");
                Console.WriteLine("5- Exit");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("==============================");


                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddCustomers();
                        break;
                    case 2:
                        EditCustomers();
                        break;
                    case 3:
                        RemoveCustomers();
                        break;
                    case 4:
                        ListCustomers();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
        ////
        ///
        static public void AddCustomers()
        {
            Console.WriteLine("Enter Customers id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customers name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Customers THE_Quantity:");
            double the_quantity = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customers request :");
            string the_Customer_request = Console.ReadLine();
            //////////////////////////////////
            cstomers.Add(new Customer { Id = id, Name = name, THE_Quantity = the_quantity, the_Customer_request = the_Customer_request });

            Console.WriteLine("Customers added successfully");
        }
        /////
        static void EditCustomers()
        {
            Console.WriteLine("Enter Customers id:");
            int id = int.Parse(Console.ReadLine());

            Customer cstomer_E = cstomers.Find(e => e.Id == id);  //cstomer_E==>Edit

            if (cstomer_E == null)
            {
                Console.WriteLine("Customers not found");
                return;
            }

            Console.WriteLine("Enter Customers name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Customers THE_Quantity:");// the_quantity  //  THE_Quantity
            double the_quantity = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customers request:");
            string the_Customer_request = Console.ReadLine();

            cstomer_E.Name = name;
            cstomer_E.THE_Quantity = the_quantity;
            cstomer_E.the_Customer_request = the_Customer_request;


            Console.WriteLine("Customers updated successfully");
        }

        static public void RemoveCustomers()
        {
            Console.WriteLine("Enter Customers id:");
            int id = int.Parse(Console.ReadLine());

            Customer cstomer_R = cstomers.Find(e => e.Id == id); //cstomer_R ===> Remove

            if (cstomer_R == null)
            {
                Console.WriteLine("Customers not found");
                return;
            }

            cstomers.Remove(cstomer_R);

            Console.WriteLine("Customers removed successfully");
        }

        static public void ListCustomers()
        {
           // Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;


            Console.WriteLine("===========================================================|");


            Console.WriteLine(" Id\t  | Name\t| quantity\t| Customer request |");

            Console.WriteLine("-----------------------------------------------------------|");
            foreach (Customer cstomers in cstomers)
            {
                Console.WriteLine($" {cstomers.Id}\t     {cstomers.Name}\t\t{cstomers.THE_Quantity}\t\t{cstomers.the_Customer_request}");


                Console.WriteLine("===========================================================|");




            }


           
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;

        }



    }
}
