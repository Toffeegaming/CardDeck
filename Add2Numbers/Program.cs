using Cas;

namespace Add2Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IoHandler io = new IoHandler();
            io.Print("Voer een getal in: ");
            int number1 = io.GetInt();
            io.Print("Voer een getal in: ");
            int number2 = io.GetInt();
            io.Print(Calculator.Add(number1, number2));
        }
    }
}