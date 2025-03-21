int maxBadGrades = int.Parse(Console.ReadLine());
string lastProblem = "";

int goodGrades = 0;
int totalGrades = 0;
int badGrades = 0;
string problemName = "";
bool areProblemsSolved = true;

while ((problemName= Console.ReadLine()) != "Enough")
{
    int grade = int.Parse(Console.ReadLine());
    totalGrades += grade;
    goodGrades++;
    lastProblem = problemName;

    if (grade <= 4 && ++badGrades == maxBadGrades)
    {
            areProblemsSolved = false;
            break;
    }
}

//false ->!false -> true
//true->!true -> false

if (areProblemsSolved)
{
    Console.WriteLine($"Average score: {(double)totalGrades / goodGrades:f2}");
    Console.WriteLine($"Number of problems: {goodGrades}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
else
{
    Console.WriteLine($"You need a break, {badGrades} poor grades.");
}