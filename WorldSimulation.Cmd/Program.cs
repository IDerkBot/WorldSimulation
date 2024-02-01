namespace WorldSimulation.Cmd;

public static class Program
{
    public static void Main()
    {
        var worker = new Work();

        worker.Run();
    }
}