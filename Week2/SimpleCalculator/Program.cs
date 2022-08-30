// See https://aka.ms/new-console-template for more information

try
{
    Console.Write("Enter a: ");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter b: ");
    var b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter one operator(+ - * /): ");
    var op = Console.ReadLine();

    switch (op)
    {
        case "+":
            Console.WriteLine("a + b = " + (a + b));
            break;
        case "-":
            Console.WriteLine("a - b = " + (a - b));
            break;
        case "*":
            Console.WriteLine("a * b = " + (a * b));
            break;
        case "/":
            Console.WriteLine("a / b = " + (a / b));
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}