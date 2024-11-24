using System;

namespace rajibProject
{
    class ExceptionHandling
    {
        public void setData()
        {
            Console.Write("Enter first number: ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y1 = Int32.Parse(Console.ReadLine());
            try
            {
                int res = x1 / y1; //if y1 = 0 then error occurrs
                Console.WriteLine("The division is " + res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The denominator should not be 0 " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR! Occurred " + ex);
            }
            finally {
                Console.WriteLine("Always Executed");
            }

        }
    }
}
