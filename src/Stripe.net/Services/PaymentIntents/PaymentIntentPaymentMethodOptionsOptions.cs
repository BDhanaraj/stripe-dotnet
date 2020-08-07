namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsOptions : INestedOptions
    {
        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }
    }
}
