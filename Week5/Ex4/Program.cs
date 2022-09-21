namespace Ex4
{
    class Person
    {
        private string _name;
        private int _yob;
        private string _degree;

        public Person()
        {
        }

        public Person(string name, int yob, string degree)
        {
            _name = name;
            _yob = yob;
            _degree = degree;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }

        public string Degree
        {
            get => _degree;
            set => _degree = value ?? throw new ArgumentNullException(nameof(value));
        }

        public virtual int TotalSalary()
        {
            throw new NotImplementedException();
        }

        public virtual void Input()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Year of Birth: ");
            int yob = int.Parse(Console.ReadLine());

            Console.Write("Degree: ");
            string degree = Console.ReadLine();

            Name = name;
            Yob = yob;
            Degree = degree;
        }

        public virtual string Show()
        {
            return $"Name: {Name}, Year of Birth: {Yob}, Degree: {Degree}";
        }
    }

    class Manager : Person
    {
        private string _position;
        private int _noWorkingDays;
        private int _salaryScale;

        public string Position
        {
            get => _position;
            set => _position = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int NoWorkingDays
        {
            get => _noWorkingDays;
            set => _noWorkingDays = value;
        }

        public int SalaryScale
        {
            get => _salaryScale;
            set => _salaryScale = value;
        }

        public Manager()
        {
        }

        public Manager(string name, int yob, string degree, string position, int noWorkingDays, int salaryScale) : base(
            name, yob, degree)
        {
            _position = position;
            _noWorkingDays = noWorkingDays;
            _salaryScale = salaryScale;
        }

        public override int TotalSalary()
        {
            return NoWorkingDays * SalaryScale;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Position: ");
            string position = Console.ReadLine();

            Console.Write("Number of Working Days in Month: ");
            int noWorkingDays = int.Parse(Console.ReadLine());

            Console.Write("Salary Scale: ");
            int salaryScale = int.Parse(Console.ReadLine());

            Position = position;
            NoWorkingDays = noWorkingDays;
            SalaryScale = salaryScale;
        }

        public override string Show()
        {
            return
                $"{base.Show()}, Position: {Position}, Number of Working Days: {NoWorkingDays}, Salary Scale: {SalaryScale}, Total Salary: {TotalSalary()}";
        }
    }

    class Scientist : Manager
    {
        private int _noPaper;

        public int NoPaper
        {
            get => _noPaper;
            set => _noPaper = value;
        }

        public Scientist()
        {
        }

        public Scientist(string name, int yob, string degree, string position, int noWorkingDays, int salaryScale,
            int noPaper) : base(name, yob, degree, position, noWorkingDays, salaryScale)
        {
            _noPaper = noPaper;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Number of Scientific Paper: ");
            int noPaper = int.Parse(Console.ReadLine());

            NoPaper = noPaper;
        }

        public override string Show()
        {
            return $"{base.Show()}, Number of Scientific Paper: {NoPaper}";
        }
    }


    class Staff : Person
    {
        private int _salary;

        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public Staff()
        {
        }

        public Staff(string name, int yob, string degree, int salary) : base(name, yob, degree)
        {
            _salary = salary;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Total Salary: ");
            Salary = int.Parse(Console.ReadLine());
        }

        public override string Show()
        {
            return $"{base.Show()}, Total Salary: {Salary}";
        }
    }

    internal class MainProgram
    {
        public void Input(int n, List<Person> list)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Type of employee (1. Manager, 2. Scientist, 3. Staff): ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Manager manager = new Manager();
                        manager.Input();
                        list.Add(manager);
                        break;
                    case 2:
                        Scientist scientist = new Scientist();
                        scientist.Input();
                        list.Add(scientist);
                        break;
                    case 3:
                        Staff staff = new Staff();
                        staff.Input();
                        list.Add(staff);
                        break;
                }
            }
        }

        public static void Main(string[] args)
        {
            MainProgram mainProgram = new MainProgram();
            
            Console.Write("Enter number of employee: ");
            int n = int.Parse(Console.ReadLine());
            
            List<Person> list = new List<Person>();
            mainProgram.Input(n, list);
            
            int totalSalaryManager = 0;
            int totalSalaryScientist = 0;
            int totalSalaryStaff = 0;

            foreach (var person in list)
            {
                Console.WriteLine(person.Show());
                switch (person.GetType().Name)
                {
                    case "Manager":
                        totalSalaryManager += person.TotalSalary();
                        break;
                    case "Scientist":
                        totalSalaryScientist += person.TotalSalary();
                        break;
                    case "Staff":
                        totalSalaryStaff += ((Staff)person).Salary;
                        break;
                }
            }

            Console.WriteLine($"Total Salary of Manager: {totalSalaryManager}");
            Console.WriteLine($"Total Salary of Scientist: {totalSalaryScientist}");
            Console.WriteLine($"Total Salary of Staff: {totalSalaryStaff}");
        }
    }
}