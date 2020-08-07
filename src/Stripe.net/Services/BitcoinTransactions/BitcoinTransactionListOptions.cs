namespace Stripe
{
    using Newtonsoft.Json;

    public class BitcoinTransactionListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
