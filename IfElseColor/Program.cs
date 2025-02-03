namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värv (võimalused: red, blue, green, white):");
            string input = Console.ReadLine()?.ToLower();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Sa ei sisestanud värvi. Palun proovi uuesti.");
            }
            else 
            if (input == "red")
            {
                Console.WriteLine("Sa valisid punase värvi.");
            }
            else
            
            if (input == "blue")
            {
                Console.WriteLine("Sa valisid sinise värvi.");
            }
            else 

            if (input == "green")
            {
                Console.WriteLine("Sa valisid rohelise värvi.");
            }
            else 

            if (input == "white")
            {
                Console.WriteLine("Sa valisid valge värvi.");
            }
            else
            {
                Console.WriteLine("Sisestatud värv ei ole toetatud.");
            }
        }
    }
}

