using MathLib;

namespace TestProjectXUnitVijaySales
{

    //Testing Reusable Libraries
    public class UnitTest1
    {
        [Fact]
        public void AdditionTest()
        {
           Assert.Equal(1, 1);

        }

        [Fact]
        public void SubtractionTest()
        {
            int num1 = 78;
            int num2 = 7;

            int expectedValue = 71;
            MathEngine mathEngine = new MathEngine();
            int actualValue=mathEngine.Subtract(num1, num2);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}