
class Program
{
    static void Main(string[] args)
    {
        Drones drone1 = new("Billy", 5, 100);
        Drones drone2 = new("Robert", 5, 150);
        Drones drone3 = new("Epic Fury", 5, 80);

        /*
        drone1.StartLaps();
        drone2.StartLaps();
        drone3.StartLaps();
        */

        Task t1 = Task.Run(() => drone1.StartLaps());
        Task t2 = Task.Run(() => drone2.StartLaps());
        Task t3 = Task.Run(() => drone3.StartLaps());

        Task.WaitAll(t1, t2, t3);
        Console.WriteLine($"All drones complete");
    }
}