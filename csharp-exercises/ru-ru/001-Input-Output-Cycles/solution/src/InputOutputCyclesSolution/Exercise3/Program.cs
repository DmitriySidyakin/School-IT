Console.WriteLine("Введите N от 0 до 100.");
long N = -1;
do
{
    Console.Write("Введите N: ");
}
while (!(long.TryParse(Console.ReadLine(), out N) && N >= 0 && N <= 100));

Console.WriteLine($"Числа от 0 до {N}: ");
for (int i = 0; i <= N; i++)
    Console.Write(i.ToString() + (i != N ? ", " : "\n"));
Console.ReadLine();