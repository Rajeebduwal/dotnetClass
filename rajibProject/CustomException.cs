using System;


namespace rajibProject
{
    class AgeError:Exception
    {
        public AgeError(string message) : base(message) {}
    }
     class CustomException
    {
        public void sendAge(int age)
        {
            if(age <= 16)
            {
                throw new AgeError("Age should be greater than 16");
            }
            else
            {
                Console.WriteLine("Welcome to bhatapur");
            }
        }
    }
}
