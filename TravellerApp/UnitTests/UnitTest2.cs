using TravellStrategy.TravellingStrategies;
using TravellStrategy;

namespace UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            TravelPlanner Planner = new ();
           
            string? temp1 = null;
            Planner.SetTravelStartegy(new Car());
            temp1 += Planner.Drive(50);

            Planner.SetTravelStartegy(new Plane());
            temp1   += Planner.Drive(50);
            Planner.SetTravelStartegy(new Train());
            temp1 += Planner.Drive(50);

            Assert.AreEqual("cost of drive Car : 2000cost of drive Plane : 5000cost of drive Train : 1500", temp1);


        }
    }
}
