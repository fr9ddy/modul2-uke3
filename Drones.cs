using System.Diagnostics;

public class Drones(string droneName, int maxLaps, int delayMs)
{
    /*
    public void StartLaps()
    {

        Stopwatch timer = Stopwatch.StartNew();

        for (int i = 0; i < maxLaps; i++)
        {
            Console.WriteLine($"{droneName} has finished lap {i+1}/{maxLaps}");
            Thread.Sleep(delayMs);
        }

        timer.Stop();
        
        Console.WriteLine($"Total time elapsed on all laps completed:\n{droneName}: {timer.ElapsedMilliseconds}ms");
    }
    */

    public async Task StartLapsAsync()
    {
        Stopwatch timer = Stopwatch.StartNew();
        
        for (int i = 0; i < maxLaps; i++)
        {
            Console.WriteLine($"{droneName} completed lap {i+1}/{maxLaps}");
            await Task.Delay(delayMs);
        }
        timer.Stop();
        Console.WriteLine($"Total time elapsed: {timer.ElapsedMilliseconds}ms");
    }
}