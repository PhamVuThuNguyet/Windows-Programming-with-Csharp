// See https://aka.ms/new-console-template for more information

var num = 0;
do
{
    Console.Write("Insert an integer that equals or bigger than 2: ");
    try
    {
        num = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
} while (num < 2);

var primes = new int[500001];

void SieveOfEratosthenes(int n)
{
    primes[0] = 1;
    for (var i = 3; i * i <= n; i += 2)
    {
        if (primes[i / 2] != 0) continue;
        for (var j = 3 * i; j <= n; j += 2 * i)
            primes[j / 2] = 1;
    }
}

SieveOfEratosthenes(10000);

if ((num == 2) || ((num % 2 == 1) && (primes[num / 2] == 0)))
{
    Console.WriteLine("Prime");
    Environment.Exit(0);
}

Console.WriteLine("Not Prime");