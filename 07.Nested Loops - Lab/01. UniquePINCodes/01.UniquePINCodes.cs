int limit1 = int.Parse(Console.ReadLine());  
int limit2  = int.Parse(Console.ReadLine());
int limit3 = int.Parse(Console.ReadLine());

//Iterates over all possible values for the first digit
for (int i = 2; i <= 8; i+= 2)
{
    if (i > limit1) { break; }

    //Iterates over all possible values for the second digit
    for (int j = 2; j <= 7; j++)
    {
        if (j > limit2) { break; }
        if (j == 4 || j == 6) { continue; }

        //Iterates over all possible values for the third digit
        for (int k = 2; k <= 8; k += 2)
        {
            if (k > limit3) { break; }

            Console.WriteLine($"{i} {j} {k}");
        }
    }
}