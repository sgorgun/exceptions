namespace Exceptions
{
    public static class ThrowingArgumentNull
    {
        public static bool CheckParameterAndThrowException1(object o)
        {
            // TODO 2-1. Add the code to throw the ArgumentNullException if the o argument is null.
            return true;
        }

        public static bool CheckParametersAndThrowException2(object o1, object o2)
        {
            // TODO 2-2. Add the code to throw the ArgumentNullException if the o1 or o2 argument is null.
            return true;
        }

        public static int CheckParametersAndThrowException3(int[] integers, long[] longs, float[] floats)
        {
            // TODO 2-3. Add the code to throw the ArgumentNullException if the integers, longs or floats argument is null.
            return integers.Length + longs.Length + floats.Length;
        }

        public static int CheckParameterAndThrowException4(string s)
        {
            // TODO 2-4. Add the code to throw the ArgumentNullException if the s argument is null.
            return s.Length;
        }

        public static int CheckParametersAndThrowException5(string s1, string s2)
        {
            // TODO 2-5. Add the code to throw the ArgumentNullException if the s1 or s2 argument is null.
            return s1.Length + s2.Length;
        }

        public static int CheckParametersAndThrowException6(string s, int[] integers, string[] strings)
        {
            // TODO 2-6. Add the code to throw the ArgumentNullException if the s, integers or strings argument is null.
            return s.Length + integers.Length + strings.Length;
        }

        public static int CheckParameterAndThrowException7(int[] integers)
        {
            int integersCount;

            // TODO 2-7. Add the null-coalescing operator to throw the ArgumentNullException if the integers argument is null.
            integersCount = integers.Length;

            return integersCount;
        }

        public static int CheckParametersAndThrowException8(int[] integers, string s)
        {
            int integersCount, stringLength;

            // TODO 2-8. Add the null-coalescing operator to throw the ArgumentNullException if the integers or s argument is null.
            integersCount = integers.Length;
            stringLength = s.Length;

            return integersCount + stringLength;
        }

        public static int CheckParametersAndThrowException9(float[] floats, string s1, double[] doubles, string s2)
        {
            int floatsCount, s1Length, doublesCount, s2Length;

            // TODO 2-9. Add the null-coalescing operator to throw the ArgumentNullException if the any method argument is null.
            floatsCount = floats.Length;
            doublesCount = doubles.Length;
            s1Length = s1.Length;
            s2Length = s2.Length;

            return floatsCount + s1Length + doublesCount + s2Length;
        }
    }
}
