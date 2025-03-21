int n = int.Parse(Console.ReadLine());

int count = 0;// O(n^3)

for (int i = 0; i <= n; i++) // (n+1) * (n+1) *(n+1) iteration
{
    for (int j = 0; j <= n; j++) //(n+1) * (n +1) iterations
    {
        for (int k = 0; k <= n; k++) // n+1 iterations
        {
            if (i + j + k == n)
            {
                count++;
            }
        }
    }
}
Console.WriteLine(count);