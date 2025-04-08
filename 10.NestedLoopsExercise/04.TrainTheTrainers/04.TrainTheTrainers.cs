namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberJuges = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double totalScore = 0;
            int totalPresentations = 0;

            while (command != "Finish")
            {
                double currentNote = 0;

                for (int i = 1; i <= numberJuges; i++)
                {
                    double notes = double.Parse(Console.ReadLine());
                    currentNote += notes;
                }

                double averageScore = currentNote / numberJuges;
                Console.WriteLine($"{command} - {averageScore:F2}.");

                totalScore += averageScore;
                totalPresentations++;

                command = Console.ReadLine();
            }

            double finalAssessment = totalScore / totalPresentations;
            Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
        }
    }
}
