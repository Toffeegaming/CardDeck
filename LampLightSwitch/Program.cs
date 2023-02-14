namespace LampLightSwitch
{
    internal class Program
    {
        static void Main()
        {
            Lightswitch buttonSwitch1 = new Lightswitch();

            Lamp ledLamp1 = new Lamp(buttonSwitch1);

            ledLamp1.ShowStatus();

            buttonSwitch1.Toggle();

            Lamp ledLamp2 = new Lamp(buttonSwitch1);

            ledLamp1.ShowStatus();
            ledLamp2.ShowStatus();
        }
    }
}