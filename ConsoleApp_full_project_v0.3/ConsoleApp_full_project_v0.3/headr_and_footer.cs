using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_full_project_v0._3
{
    //internal class headr_and_footer
    //{
    //}




    /*
    ==============================================
    == class headr Function -->headr_ <-- Customers
    == I Will  uesd about 
    ==  interface for the Customers Section
    ==============================================
    */

    class headr
    {
        public void headr_()
        {

            Console.WriteLine("\t ========================== Welcome, you are Now in the Customers Section =================================");

            Console.WriteLine("\n");
        }
    }



    /*
    ==============================================
    == class headr_Employees 
    == Function --> headr_ <-- Employees
    == I Will  uesd about 
    ==  interface for the Employees Section  
    == and this is class inhertent from class headr
    ===============================================
    */
    class headr_Employees : headr
    {
        public void headr_()
        {

            Console.WriteLine("\t ========================== Welcome, you are Now in the Employees Section =================================");

            Console.WriteLine("\n");
        }

    }



    /*
    ==============================================
    == ***
    == class footer_Employees 
    == Function --> footer_ <-- Employees
    == I Will  uesd about 
    ==  interface for the Employees Section  
    == and this is class inhertent from class footer
    ===============================================
    */

    class footer_Employees : footer
    {
        public void footer_()
        {
            Console.WriteLine("\n");

            Console.WriteLine("\n");


            Console.WriteLine("\t ==========================   your Employees Department is finished      =================================");

            Console.WriteLine("\n");
        }

    }






    class footer
    {
        public void footer_()
        {
            Console.BackgroundColor=ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n");
            Console.WriteLine("\t \t  |>--------->   ^_^    -!-!-!-     ^_^    <------<|");


            // Console.WriteLine("\t \t  |>--------->   ^_^    -!-!-!-     ^_^    <------<|");

            // Console.WriteLine("\t |>--------->  -!-!-!-  <------<|");

        }

    }
}
