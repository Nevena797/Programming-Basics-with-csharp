//int i = 0;
//while (i <= 5)
//{
//    Console.WriteLine("SoftUni");
//    i++;
//}- 6 x SoftUni

//int i = 0;
//while (i == 0)
//{
//    Console.WriteLine("SoftUni");
//    if (i == 1)
//        break;
//} do not stop write SoftUni

//int i = 0;
//while (i < 6)
//{
//    i++;
//    if (i % 2 == 0)
//        Console.Write(i);
//} //246

//for (int h = 0; h <= 23; h++)
//{
//    for (int m = 0; m <= 59; m++)
//    {
//        Console.WriteLine($"{h}:{m}");
//    }
//}

//for (int i = 0; i < 24; i++) //
//{
//    for (int j = 0; j < 60; j++)
//    {
//        Console.WriteLine($"{i:D2}:{j:D2}");
//    }
//}

//for (int x = 1; x <= 10; x++)
//{
//    for (int y = 1; y <= 10; y++)
//    {
//        int product = x * y;
//        Console.WriteLine($"{x} * {y} = {product}");
//    }
//}

//bool flag = false;
//for (int i = 0; i < n; i++)
//    for (int j = 0; j < n; j++)
//        if (condition)
//            flag = true;
//break;
//if (flag)
//    break;

//for (int i = 1; i < 10; i++)
//{
//    bool shoudBreak = false;
//    for (int j = 5; j < 10; j++)
//    {
//        if (i == 4 && j == 7)
//        {
//            shoudBreak = true;
//            break;
//        }

//        Console.WriteLine($"i = {i}, j ={j}");
//    }
//    if (shoudBreak) { break; }
//}