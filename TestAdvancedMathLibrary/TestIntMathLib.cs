
using AdvancedMathLibrary;
using Xunit;

namespace TestAdvancedMathLibrary {
    public class TestIntMathLib {

        [Fact]
        public void TestAbsoluteValue() {
            int answer = Math.AbsoluteValue(-3);
            Assert.Equal(3, answer);
            //testing with 3
            Assert.Equal(3, Math.AbsoluteValue(3));
            Assert.Equal(0, Math.AbsoluteValue(0));
            

        }
        [Fact]
        public void TestZeroConstant() {
            Assert.Equal(0, Math.Zero);
        }
    }
}
