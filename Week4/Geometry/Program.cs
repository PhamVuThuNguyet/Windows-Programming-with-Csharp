namespace Geometry
{
    class Point
    {
        private float _x;
        private float _y;

        public Point(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public float X
        {
            get => _x;
            set => _x = value;
        }

        public float Y
        {
            get => _y;
            set => _y = value;
        }
    }

    abstract class Shape
    {
        protected Point[] Points;

        protected int no_points;

        protected Shape(int noPoints)
        {
            no_points = noPoints;
            Points = new Point[noPoints];
        }

        public virtual void Input()
        {
            for (var i = 0; i < no_points; i++)
            {
                Console.WriteLine($"Input Points {i + 1}");
                Console.Write("X: ");
                var x = float.Parse(Console.ReadLine());
                Console.Write("Y: ");
                var y = float.Parse(Console.ReadLine());
                Points[i] = new Point(x, y);
            }
        }

        public void Move(float delta_x, float delta_y, Point p)
        {
            p.X += delta_x;
            p.Y += delta_y;
        }

        public void Show()
        {
            Console.WriteLine(ToString());
        }

        public abstract string ToString();
    }

    class Lines : Shape
    {
        public Lines(int noPoints) : base(noPoints)
        {
        }

        public override string ToString()
        {
            var s = "";
            for (var i = 0; i < no_points; i++)
            {
                s += $"p{i + 1}: ({Points[i].X}, {Points[i].Y})\n";
            }

            return s;
        }
    }

    class Circles : Shape
    {
        private float _radius;

        public float Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public Circles(int noPoints) : base(noPoints)
        {
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Radius: ");
            Radius = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"center: ({Points[0].X}, {Points[0].Y}), radius: {Radius}";
        }
    }

    class Rectangles : Shape
    {
        public Rectangles(int noPoints) : base(noPoints)
        {
        }

        public override string ToString()
        {
            var s = "";
            for (var i = 0; i < no_points; i++)
            {
                s += $"p{i + 1}: ({Points[i].X}, {Points[i].Y})\n";
            }

            return s;
        }
    }

    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lines:");
            Shape line = new Lines(2);
            line.Input();
            ((Lines)line).Show();

            Console.WriteLine("\nCircle");
            Shape circle = new Circles(1);
            ((Circles)circle).Input();
            ((Circles)circle).Show();

            Console.WriteLine("\nRectangle");
            Shape rect = new Rectangles(3);
            ((Rectangles)rect).Input();
            ((Rectangles)rect).Show();
        }
    }
}