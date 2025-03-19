using System;

double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double secondsPerMeter = double.Parse(Console.ReadLine());

double delay = 12.5;

double newRecordtime = distance * secondsPerMeter;
double timesSlowedDown= Math.Floor(distance / 15);
double finalTime = newRecordtime + (timesSlowedDown * delay);


if (finalTime < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
    
}
else
{
    Console.WriteLine($"No, he failed! He was {finalTime-record:f2} seconds slower.");
}
