using Microsoft.SqlServer.Server;
using System;
//Interface is like a abstract class but it contains only list of abstract method. Multiple Inheritance is possible using interface 
//1. Its object cannot be created.
//2. It olny contains list of abstract method( no constructor, method, fixed instance variable)
// 3. It is used to achieve dynamic polymorphism and multiple inheritance
//4. Normal class have to inherit interface and must provide implementation of all the method define in interface

namespace rajibProject
{
        interface Calc1
        {
            //list of abstract method (no body part)
            void calcSum(int x, int y);
            void calcMulti(int x, int y);
        }
        interface Calc2
        {
            void calcDiv(int x, int y);
        }
        class  InterfaceDemo: Calc1,Calc2  //Multiple Inheritance condition
        {
            public void calcSum(int x, int y)
            {
                Console.WriteLine("Sum is "+(x+y));
            }
            public void calcMulti(int x, int y)
            {
                Console.WriteLine("Multi is " + (x * y));
            }
            public void calcDiv(int x,int y)
            {
                Console.WriteLine("Division is " + (x / y));
            }
        }
}
