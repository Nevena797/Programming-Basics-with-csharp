string geometricFigure = Console.ReadLine();

if (geometricFigure == "square")
{
    float side = float.Parse(Console.ReadLine());
    float area = side * side;
    Console.WriteLine(area);
}
else if (geometricFigure == "rectangle")
{
    float firstSide = float.Parse(Console.ReadLine());
    float secondSide = float.Parse(Console.ReadLine());
    float area = firstSide * secondSide;
    Console.WriteLine(area);
}
else if (geometricFigure == "circle")
{
    float radius = float.Parse(Console.ReadLine());
    float area = (float)Math.PI * radius * radius;
    Console.WriteLine(area);
}
else if (geometricFigure == "triangle")
{
    float side = float.Parse(Console.ReadLine());
    float height = float.Parse(Console.ReadLine());
    float area = (side * height) / 2;
    Console.WriteLine(area);
}