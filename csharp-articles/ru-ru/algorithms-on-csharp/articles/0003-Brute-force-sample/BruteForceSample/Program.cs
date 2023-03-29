// See https://aka.ms/new-console-template for more information
Console.WriteLine("Test Brute Force...");

BruteForceSample.BruteForce bruteForce = new BruteForceSample.BruteForce("0123456789ABC", new[] { 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 12,12,12,12,12,12,12,12} );

do
{
    string current = bruteForce.Current;

    Console.WriteLine(current);

    bruteForce.MoveNext();

} while (bruteForce.HasNext());