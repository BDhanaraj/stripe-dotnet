namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceInvoiceItemDiscountOptions : INestedOptions
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }
    }
}
