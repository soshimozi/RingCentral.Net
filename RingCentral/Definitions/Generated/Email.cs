using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class Email : Serializable
    {
        // Enum: work
        public string type; // Required
        public string value; // Required
    }
}