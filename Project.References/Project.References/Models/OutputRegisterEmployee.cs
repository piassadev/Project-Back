using Newtonsoft.Json;

namespace Project.References.Models
{
    public class OutputRegisterEmployee
    {
        [JsonProperty(PropertyName = "status")]
        public bool Status { get; set; }

    }
}