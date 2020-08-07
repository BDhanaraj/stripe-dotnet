namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceLineItem : StripeEntity<InvoiceLineItem>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Date { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountable")]
        public bool Discountable { get; set; }

        #region Expandable Discounts

        [JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        [JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        [JsonProperty("discount_amounts")]
        public List<CreditNoteLineItemDiscountAmount> DiscountAmounts { get; set; }

        [JsonProperty("invoice_item")]
        public string InvoiceItem { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("proration")]
        public bool Proration { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("subscription_item")]
        public string SubscriptionItem { get; set; }

        [JsonProperty("tax_amounts")]
        public List<InvoiceTaxAmount> TaxAmounts { get; set; }

        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unified_proration")]
        public bool UnifiedProration { get; set; }
    }
}
