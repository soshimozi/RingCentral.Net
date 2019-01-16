using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AudioPromptInfo : Serializable
    {
        // Link to an prompt audio file
        public string uri;
        // Internal identifier of an prompt
        public string id;
    }
}