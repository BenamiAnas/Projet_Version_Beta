using Projet_Version_Beta;

namespace Projet_Version_Beta_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new WeatherForecast();

            test.Date = DateOnly.MaxValue;
            test.Summary = "Summary";

            Assert.AreEqual(DateOnly.MaxValue, test.Date);
        }
    }
}