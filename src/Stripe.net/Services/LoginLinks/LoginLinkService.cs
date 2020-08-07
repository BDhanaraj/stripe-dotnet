namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LoginLinkService : ServiceNested<LoginLink>,
        ISingletonRetrievable<Balance>
    {
        public LoginLinkService()
            : base(null)
        {
        }

        public LoginLinkService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/login_links";

        public virtual LoginLink CreateOnAccount(string id, LoginLinkCreateOnAccountOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, "/v1/accounts/{account}/login_links", options, requestOptions);
        }

        public virtual Task<LoginLink> CreateOnAccountAsync(string id, LoginLinkCreateOnAccountOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, "/v1/accounts/{account}/login_links", options, requestOptions, cancellationToken);
        }
    }
}
