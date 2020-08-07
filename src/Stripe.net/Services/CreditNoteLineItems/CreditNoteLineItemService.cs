namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditNoteLineItemService : ServiceNested<CreditNoteLineItem>,
        INestedListable<CreditNoteLineItem, CreditNoteLineItemListOptions>
    {
        public CreditNoteLineItemService()
            : base(null)
        {
        }

        public CreditNoteLineItemService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/credit_notes/{PARENT_ID}/lines";

        public virtual StripeList<CreditNoteLineItem> List(string parentId, CreditNoteLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<CreditNoteLineItem>> ListAsync(string parentId, CreditNoteLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNoteLineItem> ListAutoPaging(string parentId, CreditNoteLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<CreditNoteLineItem> ListAutoPagingAsync(string parentId, CreditNoteLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}
