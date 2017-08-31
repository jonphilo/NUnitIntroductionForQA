using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPlayground.Utilities
{
    public static class MathUtilities
    {
        /// <summary>
        /// This method takes two positive integers (whole numbers) and multiplies them together.
        /// </summary>
        /// <param name="inputNumber1">the first number to be multiplied</param>
        /// <param name="inputNumber2">the second number to be multiplied</param>
        /// <returns>the sum of the two supplied integers.</returns>
        public static int MultiplyPositive(int inputNumber1, int inputNumber2)
        {
            return inputNumber1 * inputNumber2;
        }

        #region Safe Multiply

        public static int SafeMultiplyPositive(int inputNumber1, int inputNumber2)
        {
            if (!(inputNumber1 < 0 && inputNumber2 < 0))
            {
                Guard.VerifyArgumentNotZero(inputNumber1, nameof(inputNumber1));
                Guard.VerifyArgumentNotZero(inputNumber2, nameof(inputNumber2));
                Guard.VerifyArgumentPositive(inputNumber1, nameof(inputNumber1));
                Guard.VerifyArgumentPositive(inputNumber2, nameof(inputNumber2));
            }
            return inputNumber1 * inputNumber2;
        }
        #endregion
    }
}
