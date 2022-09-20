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