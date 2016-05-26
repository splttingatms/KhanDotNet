using Newtonsoft.Json;

namespace KhanDotNet.Library.Contract
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
