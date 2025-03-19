using System.ComponentModel.Design;

double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();

string title = "";

if (gender == "f")
{
    if (age < 16)
    {
        title = "Miss";
    }
    else
    {
        title = "Ms.";
    }
}
else if (gender == "m")
{
    if (age < 16)
    {
        title = "Master";
    }
    else
    {
        title = "Mr.";
    }
}

Console.WriteLine(title);
