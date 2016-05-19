using System;

namespace KhanDotNet.Library.Utilities
{
    public static class DisposableUtilities
    {
        public static T SafeCreate<T>() where T : class, IDisposable, new()
        {
            T result = null;

            try
            {
                result = new T();
                return result;
            }
            catch (Exception)
            {
                if (result != null)
                {
                    result.Dispose();
                    result = null;
                }

                throw;
            }
        }
    }
}
