
class Program
{
    static async Task Main(string[] args)
    {
        Drones drone1 = new("Billy", 5, 100);
        Drones drone2 = new("Robert", 5, 150);
        Drones drone3 = new("Epic Fury", 5, 80);

        /*
        drone1.StartLaps();
        drone2.StartLaps();
        drone3.StartLaps();
        */

        try
        {
            await Task.WhenAll(
                drone1.StartLapsAsync(),
                drone2.StartLapsAsync(),
                drone3.StartLapsAsync()
            );
            Console.WriteLine("All drones complete");
        } catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong during the race!\nError message:{ex.Message}");
        }
    }
}