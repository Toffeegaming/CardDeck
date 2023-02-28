namespace Cas
{
    public sealed class IoHandler // lazy singleton
    {
        private static IoHandler? _instance;

        private IoHandler() {}

        public static IoHandler Instance => _instance ??= new IoHandler();
        /*
         *  Instance
         *  {
         *      get
         *      {
         *          if (_instance == null)
         *          {
         *              _instance = new IoHandler();
         *          }
         *          return _instance;
         *      }
         *  }
         */

        public int GetInt()
        {
            return int.TryParse(Console.ReadLine(), out var result) ? result : 0;
        }

        public bool GetBool()
        {
            return bool.TryParse(Console.ReadLine(), out var result) && result;
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