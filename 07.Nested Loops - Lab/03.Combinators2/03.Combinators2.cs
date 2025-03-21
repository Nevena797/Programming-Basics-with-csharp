int n = int.Parse(Console.ReadLine());

int count = 0;//O(n^2)

for (int i = 0; i <= n; i++) //Iterates over all posible values for x1
{
    count += n - i + 1;
}
Console.WriteLine(count);