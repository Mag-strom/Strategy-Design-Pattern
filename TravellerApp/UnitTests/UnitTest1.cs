using TravellStrategy.TravellingStrategies;
using TravellStrategy;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TravelPlanner Planner = new TravelPlanner();
            string? temp = null; 
            Planner.SetTravelStartegy(new Car());
            temp= temp +Planner.Drive(1000);
            Planner.SetTravelStartegy(new Plane());
            temp= temp +Planner.Drive(1000);
            Planner.SetTravelStartegy(new Train());
            temp= temp +Planner.Drive(1000);
            Assert.AreEqual("cost of drive Car : 15000cost of drive Plane : 45000cost of drive Train : 10000", temp);
            string? temp1 = null;
            Planner.SetTravelStartegy(new Car());
            temp1 = temp1 + Planner.Drive(50);

            Planner.SetTravelStartegy(new Plane());
            temp1 = temp1 + Planner.Drive(50);
            Planner.SetTravelStartegy(new Train());
            temp1 = temp1 + Planner.Drive(50);
            
            Assert.AreEqual("cost of drive Car : 2000cost of drive Plane : 5000cost of drive Train : 1500", temp1);


        }
    }
}