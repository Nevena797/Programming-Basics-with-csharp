int bookSite = int.Parse(Console.ReadLine());
int sitePerhour = int.Parse(Console.ReadLine());
int dayToRead = int.Parse(Console.ReadLine());

int totalHours = bookSite / sitePerhour;
int totalHoursPerDay = totalHours/ dayToRead;
Console.WriteLine(totalHoursPerDay);