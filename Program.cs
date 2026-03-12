
class Program
{
    static void Main(string[] args)
    {
        Drones droneBilly = new("Billy", 5, 100);
        Drones droneRobert = new("Robert", 5, 150);
        Drones droneEpicFury = new("Epic Fury", 5, 80);

        droneBilly.StartLaps();
        droneRobert.StartLaps();
        droneEpicFury.StartLaps();
    }
}