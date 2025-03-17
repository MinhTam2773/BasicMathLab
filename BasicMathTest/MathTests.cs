using BasicMathLab;

namespace BasicMathTest
{
    public class MathTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2 , 3, 5)]
        public void Test_AddMethod(double input1, double input2, double expected)
        {
            BasicMath basicMath = new BasicMath();

            double actual = basicMath.Add(input1, input2);

            Assert.That(expected, Is.EqualTo(actual).Within(0.001));
        }

        [Test]
        [TestCase(25, 5, 5)]
        public void Test_DivideMethod(double input1, double input2, double expected)
        {
            BasicMath basicMath = new BasicMath();

            double actual = basicMath.Divide(input1, input2);

            Assert.That(expected, Is.EqualTo(actual).Within(0.001));
        }

        [Test]
        [TestCase(4, 5, 20)]
        public void Test_MutiplyMethod(double input1, double input2, double expected) 
        {
            BasicMath basicMath = new BasicMath();
            
            double actual = basicMath.Multiply(input1, input2);

            Assert.That(expected, Is.EqualTo(actual).Within(0.001));
        }

        [Test]
        [TestCase(10, 11, -1)]
        public void Test_SubtractMethod(double input1, double input2, double expected) 
        {
            BasicMath basicMath = new BasicMath();
            
            double actual = basicMath.Subtract(input1, input2);

            Assert.That(expected, Is.EqualTo(actual).Within(0.001));
        }
    }
}
