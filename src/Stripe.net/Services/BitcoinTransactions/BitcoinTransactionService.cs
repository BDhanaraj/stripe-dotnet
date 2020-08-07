namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class BitcoinTransactionService : ServiceNested<BitcoinTransaction>,
        INestedListable<BitcoinTransaction, BitcoinTransactionListOptions>
    {
        public BitcoinTransactionService()
            : base(null)
        {
        }

        public BitcoinTransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/bitcoin/receivers/{PARENT_ID}/transactions";

        public virtual StripeList<BitcoinTransaction> List(string parentId, BitcoinTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<BitcoinTransaction>> ListAsync(string parentId, BitcoinTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BitcoinTransaction> ListAutoPaging(string parentId, BitcoinTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<BitcoinTransaction> ListAutoPagingAsync(string parentId, BitcoinTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}
