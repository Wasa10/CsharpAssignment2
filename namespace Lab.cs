namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Subject :");
            int i;
            i = int.Parse(Console.ReadLine());
            for (int j=0; j < i; j++)
            {
                Console.WriteLine("Enter your Mark");
                int Mark;
                Mark = int.Parse(Console.ReadLine());
                if (Mark < 0)
                {
                    Console.WriteLine("Error");
                }
                else if (Mark <= 35)
                {
                    Console.WriteLine("F");
                }
                else if (Mark <= 45)
                {
                    Console.WriteLine("D");
                }
                else if (Mark <= 65)
                {
                    Console.WriteLine("C");
                }
                else if (Mark <= 80)
                {
                    Console.WriteLine("B");
                }
                else if (Mark <= 100)
                {
                    Console.WriteLine("A");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}