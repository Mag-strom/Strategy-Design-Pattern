using System.Diagnostics;
//using System.Numerics;
using TravellStrategy;
using TravellStrategy.TravellingStrategies;
namespace Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner Planner = new TravelPlanner();
            string? temp = null;
            Planner.SetTravelStartegy(new Car());
            temp = temp + Planner.Drive(1000);
            Planner.SetTravelStartegy(new Plane());
            temp = temp + Planner.Drive(1000);
            Planner.SetTravelStartegy(new Train());
            temp = temp + Planner.Drive(1000);
            Console.WriteLine(temp);

            string? temp1 = null;
            Planner.SetTravelStartegy(new Car());
            temp1 = temp1 + Planner.Drive(50);
            
            Planner.SetTravelStartegy(new Plane());
            temp1 = temp1 + Planner.Drive(50);
            Planner.SetTravelStartegy(new Train());
            temp1 = temp1 + Planner.Drive(50);
            Console.WriteLine(temp1);
        }
    }
}