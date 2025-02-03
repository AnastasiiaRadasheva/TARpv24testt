namespace IfElseFootSIze1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write size");
            int size = int.Parse(Console.ReadLine());
            if (size >= 30 && size <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Small size");
            }
            else if (size >= 34 && size <= 38)
            {
                Console.ResetColor();
                Console.WriteLine("Medium size");
            }
            else if (size >= 39 && size <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Large size");
            }
            else if (size >= 45 && size <= 48)
            {
                Console.Beep();
                Console.WriteLine("Jalanumber on vahemikus 45 kuni 48.");
            }
            else
            {
                Console.WriteLine("Jalanumber ei kuulu määratud vahemikku.");
            }
        }
    }
}
