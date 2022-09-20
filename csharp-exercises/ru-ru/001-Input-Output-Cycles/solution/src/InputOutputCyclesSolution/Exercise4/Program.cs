Console.WriteLine("Введите N от 0 до 10.");

int N = -1;
do
{
    Console.Write("Введите N: ");
}
while (!(int.TryParse(Console.ReadLine(), out N) && N >= 0 && N <= 10));

Console.WriteLine($"Факториал N: {Factorial(N)}");

static long Factorial(int n)
{
    if (n == 0)
        return 1;

    long result = 1;

    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }

    return result;
}