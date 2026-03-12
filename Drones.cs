public class Drones(string droneName, int maxLaps, int delayMs)
{
    public void StartLaps()
    {
        for (int i = 0; i < maxLaps; i++)
        {
            Console.WriteLine($"{droneName} has finished lap {i+1}/{maxLaps}");
            Thread.Sleep(delayMs);
        }
    }
}