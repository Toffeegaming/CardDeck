using Console = System.Console;

namespace LampLightSwitch
{
    public class Lightswitch
    {
        public Lightswitch()
        {
            _on = false;
            Height = 10;
            Width = 5;

            Console.WriteLine($"Constructed new {this}");
        }

        private bool _on;

        public bool On => _on;

        public int Height;

        public int Width;

        public void Toggle()
        {
            _on = !_on;
        }

        public void ShowStatus() { Console.WriteLine($"Button state is {_on}"); }
    }
}
