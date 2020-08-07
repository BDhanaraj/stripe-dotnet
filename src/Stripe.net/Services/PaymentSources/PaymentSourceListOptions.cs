namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentSourceListOptions : ListOptions
    {
        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
