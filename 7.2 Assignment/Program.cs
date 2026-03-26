namespace _7._2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

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


            //task 3 For Loop Fun



            Console.WriteLine();
        }
    }
}
