namespace Exceptions
{
    public static class NullCoalescingAssignment
    {
        public static object CheckParameterAndThrowException1(object o)
        {
            // TODO 3-1. Use the null-coalescing assignment operator to initialize the o parameter with the default value.
            return o;
        }

        public static int[] CheckParameterAndThrowException2(int[] integers)
        {
            // TODO 3-2. Use the null-coalescing assignment operator to initialize the integers parameter with the default value.
            return integers;
        }

        public static string CheckParameterAndThrowException3(string s)
        {
            // TODO 3-3. Use the null-coalescing assignment operator to initialize the s parameter with the default value.
            return s;
        }

        public static string CheckParametersAndThrowException4(string s1, string s2)
        {
            // TODO 3-4. Use the null-coalescing assignment operator to initialize the s1 and s2 parameters with the default values.
            return $"{s1}, {s2}!";
        }

        public static string CheckParametersAndThrowException5(string s1, int[] integers, string s2)
        {
            // TODO 3-5. Use the null-coalescing assignment operator to initialize the method parameters with the default values.
            return $"{s1}{integers.Length}{s2}";
        }
    }
}
