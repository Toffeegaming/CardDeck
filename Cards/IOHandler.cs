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
            string input = Console.ReadLine() ?? "";
            return int.Parse(input == string.Empty ? "0" : input);
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