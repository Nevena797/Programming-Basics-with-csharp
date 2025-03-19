string text = Console.ReadLine();

int sum = 0;
for (int i = 0; i < text.Length; i++)
{
    char currentSymbol = text[i];
    int points = 0; 
    if (currentSymbol == 'a') { points = 1;}
    else if (currentSymbol == 'e') {points= 2;}
    else if (currentSymbol == 'i') {points = 3;}
    else if (currentSymbol == 'o') {points= 4;}
    else if (currentSymbol == 'u') {points= 5;}

    sum += points; 
}
Console.WriteLine(sum);