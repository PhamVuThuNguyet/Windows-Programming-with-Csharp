namespace Ex2
{
    class Student
    {
        public string _sid { get; private set; }
        public string _name { get; private set; }
        public string _faculty { get; private set; }
        public float _gpa { get; private set; }

        public Student(string sid, string name, string faculty, float gpa)
        {
            _sid = sid;
            _name = name;
            _faculty = faculty;
            _gpa = gpa;
        }

        public override string ToString()
        {
            return $"Student ID: {_sid}, Name: {_name}, Faculty: {_faculty}, GPA: {_gpa}";
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

            Student student = new Student(sid, name, faculty, gpa);

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