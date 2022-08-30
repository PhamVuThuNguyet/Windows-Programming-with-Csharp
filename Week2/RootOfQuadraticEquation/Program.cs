// See https://aka.ms/new-console-template for more information

double x1, x2;

Console.Write("Input the value of a : ");
var a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the value of b : ");
var b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the value of c : ");
var c = Convert.ToInt32(Console.ReadLine());

double d = b * b - 4 * a * c;
switch (d)
{
    case 0:
        Console.WriteLine("Both roots are equal.");
        x1 = -b / (2.0 * a);
        x2 = x1;
        Console.WriteLine("First  Root Root1= {0}", x1);
        Console.WriteLine("Second Root Root2= {0}", x2);
        break;
    case > 0:
        Console.WriteLine("Both roots are real and different");

        x1 = (-b + Math.Sqrt(d)) / (2 * a);
        x2 = (-b - Math.Sqrt(d)) / (2 * a);

        Console.WriteLine("First  Root Root1= {0}", x1);
        Console.WriteLine("Second Root root2= {0}", x2);
        break;
    default:
        Console.WriteLine("Root are imaginary. No Solution");
        break;
}