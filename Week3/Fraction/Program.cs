namespace Fraction
{
    class Fraction
    {
        private int _numerator { get; set; }
        private int _denominator { get; set; }

        public List<Fraction> Input()
        {
            List<Fraction> fractions = new List<Fraction>();

            Console.WriteLine("Enter fraction 1: ");
            Console.Write("Enter numerator: ");
            var numerator1 = int.Parse(Console.ReadLine());
            var denominator1 = 0;
            do
            {
                Console.Write("Enter denominator: ");
                denominator1 = int.Parse(Console.ReadLine());
            } while (denominator1 == 0);

            Fraction a = new Fraction
            {
                _numerator = numerator1,
                _denominator = denominator1
            };
            fractions.Add(a);

            Console.WriteLine("Enter fraction 2: ");
            Console.Write("Enter numerator: ");
            var numerator2 = int.Parse(Console.ReadLine());
            var denominator2 = 0;
            do
            {
                Console.Write("Enter denominator: ");
                denominator2 = int.Parse(Console.ReadLine());
            } while (denominator2 == 0);

            Fraction b = new Fraction()
            {
                _numerator = numerator2,
                _denominator = denominator2
            };
            fractions.Add(b);

            return fractions;
        }

        public int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        public Fraction Add(Fraction a, Fraction b)
        {
            Fraction fraction;
            int gcd;
            if (a._denominator == b._denominator)
            {
                fraction = new Fraction()
                {
                    _numerator = a._numerator + b._numerator,
                    _denominator = a._denominator
                };
                gcd = GCD(fraction._numerator, fraction._denominator);
                return new Fraction()
                {
                    _numerator = fraction._numerator / gcd,
                    _denominator = fraction._denominator / gcd
                };
            }

            int lcm = LCM(a._denominator, b._denominator);
            fraction = new Fraction()
            {
                _numerator = a._numerator * (lcm / a._denominator) + b._numerator * (lcm / b._denominator),
                _denominator = lcm
            };

            gcd = GCD(fraction._numerator, fraction._denominator);
            return new Fraction()
            {
                _numerator = fraction._numerator / gcd,
                _denominator = fraction._denominator / gcd
            };
        }

        public Fraction Subtract(Fraction a, Fraction b)
        {
            Fraction fraction;
            int gcd;
            if (a._denominator == b._denominator)
            {
                fraction = new Fraction()
                {
                    _numerator = a._numerator - b._numerator,
                    _denominator = a._denominator
                };
                gcd = GCD(fraction._numerator, fraction._denominator);
                return new Fraction()
                {
                    _numerator = fraction._numerator / gcd,
                    _denominator = fraction._denominator / gcd
                };
            }

            int lcm = LCM(a._denominator, b._denominator);
            fraction = new Fraction()
            {
                _numerator = a._numerator * (lcm / a._denominator) - b._numerator * (lcm / b._denominator),
                _denominator = lcm
            };
            gcd = GCD(fraction._numerator, fraction._denominator);
            return new Fraction()
            {
                _numerator = fraction._numerator / gcd,
                _denominator = fraction._denominator / gcd
            };
        }

        public Fraction Multiply(Fraction a, Fraction b)
        {
            return new Fraction()
            {
                _numerator = a._numerator * b._numerator,
                _denominator = a._denominator * b._denominator
            };
        }

        public Fraction Divide(Fraction a, Fraction b)
        {
            return new Fraction()
            {
                _numerator = a._numerator * b._denominator,
                _denominator = a._denominator * b._numerator
            };
        }

        public void DisplayAsDecimal()
        {
            Console.WriteLine((double)_numerator / _denominator);
        }

        public void DisplayNormal()
        {
            Console.WriteLine(_numerator + "/" + _denominator);
        }
    }

    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();
            List<Fraction> fractions = fraction.Input();
            Fraction addFraction = fraction.Add(fractions[0], fractions[1]);
            addFraction.DisplayNormal();
            addFraction.DisplayAsDecimal();
        } 
    }
}