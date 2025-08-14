using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_full_project_v0._3
{
/*
==============================================
==   class headr_system I Will  uesd about 
==    Construct Function  without variables
==============================================
*/
    internal class headr_system
    {
      public  headr_system()
        {

           

            //  مرحبا بك في نظام  تكنو ساس 
            Console.WriteLine("\t\t <-------------------- Welcome to our Techno SAS System -------------------->  ");
            Console.WriteLine("\n");
        }
    }

    //
    /*
============================================================================================
==   I Will  uesd about  
==  1-  Construct Function  with variables And
==  2-  inheritance   
the first class is --> designs_interfaces_for_product_Chocolate_sections
the first class is --> designs_interfaces_for_product_library_sections
the first class is --> designs_interfaces_for_product_Vegetable_And_fruits_sections
=============================================================================================
*/





    /*
===============================================================
==   class designs_interfaces_for_product_juice_sections
==  I have in this class one Construct function  has name is
==  designs_interfaces_for_product_juice_sections 
== I desing this becouecs print interface the juice section 
================================================================
*/
    class designs_interfaces_for_product_juice_sections
    {
    

      public designs_interfaces_for_product_juice_sections()
        {
            Console.WriteLine("\n");

            string first ="|=============================================|";
            string print_type ="|                   Product                   |";
            string       last ="|=============================================|";

           
            
            
                            Console.WriteLine(first);
            
                            Console.WriteLine(last);


        }


    }

    /*
=============================================================
==   class designs_interfaces_for_product_Chocolate_sections
== there is inhertent from class 
== designs_interfaces_for_product_juice_sections
==  I have in this class one Construct function has name is
== designs_interfaces_for_product_Chocolate_sections
== I desing this becouecs print interface the Chocolate section 
==============================================================
*/


    class designs_interfaces_for_product_Chocolate_sections : designs_interfaces_for_product_juice_sections
    {
        public designs_interfaces_for_product_Chocolate_sections()
        {    
        }
    }




    /*
    =============================================================
    ==   class designs_interfaces_for_product_library_sections
    == there is inhertent from class 
    == designs_interfaces_for_product_Chocolate_sections
    ==  I have in this class one Construct function has name is
    == designs_interfaces_for_product_library_sections
    == I desing this becouecs print interface the library section 
    ==============================================================
    */


    class designs_interfaces_for_product_library_sections : designs_interfaces_for_product_Chocolate_sections
    {
        public designs_interfaces_for_product_library_sections()
        {
        }
    }







/*
============================================================================
==   class designs_interfaces_for_product_Vegetable_And_fruits_sections
== there is inhertent from class 
== designs_interfaces_for_product_library_sections
==  I have in this class one Construct function has name is
== designs_interfaces_for_product_Vegetable_And_fruits_sections
== I desing this becouecs print interface the Vegetable And fruits section 
============================================================================
*/



    class designs_interfaces_for_product_Vegetable_And_fruits_sections : designs_interfaces_for_product_library_sections
    {
        public designs_interfaces_for_product_Vegetable_And_fruits_sections()
        {
        }
    }








    /*
     ==============================================
     ==   class ABOUT_US I Will  uesd about 
     ==    Construct Function  with static 
     ==============================================
     */
    // داله بناء  من نوع static


    class ABOUT_US
    {
        // داله بناء من نوع    static
        //  يتم تنفيذ دوال البناء التي من النوع استاتك بمجرد انشاء كائن من الدوال العاديه 
        //  وتظهر مره واحده حتى لو انشات اكثر ن كائن 


        static ABOUT_US ()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("|------------------------------------------Techno SAS System-------------------------------------------------|");
            Console.WriteLine("+============================================================================================================+");
                
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;


        }


        /// functoins abou over loding  

        public void ABOUT_US_(string id, string connect, double MY_Number)
        {
           // Console.WriteLine("\n");

            Console.WriteLine(id + connect + MY_Number);

            Console.WriteLine("-------------------------------------------------------------------------------");
          //  Console.WriteLine();

        }
        //






        public void ABOUT_US_(string designed)
        {
           // Console.WriteLine("\n");
           
            Console.WriteLine(designed);
        }

        //
        public void ABOUT_US_()
        {
            //  Console.WriteLine("\n");

            //  مقاله عن شركتناااا

            Console.WriteLine("|>Among our Services is the design of all special Applications in Phones and Computers,\n" +
                             "----------------------------------------------------------------------------------------\n" +
                             "|> the design of all system in Oracle, \n" +
                            "----------------------------------------\n" +
                            "|> and the design of dynamic and static websites in the world of the Internet. \n" +
                           "-------------------------------------------------------------------------------\n");

        }





        ///  Among our Services is the design of all special Applications in Phones and Computers ,
        ///  the design of all system in Oracle, 

        /// and the design of dynamic and static websites in the world of the Internet  
        ///  من خدماتنا تصميم جميع التطبيقات الخاصه با التلفونات و الكمبيوتر و تصميم جميع الانظمه في اوراكل و تصميم مواقع دينميكيه وثابته في عالم الانترنت 






        //public void ABOUT_US_(int id, string speech)
        //{
        //  //  Console.WriteLine("\n");



        //    string ABOUT_US_help_you = "" + id ;
        //    ABOUT_US_help_you += " " + speech + "\n";


        //    Console.WriteLine(ABOUT_US_help_you);


        //}

        //            اذا كنت عميل جديد هذا الكلام موجه لك

        /*
     يوجد لدينا اكثر من مجموعه في وسائل التواصل الاجتماعي ما عليك الا الضغط الرابط والانضمام في المجموعه الخاصه في انظمه تكنوسات لكي تفهم نظامه بشكل افضل.
  We have more than one group on social media, all you have to do is click on the link and join the special group in Technosat Systems in order to understand its system better.


  ______

  لا تشاهد شروحات النظام كانها فيلم عليك ان تقوم بتطبيق ومحاوله تنفيذ نفس ما تراه بالشرح.

  Do not watch the explanations of the system as if it were a movie. You have to apply and try to implement the same thing you see in the explanation.


  ________

  لا تتعلم كل الشروحات في نفس الوقت عليك اولا ان تقوم في فهم الدرس الاول و بعد ذلك يمكنك الانتقال الى الدرس الثاني.


  Do not learn all the explanations at the same time. You must first understand the first lesson, and then you can move on to the second lesson.


  ______

  يوجد لدينا اكثر من مجموعه في وسائل التواصل الاجتماعي ما عليك الا الضغط الرابط والانضمام في المجموعه الخاصه في انظمه تكنوسات لكي تفهم نظامك بشكل افضل.

  We have more than one group on social media, all you have to do is click on the link and join the special group in Technosat Systems in order to better understand your system.



         */

    }


    ///


    class help_you
    {


        static help_you()
        {

            Console.WriteLine("+============================================================================================================+");
            Console.WriteLine("|------------------------------------------Techno SAS System-------------------------------------------------|");
            Console.WriteLine("+============================================================================================================+");

            Console.WriteLine("\n");



        }



        public void help_you_(int id, string speech)
        {
            //  Console.WriteLine("\n");



            string help__you = "" + id;
            help__you += " " + speech + "\n";


            Console.WriteLine(help__you);


        }


    }

}
