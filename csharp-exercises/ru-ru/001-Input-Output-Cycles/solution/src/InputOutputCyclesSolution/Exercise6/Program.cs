long N = -1;
do
{
    Console.Write("Введите целое не отрицательное число: ");
}
while (!(long.TryParse(Console.ReadLine(), out N) && N >= 0));

Console.WriteLine($"Количество десятков: {N / 10}");
Console.ReadLine();

