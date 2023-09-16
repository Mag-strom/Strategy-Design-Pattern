using System.Diagnostics;
//using System.Numerics;
using TravellStrategy;
using TravellStrategy.TravellingStrategies;
namespace Travel
{
    internal class Program
    {
        static void Main( )
        {
            TravelPlanner Planner = new ();
            string? temp = null;
            Planner.SetTravelStartegy(new Car());
            temp +=  Planner.Drive(1000);
            Planner.SetTravelStartegy(new Plane());
            temp += Planner.Drive(1000);
            Planner.SetTravelStartegy(new Train());
            temp +=  Planner.Drive(1000);
            Console.WriteLine(temp);

            string? temp1 = null;
            Planner.SetTravelStartegy(new Car());
            temp1 += Planner.Drive(50);
            
            Planner.SetTravelStartegy(new Plane());
            temp1 += Planner.Drive(50);
            Planner.SetTravelStartegy(new Train());
            temp1 += Planner.Drive(50);
            Console.WriteLine(temp1);
        }
    }
}
