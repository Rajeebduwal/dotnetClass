using System;
using System.Security.Cryptography.X509Certificates;
//consturctor of superclass(parent) cannot be called from subclass's object.So to call superclass cosntructor "base" keyword is used 
//Uses of base keyword:
//1.to call superclass cosntructor
//2.method overriding

namespace rajibProject
{
    class Calculation
    {
        private int x1;
        private int y1;
        //default constructor of parent
        public Calculation()
        {
            Console.WriteLine("default cons of super class");
        }
        public Calculation(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public void calcsum()
        {
            Console.WriteLine("Sum is " +(x1+y1));
        }
    }
    class solution : Calculation
    {
        public int x2;
        public int y2;
        //default constructor of child class
        public solution()
        {
            Console.WriteLine("default const of sub class");
        }
        public solution(int x2, int y2,int x1,int y1):base(x1,y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public void Calcdiff()
        {
            Console.WriteLine("Difference is " + (x2 - y2));
        }
    }
}
