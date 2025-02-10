namespace count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int one = 1, two = 2, five = 5, ten = 10, twenty = 20, fifty = 50;
            Console.WriteLine("Enter sum and press enter:");
            int sum = int.Parse(Console.ReadLine()); 
            int centAmount = 0;
            if (sum >= fifty)
            {
                centAmount = sum / fifty;
                sum = sum % fifty;
                Console.WriteLine("50 cent: " + centAmount);
            }

            if (sum >= twenty)
            {
                centAmount = sum / twenty;
                sum = sum % twenty;
                Console.WriteLine("20 cent: " + centAmount);
            }

            if (sum >= ten)
            {
                centAmount = sum / ten;
                sum = sum % ten;
                Console.WriteLine("10 cent: " + centAmount);
            }

            if (sum >= five)
            {
                centAmount = sum / five;
                sum = sum % five;
                Console.WriteLine("5 cent: " + centAmount);
            }


            if (sum > 0)
            {
                Console.WriteLine("ostatok " + sum + " cent");
            }
            else
            {
                Console.WriteLine("bez ostatka");
            }
        }
    }
}