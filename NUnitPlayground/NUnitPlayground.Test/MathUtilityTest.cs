using NUnit.Framework;
using NUnitPlayground.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPlayground.Test
{
    [TestFixture]
    public class MathUtilityTest
    {
        [Test]
        [Description("Verify two positive numbers.")]
        public void VerifyPositiveMultiplication_BothPositive()
        {
            int num1 = 5;
            int num2 = 3;
            int expectedSum = 15;
            int result = MathUtilities.SafeMultiplyPositive(num1, num2);
            Assert.AreEqual(expectedSum, result, "numbers were not positive");
        }

        [Test]
        [Description("Verify two negative numbers.")]
        public void VerifyPositiveMultiplication_BothNegative()
        {
            int num1 = -5;
            int num2 = -3;
            int expectedSum = 15;
            int result = MathUtilities.SafeMultiplyPositive(num1, num2);
            Assert.AreEqual(expectedSum, result, "numbers were not positive");
        }

        [Test]
        [Description("Verify one negative number and one positive number throws an exception")]
        public void VerifyPositiveMultiplication_InputOneNegativeInputTwoPositive()
        {
            int num1 = -5;
            int num2 = 3;
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtilities.SafeMultiplyPositive(num1, num2));
        }

        [Test]
        [Description("Verify one negative number and one positive number throws an exception")]
        public void VerifyPositiveMultiplication_InputOnePositiveInputTwoNegative()
        {
            int num1 = 5;
            int num2 = -3;
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtilities.SafeMultiplyPositive(num1, num2));
        }

        [Test]
        [Description("Verify one zero number and one positive number throws an exception")]
        public void VerifyPositiveMultiplication_InputOneZeroInputTwoPositive()
        {
            int num1 = 3;
            int num2 = 0;
            Assert.Throws<ArgumentException>(() => MathUtilities.SafeMultiplyPositive(num1, num2));
        }

        [Test]
        [Description("Verify one zero number and one positive number throws an exception")]
        public void VerifyPositiveMultiplication_InputOnePositiveInputTwoZero()
        {
            int num1 = 0;
            int num2 = 3;
            Assert.Throws<ArgumentException>(() => MathUtilities.SafeMultiplyPositive(num1, num2));
        }
    }
}
