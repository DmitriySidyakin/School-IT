long N = -1;
do
{
    Console.Write("Введите целое положительное число: ");
}
while (!long.TryParse(Console.ReadLine(), out N));

Console.WriteLine($"Целое чётное число следующее за ним: {(N / 2) * 2 + 2}");
Console.ReadLine();

