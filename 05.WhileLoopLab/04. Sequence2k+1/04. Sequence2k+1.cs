int n = int.Parse(Console.ReadLine());

//int currentNumber = 1;

//while (currentNumber <= n)
//{
//    Console.WriteLine(currentNumber);
//    currentNumber = currentNumber * 2 + 1;
//}

for (int i = 1; i <= n; i = i * 2 + 1)
{
    Console.WriteLine(i);
}