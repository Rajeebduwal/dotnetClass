//Create a class number with 3 integer variable x, y and z. The class will have one constructor to initialize one variable and method
//getMax() that returns largest number among three, getPrime() method that prints prime number from x t0 y. Now create an object of
//number class and demonstrate above scenario.

using System;


namespace rajibProject
{
    class Question1
    {
        private int x;
        private int y;
        private int z;

        public Question1(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void getMax()
        {
            if(x>y && y > z)
            {
                Console.WriteLine("The largest number is " + x);
            }
            else if (y>x && y > z)
            {
                Console.WriteLine("The maximum number is "+y);
            }
            else
            {
                Console.WriteLine("The maximum number is " + z);
            }
        }
        
        public void getPrime()
        {

        }
    }
}
