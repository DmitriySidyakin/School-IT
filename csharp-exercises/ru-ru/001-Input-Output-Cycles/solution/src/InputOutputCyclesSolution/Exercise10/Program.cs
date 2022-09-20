bool notFound = true;
for(int y = 0; y < 10 && notFound; y++)
    for (int d = 0; d < 10 && notFound; d++)
        for (int a = 0; a < 10 && notFound; a++)
            for (int r = 0; r < 10 && notFound; r++)
                for (int k = 0; k < 10 && notFound; k++)
                {
                    if (k == 0 && d == 0 && a == 0 && r == 0 && k == 0)
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
