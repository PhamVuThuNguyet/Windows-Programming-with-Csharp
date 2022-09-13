using System;

namespace StudentManagement // Note: actual namespace depends on the project name.
{

    class Person
    {
        private int age;
        private string name;
        
        public Person(){}

        public Person(int _age)
        {
            age = _age;   
        }

        public Person(int _age, string _name)
        {
            age = _age;
            name = _name;
        }

        public void DisplayPerson()
        {
            Console.WriteLine(toString());
        }

        public void Input()
        {
            Console.Write("Input name: ");
            string _name = Console.ReadLine();
            setName(_name);
            
            Console.Write("Input age: ");
            int _age = int.Parse(Console.ReadLine());
            setAge(_age);
        }

        private void setName(string _name)
        {
            name = _name;
        }

        private void setAge(int _age)
        {
            age = _age;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public string toString()
        {
            return "Name: " + getName() + "\nAge: " + getAge();
        }
    }

    class Student: Person
    {
        private float gpa;
        
        public Student(){}

        public Student(float _gpa)
        {
            gpa = _gpa;
        }

        public void Input()
        {
            base.Input();
            Console.Write("Enter GPA: ");
            float _gpa = float.Parse(Console.ReadLine());
            setGpa(_gpa);
        }

        public void DisplayStudent()
        {
            base.DisplayPerson();
            Console.WriteLine("GPA: " + getGpa());
        }

        private void setGpa(float _gpa)
        {
            gpa = _gpa;
        }

        public float getGpa()
        {
            return gpa;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Input();
            student.DisplayStudent();
        }
    }
}