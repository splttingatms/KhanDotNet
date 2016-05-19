namespace KhanDotNet.Library.Utilities
{
    public static class ObjectExtensions
    {
        public static bool SafeEquals(this object a, object b)
        {
            if (a == null)
                return b == null;

            return a.Equals(b);
        }

        public static int SafeGetHashCode(this object a)
        {
            return a?.GetHashCode() ?? 0;
        }
    }
}
