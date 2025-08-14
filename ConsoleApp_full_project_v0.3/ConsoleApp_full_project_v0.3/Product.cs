using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_full_project_v0._3
{




    /*
    =========================================================================
    ==   class Products I Will  uesd about 
    ==   Construct Function  with  variables
    ==  1-  show All the Products in the function View_AllL_Products  
    ==  2- if I want write and print your  Products function  print_code
    ==========================================================================
    */






    /*
    ==============================================
    ==   class Products I Will  uesd about 
    ==   Construct Function  with five  variables
    ==  هاذا الكلاس يستخد لعمل داله البناء  Product
    ==============================================
    */
    internal class Product
    {

        public Product(int id, string Product_name, string Product_price, string Product_quantity )
        {
            this.id = id;
            this.Product_name = Product_name;
            this.Product_price = Product_price;
            this.Product_quantity = Product_quantity; // كميه المنتج 
        
        }


        public int id;
        public string Product_name;
        public string Product_price;  
        public string Product_quantity; // كميه المنتج 




/*
==============================================================
==   Function View_AllL_Products I Will  uesd about 
==    print All my  Products in the Black Screen Directly 
==============================================================
*/
        public void View_AllL_Products()
        {


            string All_Data = "-" + id + "\t";
            All_Data += " " + Product_name + "\t";
            All_Data += " " + Product_price + "\t";
            All_Data += " " + Product_quantity + "\n";
          

            Console.WriteLine(All_Data);
 

        }






/*
==============================================================
==   Function print_code I Will  uesd about 
==   if I want write and print your  Products 
==============================================================
*/







        public void print_code()
        {
            Console.WriteLine("\n");


        start:;
            Console.WriteLine(" Please, can you Enter your name here to help you choose your product ");
            Console.WriteLine("-----------------------------------------------------------------------");

            // لو سمحت ممكن تدخل اسمك هنا لاجل مساعدتك في اختيار  طلباتك 

            string name = Console.ReadLine();

            Console.WriteLine(" \t \t \t  Welcome " + name);

            Console.WriteLine("\n");


            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            Console.WriteLine(" if you want to start selecting your orders, you can start after pressing the letter -------> (    S    )   ");
            char c = Console.ReadLine()[0];
            // إذا تريد ان تبدا في اختيار طلباتك يمكنك ان تبدا بعد ما تضغط الحرف اس  
            Console.WriteLine();


            if (c == 'R') goto start;

            else if (c == 'S')
            {
            

                Console.WriteLine("+===============================+");
                Console.WriteLine("|        Product                |");
                Console.WriteLine("+===============================+");

                Console.Write("|  product id     | ");


                int productid = int.Parse(Console.ReadLine());


                Console.Write("|  product Name    | ");


                string productName = Console.ReadLine();


                Console.Write("|  product Price   | ");

                string productPrice = Console.ReadLine();

                Console.Write("|  product Quantity | ");

                string productQuantity = Console.ReadLine();

                Console.WriteLine("+------------------------------+");
                Console.WriteLine();

                // تم إضافة المنتج بنجاح
                Console.WriteLine(" the Product has been added successfully ");
                Console.WriteLine();

                Console.WriteLine("product id  : " + productid);

                Console.WriteLine(" product Name : " + productName);

                Console.WriteLine("product Price : " + productPrice);

                Console.WriteLine(" product Quantity: " + productQuantity);

                Console.WriteLine();

                           


                ////
                ///
                Console.WriteLine();
                Console.WriteLine("  click on any exit key   ...");
                Console.WriteLine();

                ////

                Console.ReadKey();

            }

            //else if (c == 'R')
            //{


            //    Console.WriteLine("if  you want to re-choice your next character  ===>  (  R  )");
            //    char cc= Console.ReadLine()[0];

            //    { goto start; }
            //}


            //else
            //{

            //    { goto start; }
            //} 




        }




    }


   
}
