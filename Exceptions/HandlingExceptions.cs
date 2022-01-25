namespace Exceptions
{
    public static class HandlingExceptions
    {
        public static bool CatchArgumentOutOfRangeException1(int i, Func<int, bool> foo)
        {
            // TODO #5-1. Add the try-catch statement to catch an exception of ArgumentOutOfRangeException type. The method should return false if an exception is thrown.
            return foo(i);
        }

        public static string CatchArgumentOutOfRangeException2(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // TODO #5-2. Add the try-catch statement to catch an exception of ArgumentOutOfRangeException type. If an ArgumentOutOfRangeException is thrown, assign rrorMessage parameter to the exception's error message and return "K139".
            return DoSomething(i, o, s);
        }

        public static string CatchArgumentNullException3(object o, Func<object, string> foo)
        {
            // TODO #5-3. Add the try-catch statement here to catch an exception of ArgumentNullException type. The method should return "P456" string if an exception is thrown.
            return foo(o);
        }

        public static string CatchArgumentNullException4(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // TODO #5-4. Add the try-catch statement to catch an exception of ArgumentNullException type. If an ArgumentNullException is thrown, assign errorMessage parameter to the exception's error message and return "A732".
            return DoSomething(i, o, s);
        }

        public static int CatchArgumentException5(int[] integers, Func<int[], int> foo)
        {
            // TODO #5-5. Add the try-catch statement here to catch an exception of ArgumentException type. The method should return "0" value if an exception is thrown.
            return foo(integers);
        }

        public static string CatchArgumentException6(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // TODO #5-6. Add the try-catch statement to catch an exception of ArgumentNullException type. If an ArgumentNullException is thrown, assign errorMessage parameter to the exception's error message and return "D948".
            return DoSomething(i, o, s);
        }

        public static string CatchArgumentException7(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            // TODO #5-7. Add the try-catch statement to catch three exception types - ArgumentException, ArgumentNullException and ArgumentOutOfRangeException. See README.md for details.
            return DoSomething(i, o, s);
        }

        public static string DoSomething(int i, object o, string s)
        {
            if (i < -10 || i > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(i), "i should be in [-10, 10] interval.");
            }

            if (o is null)
            {
                throw new ArgumentNullException(nameof(o), "o is null.");
            }

            if (s is null)
            {
                throw new ArgumentNullException(nameof(s), "s is null.");
            }

            if (s.Length == 0)
            {
                throw new ArgumentException("s string is empty.", nameof(s));
            }

            return $"{i}{o}{s}";
        }
    }
}
