
using AdvancedMathLibrary;
using Xunit;

namespace TestAdvancedMathLibrary {
    public class TestIntMathLib {

        [Fact]
        public void TestDivideByZero() {
            System.Action ZeroDenominator = () => Math.Divide(1, 0);
           Assert.Throws<System.DivideByZeroException>(ZeroDenominator);
            //THis should be throwing an exception if the second number is 0
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(-10, 15, -25)]
        public void TestAdd(int expected, int a, int b) {
            Assert.Equal(expected, Math.Add(a, b));
        }
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(5, 15, 10)]
        [InlineData(-6, 12, 18)]
        [InlineData(1, -9, -10)]
        public void TestSubtract(int expected, int a, int b) {
            Assert.Equal(expected, Math.Subtract(a, b));
        }



        //[Fact]
        //public void TestAbsoluteValue() {
        //    int answer = Math.AbsoluteValue(-3);
        //    Assert.Equal(3, answer);
        //    //testing with 3
        //    Assert.Equal(3, Math.AbsoluteValue(3));
        //    Assert.Equal(0, Math.AbsoluteValue(0));
        //}
        [Theory]
        [InlineData(-3, 3)]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        public void TestAbsoluteValue(int input, int expected) {
            Assert.Equal(expected, Math.AbsoluteValue(input));
        }

        [Fact]
        public void TestZeroConstant() {
            Assert.Equal(0, Math.Zero);
        }
    }
}
