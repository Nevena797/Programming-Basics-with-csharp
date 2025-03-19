int number = int.Parse(Console.ReadLine());

//2^0,2^2,2^4,2^n
// 0,2,4,n
for (int i = 0; i <= number; i += 2)
{
    Console.WriteLine(Math.Pow(2,i)); // 1<<i
}

//int number = int.Parse(Console.ReadLine());
//int power = 1;
//2^0,2^2,2^4,2^n
// 0,2,4,n
//for (int i = 0; i <= number; i += 2)
//{
//    Console.WriteLine(power);

//}


//int number = int.Parse(Console.ReadLine());

//2^0,2^2,2^4,2^n
// 0,2,4,n
//for (int i = 0, power = 1; i <= number; i += 2, power *=4)
//{
//    Console.WriteLine(power);
//}

