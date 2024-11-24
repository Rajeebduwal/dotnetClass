using System;


namespace rajibProject
{
     class Solve
    {
        public virtual void calc1()
        {
            Console.WriteLine("default method of super class");
        }

        public virtual void calc2(int x, int y) { 
            Console.WriteLine("The sum is "+(x+y)); 
        }
    }

    class Answer: Solve
    {
        public override void calc1()
        {
            base.calc1(); //calling method of parent
            Console.WriteLine("default method of child class");
        }

        public override void calc2(int x, int y)
        {
            base.calc2(x, y); //calling method of parent
            Console.WriteLine("The difference is " + (x - y));
        }
    }
}
