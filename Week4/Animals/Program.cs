namespace Animals
{
    abstract class Animal
    {
        protected string Type;
        protected string Name;

        protected Animal(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public abstract string Voice();

        public virtual string Info()
        {
            return "type: " + Type + "\nname: " + Name;
        }
    }

    class Dog : Animal
    {
        private string _breed;

        public Dog(string type, string name, string breed) : base(type, name)
        {
            _breed = breed;
        }

        public override string Voice()
        {
            return "Woof Woof";
        }

        public override string Info()
        {
            return base.Info() + "\nbreed: " + _breed;
        }
    }

    class Cat : Animal
    {
        public Cat(string type, string name) : base(type, name)
        {
        }

        public override string Voice()
        {
            return "Meow Meow";
        }

        public void Climb(string thing)
        {
            Console.WriteLine("Climbing " + thing);
        }
    }

    class Duck : Animal
    {
        public Duck(string type, string name) : base(type, name)
        {
        }

        public override string Voice()
        {
            return "Quack Quack";
        }

        public void Swim(string thing)
        {
            Console.WriteLine("Swimming in " + thing);
        }
    }


    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog("mammal", "Gou", "Spaniel");
            Console.WriteLine(dog.Voice());
            Console.WriteLine(dog.Info());

            Animal cat = new Cat("mammal", "Meoww");
            Console.WriteLine(cat.Voice());
            Console.WriteLine(cat.Info());
            ((Cat)cat).Climb("tree");

            Animal duck = new Duck("bird", "Quackkk");
            Console.WriteLine(duck.Voice());
            Console.WriteLine(duck.Info());
            ((Duck)duck).Swim("pond");
        }
    }
}