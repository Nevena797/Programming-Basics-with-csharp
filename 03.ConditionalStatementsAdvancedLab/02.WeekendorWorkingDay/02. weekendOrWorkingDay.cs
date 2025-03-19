string dayOfWeek = Console.ReadLine();
switch (dayOfWeek)
{
    case "Monday":
            break;
    case "Tuesday":
        break;
    case "Wensday":
        break;
    case "Friday":
        Console.WriteLine("Working day");
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Error");
        break;
}