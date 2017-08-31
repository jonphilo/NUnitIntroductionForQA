using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPlayground.Utilities
{
    public static class Guard
    {
        public static void VerifyArgumentNotZero(long argument, string argumentName)
        {
            if (argument == 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is zero. {0} cannot be zero.", argumentName));
            }
        }

        public static void VerifyArgumentPositive(long argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("Argument {0} is negative. {0} cannot be negative.", argumentName));
            }
        }
    }
}
