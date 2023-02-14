namespace KozijnRaam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frame yellowFrame = new Frame(4,"yellow");
            Frame redFrame = new Frame(4, "red");
            Frame blueFrame = new Frame(4, "blue");

            yellowFrame.ShowWindows();
            redFrame.ShowWindows();
            blueFrame.ShowWindows();
        }
    }
}