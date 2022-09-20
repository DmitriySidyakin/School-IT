long N = -1;
do
{
    Console.Write("Введите целое не отрицательное число: ");
}
while (!(long.TryParse(Console.ReadLine(), out N) && N >= 0));

Console.WriteLine("Обратный порядок цифр: ");
string stringN = N.ToString();
for (int i = stringN.Length - 1; i >= 0; i--)
    Console.Write(stringN[i]);

Console.WriteLine();
Console.ReadLine();

