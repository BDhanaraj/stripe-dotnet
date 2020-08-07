namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceInvoiceItemPeriodOptions : INestedOptions
    {
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Start { get; set; }
    }
}