int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int roomVolume = width * lenght * height;

string input = "";
while ((input = Console.ReadLine()) != "Done")
{
    int volumeTakenByBoxes = int.Parse(input);
    roomVolume -= volumeTakenByBoxes;

    if (roomVolume < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(roomVolume)} Cubic meters more.");
        return;
    }

}
Console.WriteLine($"{roomVolume} Cubic meters left.");