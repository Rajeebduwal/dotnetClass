using System;
//inheritance is the concept of inheriting

namespace rajibProject
{
    class Person
    {
        private int age;
        private string name;
        private string address;

        public void setPerson(int age, string name, string address)
        {
            this.age = age;
            this.name = name;
            this.address = address;
        }
        public void displayPerson()
        {
            Console.WriteLine("The age of " + name + " who lives in " + address + " is " + age);
        }
    }

    class Student : Person
    {
        private string faculty;
        private string grade;

        public void setStd(string faculty, string grade)
        {
            this.faculty = faculty;
            this.grade = grade;
        }

        public void displayStudent()
        {
            Console.WriteLine("The grade is " + grade + " of student of " + faculty + " faculty");
        }
    }
}
