//1.
//int a = 5;
//switch (a)
//{
//    case 5:
//    case 6:
//        a = a + 1;
//        break;
//    default:
//        a = a + 2;
//        break;
//}

//2.
//Console.WriteLine(!(5 == 5) && (4 + 1 == 5));
//3.Console.WriteLine(!(3 == 3) || (3 == 5));
//4.Console.WriteLine(!(3 > 5) || (1 == 1));
//5.int number = 101;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//if (number >= 1)
//{
//    Console.WriteLine("Larger than 1");
//}
//if (number <= 101)
//{
//    Console.WriteLine("Less than 101");
//    Console.WriteLine("Equal to 101");
//}
//Преговор
//Equal to 101
//Larger than 1
//Less than 101
//6.string role = "Administrator";
//using System.Data;

//string password = "SoftUni";
//if (role == "SoftUni")
//{
//    if (password == "SoftUni")
//    {
//        Console.WriteLine("Welcome!");
//    }
//}

//int number = int.Parse(Console.ReadLine());

//double sqrt = -1;

//if (number >= 1)
//{
//    sqrt = Math.Sqrt(number);
//}
//Console.WriteLine(sqrt);

//int x = 10;
//x = x + 1;
//x += 1;
//x++; // postfix incrementation


//int a = 1;
//Console.WriteLine(++a);
//Console.WriteLine(a);

//int a = 1;
//Console.WriteLine(a++);
//Console.WriteLine(a);

//int a = 1;
//Console.WriteLine(--a);
//Console.WriteLine(a);

//int a = 1;
//Console.WriteLine(a--);
//Console.WriteLine(a);

//int a = 5;
//Console.WriteLine(++a); //6
//Console.WriteLine(a);//6

//int a = 5;
//Console.WriteLine(a++);//5
//Console.WriteLine(a);//6

//int C = 3;
//Console.WriteLine(C++ + ++C);//8!!!
//1.Execute c++
//-> c = 4;
//-> 3 + ++c
//2.Execute ++c
//-> c = 5
//-> 3 + 5

//int C = 1;
//Console.WriteLine(C++ + C++);//3

//int c = 1;
//Console.WriteLine(++c + ++c);//5

//int c = 1;
//Console.WriteLine(++c + c++); // 4


//using System.Xml.Schema;

//int x = 0;
//x = x + 1;
//x += 1;
//x++;

//for (int i = 1; i <= 12; i += 1)
//{
//    Console.WriteLine(i);
//}

//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{ if (i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i+=2)
//{
//    Console.WriteLine(i);
//}

//for (int i = 1; i <= n; i += 2)
//{
//if
//switch(...)
// for (...)
// Console.WriteLine(i);
//}

//string text = "SoftUni";
//int length = text.Length;
//Console.WriteLine(length);


//string text = "SoftUni";
//char letter = text[4]; // U
//Console.WriteLine(letter);

//using System.Diagnostics.Metrics;

//string text = "SoftUni";
//// 0,1,2...,text.Length - 1
//// text.Lenght ->7
////0,1,2,3,4,5,6
//// i < text.Lenght
////is equivalent to
//// i<=text.Length -1

//for (int i = 0; i < text.Length; i++)
//{
//    Console.WriteLine(text[i]);
//}


