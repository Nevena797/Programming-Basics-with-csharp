using System.Runtime.CompilerServices;

double pricePens = 5.80;
double priceMarkers = 7.20;
double priceCleaner = 1.20;

int amountPens = int.Parse(Console.ReadLine());
int amountMarkers = int.Parse(Console.ReadLine());
int cleanerInLiter = int.Parse(Console.ReadLine()); 
double discount = int.Parse(Console.ReadLine());

double sumePens = pricePens * amountPens;
double sumeMarkers = priceMarkers * amountMarkers;
double sumeCleaner = priceCleaner * cleanerInLiter;
double totalSume = sumePens + sumeMarkers + sumeCleaner;
double totalDiscount = discount / 100;
double totalSumeAfterDiscount = totalSume - (totalSume * totalDiscount);

Console.WriteLine(totalSumeAfterDiscount);