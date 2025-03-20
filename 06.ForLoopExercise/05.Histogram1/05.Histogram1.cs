int n = int.Parse(Console.ReadLine());


int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200) g1++;
    else if (number < 400) g2++;
    else if (number < 600) g3++;
    else if (number < 800) g4++;
    else g5++;// (number >= 800)

}

double p1 = 100.0 * g1 / n;
double p2 = 100.0 * g2 / n;
double p3 = 100.0 * g3 / n;
double p4 = 100.0 * g4 / n;
double p5 = 100.0 * g5 / n;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");