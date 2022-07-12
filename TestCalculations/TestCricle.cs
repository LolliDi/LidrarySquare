using LidrarySquare;

namespace TestCalculations
{
    [TestClass]
    public class TestCricle
    {
        [TestMethod]
        public void Cricle_Radius3_28f2743()
        {
            double answer = 28.2743;
            Assert.AreEqual(answer, Math.Round(CalculateSquare.Cricle(3),4));
        }

        [TestMethod]
        public void Cricle_Radius2_12f5664()
        {
            double answer = 12.5664;
            Assert.AreEqual(answer, Math.Round(CalculateSquare.Cricle(2), 4)); // сразу округляем полученое число до десятитысячных
        }

        [TestMethod]
        public void Cricle_RadiusMinus3_0()
        {
            double answer = 0;
            Assert.AreEqual(answer, CalculateSquare.Cricle(-3));
        }
    }
}