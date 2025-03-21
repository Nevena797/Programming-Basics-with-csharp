int n = int.Parse(Console.ReadLine());

// i = 0 -> n+1
// i = 1->n
// i = 2->n -1
// ..........
// i = n -> 1

int count = (n + 1) * (n + 2) / 2; // o(1)

Console.WriteLine(count);