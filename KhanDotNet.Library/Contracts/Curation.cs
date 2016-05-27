using Newtonsoft.Json;

namespace KhanDotNet.Library.Contracts
{
    // TODO 3: verify contract
    public class Curation
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
