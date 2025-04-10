namespace TestProject1
{
    using CI_Demo;
    using Xunit;

    namespace TestProject1
    {
        public class UnitTest1
        {
            Calculator calculator;

            public UnitTest1()
            {
                calculator = new Calculator();
            }

            // Good practice: One thing per test (one assert)

            [Fact]
            public void TestAddition()
            {
                //Arrange
                //Act
                var result = calculator.Add(2, 3);
                var result2 = calculator.Add(0, 0); // This should return 0
                var result3 = calculator.Add(-2, 3); // This should return 1

                //Assert
                Assert.Equal(5, result);
                Assert.Equal(0, result2); // Check addition with zero
                Assert.Equal(1, result3); // Check addition with negative number
            }

            [Fact]
            public void TestSubtraction()
            {
                //Arrange
                //Act
                var result = calculator.Subtract(2, 3);
                var result2 = calculator.Subtract(3, 2); // This should return 1

                //Assert
                Assert.Equal(-1, result);
                Assert.Equal(1, result2); // Check subtraction with different order
            }

            [Fact]
            public void TestMultiplication()
            {
                //Arrange
                //Act
                var result = calculator.Multiply(2, 3);
                var result2 = calculator.Multiply(2, 0); // This should return 0

                //Assert
                Assert.Equal(6, result);
                Assert.Equal(0, result2); // Check multiplication with zero
            }

            [Fact]
            public void TestDivision()
            {
                //Arrange
                //Act
                var result = calculator.Divide(10, 2);
                //Assert
                Assert.Equal(5, result);
                Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
            }
        }
    }
}
