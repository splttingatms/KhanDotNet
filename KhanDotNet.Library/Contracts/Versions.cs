using KhanDotNet.Library.Utilities;

namespace KhanDotNet.Library.Contracts
{
    public class Versions
    {
        public int LearningTask { get; set; }

        public int VideoTask { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}