int length = int.Parse(Console.ReadLine());  
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine()); 
double persentage = double.Parse(Console.ReadLine());

int volumeSquareMeter = length * width * height;
double volumeLiter = volumeSquareMeter * 0.001;
double persentageNoWater = persentage * 0.01; // 100 persentage
double freeVolume = volumeLiter * persentageNoWater;
double neededVolume = volumeLiter - freeVolume;
Console.WriteLine(neededVolume);