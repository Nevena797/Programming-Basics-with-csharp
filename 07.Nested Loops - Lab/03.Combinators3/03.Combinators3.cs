int n = int.Parse(Console.ReadLine());

int count = 0;//O(n^2)

for (int i = 0; i <= n; i++) //Iterates over all posible values for x1
{
    for (int j = 0; j <= n - i; j++) //Iterates over all posible values for x2
    {
        count++;
    }
}
Console.WriteLine(count);