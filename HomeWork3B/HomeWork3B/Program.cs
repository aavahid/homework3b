int total = 0; // 1

Console.WriteLine("Neçə ədəd girəcəksiniz? "); // 1
int sum  = Convert.ToInt32(Console.ReadLine()); // 1

for (int i = 1; i <= sum; i++) // n
{
	Console.Write($"{i}. ədəd : "); // 1
	int x = Convert.ToInt32(Console.ReadLine()); // 1
	total += x; // 1
}

double average = (double)total / sum; // 1

Console.WriteLine("Ortalama: " + average); // 1

// 1 + 1 + 1 + n + 1 + 1 + 1 + 1 + 1 = 8 + n = O(n)