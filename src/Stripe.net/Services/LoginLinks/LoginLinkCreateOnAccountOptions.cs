namespace Stripe
{
    using Newtonsoft.Json;

    public class LoginLinkCreateOnAccountOptions : BaseOptions
    {
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
