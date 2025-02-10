namespace ptogramm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("insert frist number and press enter: ");
            //string tuleb konvertida int andmetüübiks
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("insert second number and press enter: ");
            //string tuleb konvertida int andmetüübiks
            float secondNr = float.Parse(Console.ReadLine());


            Console.WriteLine("insert calculation type by number");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int calculationType = int.Parse(Console.ReadLine());

            float result = 0;

            if (calculationType == 1)
            {
                result = firstNr + secondNr;
                Console.WriteLine("Answer: ");
                Console.WriteLine(firstNr + " + " + secondNr + " = " + result);
            }
            else
            if (calculationType == 2)
            {
                result = firstNr - secondNr;
                Console.WriteLine("Answer: ");
                Console.WriteLine(firstNr + " - " + secondNr + " = " + result);
            }
            else 
            if (calculationType == 3)
            {
                result = firstNr * secondNr;
                Console.WriteLine("vastus: ");
                Console.WriteLine(firstNr + " * " + secondNr + " = " + result);
            }
            else 
            if (calculationType == 4)
            {
                if (secondNr != 0)
                {
                    result = firstNr / secondNr;
                    Console.WriteLine("vastus: ");
                    Console.WriteLine(firstNr + " / " + secondNr + " = " + result);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}