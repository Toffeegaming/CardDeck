namespace Stemrecht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Votechecker assignment = new Votechecker();

            Console.Write("Wat is je leeftijd? ");
            int input = Int32.Parse(Console.ReadLine());
            assignment.Run(input);
        }
    }
}