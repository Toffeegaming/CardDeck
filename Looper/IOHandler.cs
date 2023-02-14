using System.Runtime.CompilerServices;

namespace Looper
{
    public sealed class IoHandler
    {
        private static IoHandler _instance;

        private IoHandler()
        {
        }

        public static IoHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IoHandler();
                }

                return _instance;
            }
        }

        public int GetInt()
        {
            return int.Parse(Console.ReadLine() ?? string.Empty);
        }

        public string GetString()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        public void Print(string input)
        {
            Console.Write(input);
        }

        public void PrintLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}