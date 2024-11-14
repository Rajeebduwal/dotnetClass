using System;

namespace rajibProject
{
    class Box
    {

        private int length;
        private int breadth;
        private int height;

        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public int Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }
        public int Height
        {
            set { height = value; }
            get { return height; }
        }

    }
}

//Create a class rectangle having instance variable length and breadth both in double type.
//Now create properties for it and calculate perimeter and area in main method