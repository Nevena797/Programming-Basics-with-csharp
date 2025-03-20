int n = int.Parse(Console.ReadLine());


int g1 = 0, g2 = 0, g3= 0, g4 = 0, g5 = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        g1++;
    }
    else if (number < 400)
    {
        g2++;
    }
    else if (number < 600)
    {
        g3++;
    }
    else if (number < 800)
    {
        g4++;
    }
    else // (number >= 800)
    {
        g5++;
    }
}

double p1 = g1 / (double)n;
double p2 = g2 / (double)n;
double p3 = g3 / (double)n;
double p4 = g4 / (double)n;
double p5 = g5 / (double)n;

Console.WriteLine($"{p1 * 100:f2}%");
Console.WriteLine($"{p2 * 100:f2}%");
Console.WriteLine($"{p3 * 100:f2}%");
Console.WriteLine($"{p4 * 100:f2}%");
Console.WriteLine($"{p5 * 100:f2}%");

