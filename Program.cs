using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Craig South African Lotto Number Generator\n");

        Random random = new Random();

        // Generate 6 unique numbers
        int[] lottoNumbers = new int[6];
        for (int i = 0; i < lottoNumbers.Length; i++)
        {
            int number;
            do
            {
                number = random.Next(1, 50); // 1 to 49 inclusive
            } while (Array.Exists(lottoNumbers, x => x == number));

            lottoNumbers[i] = number;
        }

        // Generate bonus ball (different from the 6 numbers)
        int bonusBall;
        do
        {
            bonusBall = random.Next(1, 50);
        } while (Array.Exists(lottoNumbers, x => x == bonusBall));

        // Display results
        Console.WriteLine("Your Lotto Numbers:");
        foreach (int num in lottoNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine($"\nBonus Ball: {bonusBall}");

        Console.WriteLine("\nGood luck!");
        Console.ReadKey();
    }
}