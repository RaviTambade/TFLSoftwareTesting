using MathLib;

namespace TestProjectXUnitVijaySales
{
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
            int num1 = 12;
            int num2 = 13;

            int expectedValue = 25;
          
            //method call
            //collect result
            //Assert result
            MathEngine mathEngine = new MathEngine();
            int actualValue=mathEngine.Addition(num1, num2);
            Assert.StrictEqual(expectedValue, actualValue);
        }
    }
}