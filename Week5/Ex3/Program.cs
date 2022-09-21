using System.Collections;

namespace Ex3
{
    class People
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public People(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }

    class Student : People
    {
        private string _sid;
        private string _faculty;
        private float _gpa;

        public string Sid
        {
            get => _sid;
            set => _sid = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Faculty
        {
            get => _faculty;
            set => _faculty = value ?? throw new ArgumentNullException(nameof(value));
        }

        public float Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        public Student(string name, string sid, string faculty, float gpa) : base(name)
        {
            _sid = sid;
            _faculty = faculty;
            _gpa = gpa;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Student ID: {Sid}, Faculty: {Faculty}, GPA: {Gpa}";
        }
    }

    internal class Tester
    {
        public Student InputOneStudent()
        {
            Console.Write("Enter Student ID: ");
            var sid = Console.ReadLine();
            Console.Write("Enter Student Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Student Faculty: ");
            var faculty = Console.ReadLine();
            Console.Write("Enter Student GPA: ");
            var gpa = float.Parse(Console.ReadLine());

            Student student = new Student(name, sid, faculty, gpa);

            return student;
        }

        public void InputStudentList(int n, List<Student> students)
        {
            for (int i = 0; i < n; i++)
            {
                Student student = InputOneStudent();
                students.Add(student);
            }
        }

        public void ShowStudentList(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Main(string[] args)
        {
            Tester tester = new Tester();

            Console.Write("Enter number of students: ");
            var n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            tester.InputStudentList(n, students);

            tester.ShowStudentList(students);
        }
    }
};