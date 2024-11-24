using System;


namespace rajibProject
{
     abstract class Question
    {
        private int x;
        private int y;
        
        public Question(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void displaySum()
        {
            Console.WriteLine("The sum is "+(x+y));
        }

        public abstract void displayDiff(int x, int y);
        public abstract void displayMulti(int x, int y);

    }

    class Answer1 : Question { 

        private int x1;
        private int y1;

        public Answer1(int x1, int y1):base(x1,y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public void displayDiv()
        {
            Console.WriteLine("The division is " +(x1/y1));
        }
        public override void displayDiff(int x, int y)
        {
            Console.WriteLine("The difference is " + (x - y));
        }
        public override void displayMulti(int x, int y)
        {
            Console.WriteLine("The division is " + (x * y));
        }

    }
}
