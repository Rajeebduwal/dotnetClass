using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace rajibProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box b1 = new Box();
            //b1.Length = 100;
            //b1.Breadth = 100;
            //b1.Height = 100;

            //int len1 = b1.Length;
            //int bre1 = b1.Breadth;
            //int hei1 = b1.Height;

            //int vol = len1*bre1*hei1;
            //Console.WriteLine("The volume is " + vol);
            //Console.ReadKey();

            //Rectangle r1 = new Rectangle();
            //r1.Length = 100;
            //r1.Breadth = 100;

            //double len1 = r1.Length;
            //double bre1 = r1.Breadth;

            //double area = len1 * bre1;
            //double perimeter = 2 * (len1 + bre1);
            //Console.WriteLine("The area is " + area);
            //Console.WriteLine("The perimeter is "+perimeter);
            //Console.ReadKey();

            //Student student = new Student();
            //student.setPerson(21,"Radib","Bhatapur");
            //student.displayPerson();

            //student.setStd("CSIT", "E-");
            //student.displayStudent();

            //Console.WriteLine("--eg on base keyword");
            //solution sol1= new solution();
            //solution sol2= new solution(10,5,20,30);
            //sol2.calcsum();
            //sol2.Calcdiff();

            //Answer a1 = new Answer();
            //a1.calc1();
            //a1.calc2(50,20);

            //Answer1 an1 = new Answer1(40,50);
            //an1.displaySum();
            //an1.displayDiv();
            //an1.displayDiff(50, 40);
            //an1.displayMulti(10,5);

            //ExceptionHandling e1 = new ExceptionHandling();
            //e1.setData();

            //CustomException ce1 = new CustomException();
            //ce1.sendAge(21);

            //Question1 q1 = new Question1(2, 3, 4);
            //q1.getMax();
            //Console.ReadLine();

            //Console.WriteLine("--eg in interface--");
            //InterfaceDemo ids = new InterfaceDemo();
            //ids.calcSum(20, 30);
            //ids.calcMulti(20, 5);
            //ids.calcDiv(20,10);
            
            ////dynamic method dispatch;when subclass's object is assigned to reference variable of superclass then such reference will call the
            ////subclass version of overriden method
            //Calc1 c; //ref variable
            //c = ids;
            //c.calcSum(20, 30);
            //c.calcMulti(20, 5);

            FileHandlingDemo fh = new FileHandlingDemo();
            fh.writeFile();
            fh.readFile();
           
        }
    }
}
