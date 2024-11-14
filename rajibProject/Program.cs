using System;
using System.Runtime.CompilerServices;

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

            Student student = new Student();
            student.setPerson(21,"Radib","Bhatapur");
            student.displayPerson();

            student.setStd("CSIT", "E-");
            student.displayStudent();

        }
    }
}
