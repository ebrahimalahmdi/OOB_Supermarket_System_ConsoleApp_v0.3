using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_full_project_v0._3
{
    internal class Program
    {
        


            static void Main(string[] args)
            {



            /*
            ==============================================
            ==   class headr_system I Will  uesd about 
            ==    Construct Function  without variables
            ==   TECHNO_SYS
            ==============================================
            */
            Console.ForegroundColor = ConsoleColor.Red;
            headr_system headr_System = new headr_system();

        

            //  !_____________________________________________________________________!

            Console.Write(" !-!-! ");
  Agin:;
            Console.Write("\n -Enter your User Name :");
            string username = Console.ReadLine();
            //   login Function 
            Console.Write( "Welcome "+ username +"\n Enter your Password :");
            string password = Console.ReadLine();
            if (username == "123" &  password == "123" )
            {

                Console.WriteLine("\n");
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Green;



                Console.WriteLine("Welcome to Main Class Who Controls All Classes in The Supermarket System :- ");
            Console.WriteLine("\n");
            Console.WriteLine("1- if you want to inside and control the  =-_=-_=_=-_=--> Employees Section , Press the Number one. ");
            Console.WriteLine("2- if you want to inside and control the  =-_=-_=_=-_=--> Customers Section , Press the Number two. ");
            Console.WriteLine("3- if you want to inside and control the  =-_=-_=_=-_=--> products Section , Press the Number three. ");
            Console.WriteLine("4- if you want to inside and control the  =-_=-_=_=-_=--> help you  Section , Press the Number four. ");
            Console.WriteLine("5- if you want to inside and control the  =-_=-_=_=-_=--> About US Section , Press the Number five. ");

            //الرجاء اختيار القسم المناسب
            //  Console.WriteLine("Please Select the appropiate Section  :- ");   =-_=-_=_=-_=-   
            //Console.WriteLine("1- Employee");
            //Console.WriteLine("2- Customers");
            //Console.WriteLine("3- Store");
            //Console.WriteLine("4- products");


            int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("{===========>Employees :-");
                        // Console.WriteLine("\n");
                        headr_Employees headr_Employees = new headr_Employees();
                        headr_Employees.headr_();


                        Employees Employees = new Employees();
                        Employees.DisplayData();
                        //   كلاس الموظفين هنا
                        footer_Employees footer_Employees = new footer_Employees();
                        footer_Employees.footer_();

                        break;
                    case 2:

                        Console.WriteLine("{-------->->->Customers :-");


                        headr headr2 = new headr();
                        headr2.headr_();

                        Customers Customers = new Customers();
                        Customers.DisplayData();


                        break;

                    
                    case 3:

                        Console.WriteLine(" Products  ");
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        /*
                       ==============================================================
                       ==   class Products I Will  uesd about 
                       ==   Construct Function  with  variables
                       ==   show All the Product-->Product_object.View_AllL_Products();
                       ==  if I want write and print the Products--> .print_code();
                       ===============================================================
                       */

                        //   الخاصة بكلاس بعرض المنتجات هنا
                        //Product Product_object = new Product(1, "Ebrahim", "mohammed ", "20");


                        //     == I desing this becouecs print interface the juice section 
                        // juice section 
                        designs_interfaces_for_product_juice_sections
                        designs_interfaces_for_product_juice_sections 
                       = new designs_interfaces_for_product_juice_sections();


                        Console.WriteLine("\t       juice section ");
                        Console.WriteLine("\n");
                        Product Product_object1 = new Product(1, "mango juice", "2500", "we have alot");
                        Product_object1.View_AllL_Products();
                        Product Product_object2 = new Product(1, "Orange juice", "300", "we have two balls ");//balls==> كراتين
                        Product_object2.View_AllL_Products();
                        Product Product_object3 = new Product(1, "Chocolate juice", "2500", "we have some");
                        Product_object3.View_AllL_Products();



                        //     == I desing this becouecs print interface the library section 
                        designs_interfaces_for_product_Chocolate_sections
                       designs_Interfaces_For_Product_Chocolate_Sections =
                         new designs_interfaces_for_product_Chocolate_sections();



                    // Chocolate section
                    Console.WriteLine("\t      library section ");
                        Console.WriteLine("\n");

                        Product Product_object4 = new Product(1, "Notebooks(100)papers ", "380", "");
                        Product_object4.View_AllL_Products();
                        Product Product_object5 = new Product(2, "Notebooks(60)papers ", "250", "");
                        Product_object5.View_AllL_Products();
                        Product Product_object6 = new Product(3, "pencil ", "50", "");
                        Product_object6.View_AllL_Products();
                        Product Product_object7 = new Product(4, "pen  ", "120", "Blue Colored pen ");
                        Product_object7.View_AllL_Products();
                        Product Product_object8 = new Product(5, "pen  ", "150", "red Colored pen ");
                        Product_object8.View_AllL_Products();

                        //
                        //     == I desing this becouecs print interface the Chocolate section 
                        designs_interfaces_for_product_library_sections
                        designs_Interfaces_For_Product_Library_Sections = new 
                        designs_interfaces_for_product_library_sections();


                    // library  section 
                    Console.WriteLine("\t       Chocolate section ");
                    Console.WriteLine("\n");

                        Product Product_object9 = new Product(6, "Snickers Chocolate", "8000", "we have alot");
                        Product_object9.View_AllL_Products();
                        Product Product_object10 = new Product(7, "kinder Chocolate", "10500", "we have about 30  balls ");//balls==> كراتين
                        Product_object10.View_AllL_Products();
                        Product Product_object11 = new Product(8, "break Chocolate", "4500", "we have some");
                        Product_object11.View_AllL_Products();


                        //     == I desing this becouecs print interface the Vegetable  And fruits section 
                        designs_interfaces_for_product_Vegetable_And_fruits_sections
                        designs_interfaces_for_product_Vegetable_And_fruits_sections 
                         = new designs_interfaces_for_product_Vegetable_And_fruits_sections();

                         // Vegetable  And fruits  section 
                        Console.WriteLine("      Vegetable  And fruits section ");
                        Console.WriteLine("\n");

                        Product Product_object12 = new Product(9, "the banana ", "the price per kilo is 700 ", "");
                        Product_object12.View_AllL_Products();
                        Product Product_object13 = new Product(10, "the Apple  ", "the price per kilo is 3350 ", "Apples outside ");
                        Product_object13.View_AllL_Products();
                        Product Product_object14 = new Product(11, "the Apple  ", "the price per kilo is 750 ", "Apples inside ");
                        Product_object14.View_AllL_Products();
                        Product Product_object15 = new Product(12, "the Lemon  ", "the price per kilo is 950 ", "");
                        Product_object15.View_AllL_Products();
                        Product Product_object16 = new Product(13, "the onions ", "the price per kilo is 600 ", "");
                        Product_object16.View_AllL_Products();
                        Product Product_object17 = new Product(14, "the tomatoe ", "the price per kilo is 800 ", "");
                        Product_object17.View_AllL_Products();



                        /*
                        ==============================================================
                        ==   Function View_AllL_Products I Will  uesd about 
                        ==    print All my  Products in the Black Screen Directly 
                        ==============================================================
                        */
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Product_object1.View_AllL_Products();
                        //



                        /*
                        ==============================================================
                        ==   Function print_code I Will  uesd about 
                        ==   if I want write and print your  Products 
                        ==============================================================
                        */

                        Product_object1.print_code();

                        break;
                //
                case 4:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine(" help_you ");

                        /*
                       ==============================================================
                       ==   Function help_you I Will  uesd about  logo 
                       ==  Construct Function  with static 
                       ==    وتظهر مره واحده حتى لو انشات اكثر ن كائن 
                       ==============================================================
                       */


                        help_you help_You = new help_you();



                    Console.WriteLine("\n");

                    //            اذا كنت عميل جديد هذا الكلام موجه لك
                    Console.WriteLine("\t \t \t <| If you are a new customer this speech prompt for you |> \n" +
                                        "\t \t \t  --------------------------------------------------------");
                    Console.WriteLine("\n");






                    help_You.help_you_(1,"-> We have more than one group on social media, all you have to do is click on the link \n" +
                                         "----------------------------------------------------------------------------------------- \n" +
                                          "and join the special group in Techno SAS Systems in order to understand its system better \n " +
                                          "----------------------------------------------------------------------------------------- \n ");
                   // يوجد لدينا اكثر من مجموعه في وسائل التواصل الاجتماعي ما عليك الا الضغط على الرابط والانضمام في المجموعه الخاصه في انظمه تكنو ساس  لكي تفهم نظامه بشكل افضل.

                    //   //

                    help_You.help_you_(2, "-> Do not learn all the explanations at the same time. You must first understand the first lesson, \n" +
                                          "---------------------------------------------------------------------------------------------------- \n" +
                                           "and then you can move on to the second lesson. \n" +
                                           "---------------------------------------------- \n ");
                    //  // لا تتعلم كل الشروحات في نفس الوقت عليك اولا ان تقوم في فهم الدرس الاول و بعد ذلك يمكنك الانتقال الى الدرس الثاني.





                    help_You.help_you_(3, "-> Do not watch the explanations of the system as if it were a movie. \n" +
                                          "------------------------------------------------------------------------ \n" +
                                          "You have to apply and try to implement the same thing you see in the explanation.\n" +
                                          "---------------------------------------------------------------------------------- \n");
                    // //  لا تشاهد شروحات النظام كانها فيلم عليك ان تقوم بتطبيق ومحاوله تنفيذ نفس ما تراه بالشرح.



                    // the logo footer
                    footer footer = new footer();
                    footer.footer_();






                    /////////////

                    break;

                ////

                case 5:



                        /*
               ==============================================
               ==   class ABOUT_US I Will  uesd about 
               ==    Construct Function  with static 
               ==============================================
               */
                        Console.ForegroundColor = ConsoleColor.White;
                        // داله بناء  من نوع static
                        ABOUT_US ABOUT_US = new ABOUT_US();
                        //  Console.BackgroundColor=ConsoleColor.Red ;
                               Console.BackgroundColor = ConsoleColor.Blue;




                        string id_ = "|>";
                    double MY_Number_ = 967772053309 ;
                    string connect_ = " TO Connect with the Company you can contact the free Number :-  ";

                    ABOUT_US.ABOUT_US_(id_, connect_, MY_Number_);







                    //تم تصميم هاذا النظام من قبل افضل  المبرمجين  والمهندسين ومن ضمنهم المبرمج ابراهيم الاحمدي  والذي يعتبر  واحد من مالكي شركة تكنو ساس  
                    string designed_ = "|> This system is designed by the best programmers and engineers including \n" +
                                        "--------------------------------------------------------------------------- \n" +
                                       "|> Ibrahim Al_Ahmadi, which is one of Techno SAS owners.\n" +
                                       "--------------------------------------------------------- ";

                                ABOUT_US.ABOUT_US_(designed_);




                                ABOUT_US.ABOUT_US_();



                            footer footer_ = new footer();
                            footer_.footer_();





                    ///



                    //            اذا كنت عميل جديد هذا الكلام موجه لك
                    //   Console.WriteLine("\t \t - If you are a new customer this speech prompt for you.");




                    //   ABOUT_US.ABOUT_US_(1, "-  We have more than one group on social media, all you have to do is click on the link and join the special group in Techno SAS Systems in order to understand its system better. ");
                    ////   يوجد لدينا اكثر من مجموعه في وسائل التواصل الاجتماعي ما عليك الا الضغط الرابط والانضمام في المجموعه الخاصه في انظمه تكنوسات لكي تفهم نظامه بشكل افضل.

                    //   //

                    //   ABOUT_US.ABOUT_US_(2, " - Do not learn all the explanations at the same time. You must first understand the first lesson, and then you can move on to the second lesson. ");
                    //  // لا تتعلم كل الشروحات في نفس الوقت عليك اولا ان تقوم في فهم الدرس الاول و بعد ذلك يمكنك الانتقال الى الدرس الثاني.





                    //         ABOUT_US.ABOUT_US_(4, "- Do not watch the explanations of the system as if it were a movie. You have to apply and try to implement the same thing you see in the explanation. ");
                    // //  لا تشاهد شروحات النظام كانها فيلم عليك ان تقوم بتطبيق ومحاوله تنفيذ نفس ما تراه بالشرح.











                    break;


                    default:
                        //خيار غير صحيح!

                        Console.WriteLine(" Incorrect Selection_! ");
                        break;
                }










                /// end the login admin 

            }
            else
            {

               


                Console.WriteLine("\n ");
                Console.WriteLine("\n ");

                Console.WriteLine("\t\t  Sorry, you have an incorrect username or password_! ");
                //Console.WriteLine("\n ");

                footer footer_ = new footer();
                footer_.footer_();



                { goto Agin; }


            }



            






















            /*
             * 
             *    //print print = new print();
                //print.print_code();

                // juice section 
                //Product Product_object = new Product(1, "Manha juice", "2500", "we have alot");
                //Product_object.print_code();
                //Product Product_object = new Product(1, "Orange juice", "300", "we have two balls ");//balls==> كراتين
                //Product_object.print_code(); 
                //Product Product_object = new Product(1, "frit juice", "2500", "we have some");
                //Product_object.print_code();


                // library  section 
                //Product Product_object = new Product(1, "Snickers Chocolate", "8000", "we have alot");
                //Product_object.print_code();
                //Product Product_object = new Product(1, "kinder Chocolate", "10500", "we have about 30  balls ");//balls==> كراتين
                //Product_object.print_code(); 
                //Product Product_object = new Product(1, "break Chocolate", "4500", "we have some");
                //Product_object.print_code();
                //



                // Chocolate section 
                //Product Product_object = new Product(1, "Notebooks(100)papers ", "380", "");
                //Product_object.print_code();
                //Product Product_object = new Product(1, "Notebooks(60)papers ", "250", "");
                //Product_object.print_code();
                //Product Product_object = new Product(1, "pencil ", "50", "");
                //Product_object.print_code(); 
                //Product Product_object = new Product(1, "pen  ", "120", "Blue Colored pen ");
                //Product_object.print_code();
                //Product Product_object = new Product(1, "pen  ", "150", "red Colored pen ");
                //Product_object.print_code();
                //

                // Vegetable  And fruits  section 
                //Product Product_object = new Product(1, "the banana ", "the price per kilo is 700 ", "");
                //Product_object.print_code();
                //Product Product_object = new Product(1, "the Apple  ", "the price per kilo is 3350 ", "Apples outside ");
                //Product_object.print_code();
                //Product Product_object = new Product(1, "the Apple  ", "the price per kilo is 750 ", "Apples inside ");
                //Product_object.print_code();
                //Product_object.print_code();//Product Product_object = new Product(1, "the Lemon  ", "the price per kilo is 950 ", "");
                //Product_object.print_code();
                //Product_object.print_code();//Product Product_object = new Product(1, "the onions ", "the price per kilo is 600 ", "");
                //Product_object.print_code();
                //Product_object.print_code();//Product Product_object = new Product(1, "the tomatoe ", "the price per kilo is 800 ", "");
                //Product_object.print_code();

             */

            // Console.ReadLine();

            /////
            ////   start:;
            ////        Console.WriteLine("Enter your name ");
            ////        string name = Console.ReadLine();
            ////        Console.WriteLine("Hello " + name);
            ////        Console.WriteLine("Do you want any to run again (y/n) ");
            ////        char c = Console.ReadLine()[0];
            ////        if (c == 'y') goto start;

            ////        else if (c == 'E')
            ////        {
            ////            ////
            ////            headr headr = new headr();
            ////            headr.headr_();
            ////            //
            ////            Employees Employees = new Employees();
            ////            Employees.DisplayData();

            ////        }
            ////        else if (c == 'C')
            ////        {
            ////            ////

            ////            Customers Customers = new Customers();
            ////            Customers.DisplayData();

            ////            footer footer = new footer();
            ////            footer.footer_();
            ////            //
            ////        }
            ////        else if  (c == 'N')
            ////        {


            ////            footer footer = new footer();
            ////            footer.footer_();
            ////        }






            //Employees Employees = new Employees();
            //Employees.DisplayData();



            //Customers Customers = new Customers();
            //Customers.DisplayData();

            Console.ReadKey();

            }
     }
    
}
