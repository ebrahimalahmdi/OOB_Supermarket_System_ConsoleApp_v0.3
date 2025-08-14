/*
==============================================
==   class prson
==  I have in this class one class just 
==============================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_full_project_v0._3
{
    internal class prson
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double Salary { get; set; }
        //public string Department { get; set; }
        //public string customer_name { get; set; }
      
    }


    class login
    {


        /*
     ==============================================
     ==  login Function   about  password  
      Console.Write(" !-!-! ");
Agin:;
      Console.Write("\n -Enter your User Name :");
      string username = Console.ReadLine();
      //   login Function 
      Console.Write( "Welcome "+ username +"\n Enter your Password :");
      string password = Console.ReadLine();
      if (username == "Ebrahim" &  password == "123456" )
      {
      // my code !----------!
          Console.WriteLine("\n");
          Console.WriteLine("\n");
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
     ==============================================
     */
    }




    //-----___----____---____-----____-----_____-------________-----____--


    class comments
    {

        /*
        =================================================================================================
        ==  هي دالة في لغة السي شارب تستخدم لإنشاء مصفوفة ديناميكية قابلة للتوسع
        == يعني أن القيم يمكن إضافتها وحذفها من المصفوفة بشكل ديناميكي خلال تشغيل البرنامج
        ==     وليس في وقت تصميم البرنامج 
        == يمكن تعريف المصفوفة باستخدام دالة List بالطريقة التالية
        == List<DataType> listName = new List<DataType>();
        == هو نوع القيم التي يتم تخزينها في المصفوفة، ويمكن استخدام أي نوع بيانات في لغة السي شارب  DataType
        == حيث   على سبيل المثال، يمكن تعريف مصفوفة تخزن أرقام صحيحة كالتالي
        == List<int> numbers = new List<int>();
        == يمكن إضافة عناصر إلى المصفوفة باستخدام دالة Add() 
        == numbers.Add(5);    القيمة 5 تمت إضافتها إلى المصفوفة
        == numbers.Add(10);  القيمة 10 تمت إضافتها إلى المصفوفة
        == يمكن حذف العناصر من المصفوفة باستخدام دالة Remove()
        == numbers.Remove(5);  القيمة 5 تمت حذفها من المصفوفة
        == يمكن الوصول إلى العناصر في المصفوفة باستخدام الفهرس (Index)
        == Console.WriteLine(numbers[0]);  يتم طباعة القيمة 10 لأنها في الموضع 0 في المصفوفة
        == لمعرفة عدد العناصر في المصفوفة كما يلي  
        == يمكن أيضًا استخدام دالة Count
        == Console.WriteLine(numbers.Count);  يتم طباعة القيمة 1 لأن القيمة 5 تمت حذفها من المصفوفة
        =================================================================================================
        */



    }


    ////---------------------
    ///

    /*
    ==============================================
    ==   I will write property (الخصائص ) == Encapsulation 
    ==  in the property I can Access in the the varibles About private --> get and set 
    ==  الطرق المحتصره لكتابه ال  get and set 
    ==============================================
    */

    /*   
     *   /////////  this is objects in class int main program /////////////
     *   property property = new property();  // print just from property get 
            Console.WriteLine(property.Name);  // add and print from property set
            property.Name = "Ebrahim_Momammed_Al-Ahmdi";
            Console.WriteLine(property.Name);
            */

    //class property
    //{
    //    private int id = 1;
    //    private string name = "Ebrahim_-_El_Ahmdi";

    //    public int ID
    //    {
    //        get { return id; } // this is I can read and print the values jast so and I can't add into the id 
    //        set { id = value; } // yhis is I can write or  add or print 

    //    }
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //    // the same edia but very samll 
    //    private int number;

    //    public int Number
    //    { get; set; }

    //    //------______-----___- the the same edia 
    //    private int idd { get; set; }
    //    private string named { get; set; }

    //    // امشاء خاصيه للمتغير ايدي  الذي عن طريقه اسمح انه يوصل او لا 

    //}


    ///
    /*

    // constrocter  داله البناء يتم استدعائها بمجرد انشاء الكائن 
    //  تعمل لي تهيات المتغيرات 
    // يهيى اي متغير خطاء بصفر 

    //  تبدا تشتغل بمجرد ما اعمل تشغيل للبرنامج 
    // دوال البناء تستقبل قيم من الكائنات  
    //  دوال البناء لا ترجع قيمه  بمعنى انها لا تكون من النوع rutern
    //  لا يمكن اننا انشاء دوال بناء بدوان object 
    داله البناء الذي من النوع ptivet لا يمكن انحنا ننشاء منها   كائن من هاذا الكلاس 
    - يتم تنفيذ دوال البناء التي من النوع static مره واحده فقط حتى لو مرارة اكثر من كائن 
    - داله بناء dufllt تستخدم للاخطاء 
    وهوه عباره عن متغير بداخل الداله مش داخل الكلاس 


    //  مبدئ ال اوفر لودنج هو استخدام الداله بنف الاسم ولكن باختلاف الوظيفه او البارامترات 
    //


    \\ الا انكبسلين هيا عباره عن طريقه الوصول للمتغيرات الخلصه 

    -----
    مثال 
    id =id;
    name=name 
    ماهيا مخرجات البرنامج التالي 
    راح تكون null 
     إذ تشابهات متغيرات الداله مع متغيرات الكلاس ÷إذ ما عملت ال this  فراح تكوان القيمه نل 


    ---
    ال اوفر راتنج 
    إت الابن يستخدم نفس داله الاب  ولكن بسلوك مختلف 
    مبدى الاوفر راتنج هو تكرار اسم الداله ولكن مابين الاب و الابناء
    ---
    لتحقيق مبدى الافر راتنج  عن طريق كلمتين
    
    virtual    وهيا تستخدم في كلاس الاب 
    لجل ان الابناء يستطيعوان ان ياخذو الداله ويعدلو في سلوكها 

    كلمه  virtual   تسمح للابناء ان ياخذوها ويعداو في سلوكها 


    مثال 

    كيف يتحقق مبدى الاوفر راتنج 
    1- يتحقق ما بين الاب والابناء  
    2- يتم تطبيقه عن طريق كلمه   virtual   و كلمه ال   override   في الابناء 

    --  استخدم مبدى الافر راتنج 
    اذا استخدمة نفس الداله حق الاب ولكن باختلاف السلوك  
    

    */

}
