Console.WriteLine("Введите длины сторон прямоугольника a и b.");
long a;
do
{
    Console.Write("Введите a: ");
}
while (!long.TryParse(Console.ReadLine(), out a));
long b;
do
{
    Console.Write("Введите b: ");
}
while (!long.TryParse(Console.ReadLine(), out b));
Console.WriteLine($"Площадь прямоугольника: {a * b}");
Console.ReadLine();