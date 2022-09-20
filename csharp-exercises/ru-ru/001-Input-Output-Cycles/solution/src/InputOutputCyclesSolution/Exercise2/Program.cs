Console.WriteLine("Введите два целых числа a и b.");
long a;
do {
    Console.Write("Введите a: ");
}
while (!long.TryParse(Console.ReadLine(), out a));
long b;
do
{
    Console.Write("Введите b: ");
}
while (!long.TryParse(Console.ReadLine(), out b));
Console.WriteLine($"Сумма a и b: {a + b}");
Console.ReadLine();