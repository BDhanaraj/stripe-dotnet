namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentSource : StripeEntity<PaymentSource>
    {
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }
    }
}
