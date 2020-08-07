namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("add_invoice_items")]
        public List<SubscriptionAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("backdate_start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? BackdateStartDate { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CancelAt { get; set; }

        [JsonProperty("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        [JsonProperty("items")]
        public List<SubscriptionItemOptions> Items { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("off_session")]
        public bool? OffSession { get; set; }

        ///
        ///
        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        [JsonProperty("pending_invoice_item_interval")]
        public SubscriptionPendingInvoiceItemIntervalOptions PendingInvoiceItemInterval { get; set; }

        [Obsolete("Use Items instead.")]
        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        ///
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [Obsolete("Use Items instead.")]
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionTransferDataOptions TransferData { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> TrialEnd { get; set; }

        [JsonProperty("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }

        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
