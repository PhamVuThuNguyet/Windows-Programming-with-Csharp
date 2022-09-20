namespace Ex1
{
    class Student
    {
        private string _sid;
        private string _name;
        private string _faculty;
        private float _gpa;

        public Student(string sid, string name, string faculty, float gpa)
        {
            _sid = sid;
            _name = name;
            _faculty = faculty;
            _gpa = gpa;
        }

        public string Sid
        {
            get => _sid;
            set => _sid = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
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

        public override string ToString()
        {
            return $"Student ID: {Sid}, Name: {Name}, Faculty: {Faculty}, GPA: {Gpa}";
        }
    }

    internal class Tester
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            var n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
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
                
                students.Add(student);
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
};

