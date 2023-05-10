[Главная](https://dmitriysidyakin.github.io/School-IT/) >> [Упражнения](https://dmitriysidyakin.github.io/School-IT/csharp-exercises/ru-ru/)

# Ввод-вывод в консольных приложениях и циклы

## Решение *Упражнения 1* 

Сделайте ввод имени пользователя. Сделайте вывод сообщения "Привет, имя пользователя!".

Решение на C#:

```cs
Console.Write("Введите имя пользователя: ");
string? name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.ReadLine();
```

## Решение *Упражнения 2*

Напишите консольное приложение запрашивающее два целых числа и выводящее их сумму.

Решение на C#:

```cs
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
```

## Решение *Упражнения 3*

Организуйте ввод целого числа N, от 0 (нуля) до 100 (ста). Сделайте цикл вывода всех целых до числа N [0;N].

Решение на C#:

```cs
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
```

## Решение *Упражнения 4*

Сделайте ввод  целого числа N, от 0 (нуля) до 10 (десяти). Сделайте вычисление факториала для числа N. Факториал числа N — это произведение всех целых чисел от него до 1. Факториал нуля равен 1.

Решение на C#:

```cs
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
```

## Решение *Упражнения 5*

Введите целое не отрицательное число в программу. Выведите инвертированный порядок цифр в этом числе.

Решение на C#:

```cs
long N = -1;
do
{
    Console.Write("Введите целое не отрицательное число: ");
}
while (!(long.TryParse(Console.ReadLine(), out N) && N >= 0));

Console.WriteLine("Обратный порядок цифр: ");
string stringN = N.ToString();
for(int i = stringN.Length - 1; i >= 0; i--)
    Console.Write(stringN[i]);

Console.WriteLine();
Console.ReadLine();
```

## Решение *Упражнения 6*

Введите целое не отрицательное число в программу. Выведите сколько целый десятков в нём содержится.

Решение на C#:

```cs
long N = -1;
do
{
    Console.Write("Введите целое не отрицательное число: ");
}
while (!(long.TryParse(Console.ReadLine(), out N) && N >= 0));

Console.WriteLine($"Количество десятков: {N / 10}");
Console.ReadLine();
```

## Решение *Упражнения 7*

Пусть есть прямоугольник со сторонами **a** и **b**. Напишите программу, которая вычисляет площадь прямоугольника со сторонами **a** и **b**.

Решение на C#:

```cs
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
```

## Решение *Упражнения 8*

Пусть у нас есть целое положительное число N. Выведите следующие чётное число за ним. При написании решения для этой задачи нельзя использовать условную инструкцию **if** и циклы.

Решение на C#:

```cs
long N = -1;
do
{
    Console.Write("Введите целое положительное число: ");
}
while (!long.TryParse(Console.ReadLine(), out N));

Console.WriteLine($"Целое чётное число следующее за ним: {(N / 2) * 2 + 2}");
Console.ReadLine();
```

## Решение *Упражнения 9*

Создайте 4 переменные с разными типами данных и предложите пользователю ввести в них значения. После ввода, отобразите их на экране.

Решение на C#:

```cs
Console.WriteLine("Введите переменную типа int: ");
int @int = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите переменную типа char: ");
char @char = char.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите переменную типа string: ");
string @string = Console.ReadLine() ?? "";

Console.WriteLine("Введите переменную типа float: ");
float @float = float.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Вы ввели:");
Console.WriteLine(@int);
Console.WriteLine(@char);
Console.WriteLine(@string);
Console.WriteLine(@float);
```

## Решение *Упражнения 10*

Напишите программу для решения уравнения:

![Искомые переменные в уравнении](../img/task.svg)

Каждая буква в уравнении представляет собой неизвестную цифру. Одна и та же буква представляет собой одну цифру. Решите задачу полным перебором с помощью вложенных циклов.

Решение на C#:

```cs
bool notFound = true;
for(int y = 0; y < 10 && notFound; y++)
    for (int d = 0; d < 10 && notFound; d++)
        for (int a = 0; a < 10 && notFound; a++)
            for (int r = 0; r < 10 && notFound; r++)
                for (int k = 0; k < 10 && notFound; k++)
                {
                    if (y == 0 && d == 0 && a == 0 && r == 0 && k == 0)
                        continue;

                    int ydar = y * 1000 + d * 100 + a * 10 + r;
                    int draka = d * 10000 + r * 1000 + a * 100 + k * 10 + a;
                    if ((ydar + ydar) == draka)
                    {
                        Console.WriteLine($"У = {y}, Д = {d}, А = {a}, Р = {r}, К = {k}");
                        notFound = false;
                    }
                    
                }
Console.ReadLine();
```

