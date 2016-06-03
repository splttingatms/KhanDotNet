using System;

namespace KhanDotNet.Library.Utilities
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    class SensitiveAttribute : Attribute
    {
    }
}
