namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FeeRefundCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
