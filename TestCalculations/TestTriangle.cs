using LidrarySquare;

namespace TestCalculations
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void Triangle_Side345_Answer6()
        {
            double answer = 6;
            Assert.AreEqual(answer, CalculateSquare.Triangle(3, 4, 5));
        }

        [TestMethod]
        public void Triangle_Side3410_Answer0()
        {
            double answer = 0f;
            Assert.AreEqual(answer, CalculateSquare.Triangle(3, 4, 10));
        }

        [TestMethod]
        public void Triangle_SideMinus145_Answer0()
        {
            double answer = 0;
            Assert.AreEqual(answer, CalculateSquare.Triangle(-1, 4, 5));
        }

        [TestMethod]
        public void IsRightTriangle_SideMinus345_AnswerTrue() //прямоугольный или нет
        {
            bool answer = true;
            Assert.AreEqual(answer, CalculateSquare.IsRightTriangle(3, 4, 5));
        }

        [TestMethod]
        public void IsRightTriangle_SideMinus346_AnswerFalse()
        {
            bool answer = false;
            Assert.AreEqual(answer, CalculateSquare.IsRightTriangle(3, 4, 6));
        }

        [TestMethod]
        public void IsRightTriangle_SideMinus3410_AnswerFalse()
        {
            bool answer = false;
            Assert.AreEqual(answer, CalculateSquare.IsRightTriangle(3, 4, 10));
        }
    }
}
