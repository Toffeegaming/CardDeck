namespace Cas
{
    public class IoHandler
    {
        public int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public string GetString()
        {
            return Console.ReadLine();
        }

        public void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
