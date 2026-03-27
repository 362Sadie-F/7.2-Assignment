namespace _7._2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Enter your message and I'll type it 5 times: ");
            string message = Console.ReadLine();

            for (int i = 1; i <=5; i = i + 1)
            {
                Console.WriteLine(i + ". " + message);
            }
            Console.ReadLine();
            Console.Clear();

            //task 1 Counting down "Blast Off!"
            Console.WriteLine("Counting Down!");

            for (int i = 10; i >= 0; i = i - 1)
            {
                Console.WriteLine(i + "... ");
            }
            Console.WriteLine("Blast Off!");
            Console.ReadLine();
            Console.Clear();

            //task 2 X & Y
            Console.WriteLine("\t X ");
            for (int i = -10; i <=10; i = i +2)
            {
                Console.WriteLine("\t" + i + "\t");
            } 
            Console.WriteLine("\t Y ");
            for (int y = -100; y <= 100; y = y + 16)
            {
                Console.WriteLine("\t" + y + "\t");
            }

            //task 3 For Loop Fun
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            for (int n = 1; n <= 10; n = n + 1)
            {
                Console.WriteLine(n + ". " + name);
            }
            if (name == "Aldworth" )
            {
                
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
