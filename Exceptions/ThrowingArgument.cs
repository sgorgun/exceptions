namespace Exceptions
{
    public static class ThrowingArgument
    {
        public static int CheckParameterAndThrowException1(int i)
        {
            // TODO 4-1. Add the code to throw the ArgumentException if the i argument is odd.
            return i;
        }

        public static ushort CheckParameterAndThrowException2(ushort s)
        {
            // TODO 4-2. Add the code to throw the ArgumentException if the s argument equals zero.
            return s;
        }

        public static long CheckParameterAndThrowException3(long l)
        {
            // TODO 4-3. Add the code to throw the ArgumentException if the l argument is even.
            return l;
        }

        public static int CheckParameterAndThrowException4(float[] floats)
        {
            // TODO 4-4. Add the code to throw the ArgumentException if the floats array is empty.
            return floats.Length;
        }

        public static int CheckParameterAndThrowException5(string s)
        {
            // TODO 4-5. Add the code to throw the ArgumentException if the s string is empty.
            return s.Length;
        }
    }
}
