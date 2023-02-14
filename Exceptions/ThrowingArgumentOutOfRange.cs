﻿namespace Exceptions
{
    public static class ThrowingArgumentOutOfRange
    {
        public static bool CheckParameterAndThrowException1(int i)
        {
            if (i <= -5 || i >= 5)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }

            return true;
        }

        public static bool CheckParameterAndThrowException2(ulong l)
        {
            if (l > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(l));
            }

            return true;
        }

        public static bool CheckParametersAndThrowException3(uint i, double d)
        {
            if (i >= 5)
            {
                throw new ArgumentOutOfRangeException(nameof(i), $"i should be in [0, 5) interval.");
            }

            if (d is < -1.0 or > 1.0)
            {
                throw new ArgumentOutOfRangeException(nameof(d), $"d should be in [-1.0, 1.0] interval.");
            }

            return true;
        }

        public static bool CheckParametersAndThrowException4(long l, float f)
        {
            if (l is < -9 or >= 9 or < 3 and >= -3)
            {
                throw new ArgumentOutOfRangeException(nameof(l), "l should be in [-9, -3) or [3, 9) intervals.");
            }

            if (f < -0.3 || f >= 0.3)
            {
                throw new ArgumentOutOfRangeException(nameof(f), "f should be in the (-0.3, 0.3) interval.");
            }

            return true;
        }
    }
}
