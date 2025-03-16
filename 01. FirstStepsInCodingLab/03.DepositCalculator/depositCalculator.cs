double depositАmount = double.Parse(Console.ReadLine());
int depositMonts = int.Parse(Console.ReadLine());
double yearPercent = double.Parse(Console.ReadLine());


double persentPerYear = depositАmount * (yearPercent / 100);
double montsAmount = persentPerYear / 12;
double totalSum = depositАmount + depositMonts*(montsAmount);

Console.WriteLine(totalSum);