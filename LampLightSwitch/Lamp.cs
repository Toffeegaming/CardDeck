namespace LampLightSwitch
{
    public class Lamp
    {
        private readonly Lightswitch _lightswitch;

        private bool _on => _lightswitch.On;

        public Lamp(Lightswitch lightswitch)
        {
            _lightswitch = lightswitch;
            Console.WriteLine($"Constructed new {this}");
        }


        public void ShowStatus()
        {
            Console.WriteLine($"Lamp state is {_on}");
        }
    }
}
