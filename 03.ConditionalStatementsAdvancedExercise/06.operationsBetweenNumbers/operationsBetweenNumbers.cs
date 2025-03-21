double numberOne = int.Parse(Console.ReadLine());
double numberTwo = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());
double result = 0;
string parity = "";

switch (operation)
{
    case '+':
        if ((numberOne + numberTwo) % 2 == 0)
        {
            parity = "even";
        }
        else
        {
            parity = "odd";
        }
        result = numberOne + numberTwo;
        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {parity}");
        break;
    case '-':
        if ((numberOne - numberTwo) % 2 == 0)
        {
            parity = "even";
        }
        else
        {
            parity = "odd";
        }
        result = numberOne - numberTwo;
        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {parity}");
        break;
    case '*':
        if ((numberOne * numberTwo) % 2 == 0)
        {
            parity = "even";
        }
        else
        {
            parity = "odd";
        }
        result = numberOne * numberTwo;
        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {parity}");
        break;
    case '/':
        if (numberTwo == 0)
        {
            Console.WriteLine($"Cannot divide {numberOne} by zero");
        }
        else
        {
            result = numberOne / numberTwo;
            Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result:f2}");
        }
        break;
    case '%':
        if (numberTwo == 0)
        {
            Console.WriteLine($"Cannot divide {numberOne} by zero");
        }
        else
        {
            result = numberOne % numberTwo;
            Console.WriteLine($"{numberOne} % {numberTwo} = {result}");
        }
        break;
}



