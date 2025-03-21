double numberOne = double.Parse(Console.ReadLine());
double numberTwo = double.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());
double result = 0;
string parity = "";

switch (operation)
{
    case '+':
        result = numberOne + numberTwo;
        parity = (result % 2 == 0) ? "even" : "odd";
        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {parity}");
        break;
    case '-':
        result = numberOne - numberTwo;
        parity = (result % 2 == 0) ? "even" : "odd";
        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {parity}");
        break;
    case '*':
        result = numberOne * numberTwo;
        parity = (result % 2 == 0) ? "even" : "odd";
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
    default:
        Console.WriteLine("Invalid operation");
        break;
}
