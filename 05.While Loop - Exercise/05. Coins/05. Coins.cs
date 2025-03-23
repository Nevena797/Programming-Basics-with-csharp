double change = double.Parse(Console.ReadLine());
double changeInPennies = Math.Floor(change * 100);

//2,1,50,20,10,5,2,1
//123->123-100=23->23-20=3->3-2=1->1-1=0
int coins = 0;
while (changeInPennies>0)
{
    if (changeInPennies >= 200) changeInPennies -= 200;
    else if (changeInPennies >= 100) changeInPennies -= 100;
    else if (changeInPennies >= 50) changeInPennies -= 50;
    else if (changeInPennies >= 20) changeInPennies -= 20;
    else if (changeInPennies >= 10) changeInPennies -= 10;
    else if (changeInPennies >= 5) changeInPennies -= 5;
    else if (changeInPennies>=2) changeInPennies -= 2;
    else if (changeInPennies>=1) changeInPennies -=1;
    coins++;
}
Console.WriteLine(coins);