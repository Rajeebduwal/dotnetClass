using System;


namespace rajibProject
{
    class Vehicle
    {
        private int reg;
        private string name;
        private string brand;

        public void setvehicle(int reg, string name, string brand)
        {
            this.reg = reg;
            this.name = name;
            this.brand = brand;
        }
        public void displayVehicle()
        {
            Console.WriteLine("The vehicle " + name + " of brand " + brand + " has reg number " + reg);
        }
    }
}
