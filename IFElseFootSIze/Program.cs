namespace IFElseFootSIze
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sisesta jalanumber:");
        int jalanumber = int.Parse(Console.ReadLine());

        if (jalanumber >= 30 && jalanumber <= 33)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jalanumber on vahemikus 30 kuni 33.");
        }
        else if (jalanumber >= 34 && jalanumber <= 38)
        {
            Console.ResetColor();
            Console.WriteLine("Jalanumber on vahemikus 34 kuni 38.");
        }
        else if (jalanumber >= 39 && jalanumber <= 44)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jalanumber on vahemikus 39 kuni 44.");
            Console.ResetColor();
        }
        else if (jalanumber >= 45 && jalanumber <= 48)
        {
            Console.Beep();
            Console.WriteLine("Jalanumber on vahemikus 45 kuni 48.");
        }
        else
        {
            Console.WriteLine("Jalanumber ei kuulu määratud vahemikku.");
        }

        Console.ResetColor();
    }
}