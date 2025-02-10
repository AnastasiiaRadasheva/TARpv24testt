class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("sisesta summ:");
        if (int.TryParse(Console.ReadLine(), out int amount) && amount > 0)
        {
            CalculateCoins(amount);
        }
        else
        {
            Console.WriteLine("palun kirju ei ole 0.");
        }
    }

    static void CalculateCoins(int amount)
    {
        int[] coins = { 50, 20, 10, 5, 2, 1 }; 

        Console.WriteLine("min cent:");
        foreach (int coin in coins)
        {
            int count = amount / coin;
            if (count > 0)
            {
                Console.WriteLine($"{coin}-cent: {count} tk");
                amount %= coin;
            }

        }
    }
}
