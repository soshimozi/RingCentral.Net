using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Webhooks
{
    public partial class Index
    {
        public RestClient rc;
        public string webhookId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string webhookId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.webhookId = webhookId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && webhookId != null)
            {
                return $"{parent.Path()}/webhooks/{webhookId}";
            }

            return $"{parent.Path()}/webhooks";
        }

        /// <summary>
        /// Operation: Get Webhooks
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/webhooks
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipWebhookList> List(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipWebhookList>(this.Path(false), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Webhook
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/webhooks/{webhookId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipWebhookList> Get(CancellationToken? cancellationToken = null)
        {
            if (this.webhookId == null)
            {
                throw new System.ArgumentNullException("webhookId");
            }

            return await rc.Get<RingCentral.GlipWebhookList>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Webhook
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/glip/webhooks/{webhookId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.webhookId == null)
            {
                throw new System.ArgumentNullException("webhookId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Webhooks.Index Webhooks(string webhookId = null)
        {
            return new Restapi.Glip.Webhooks.Index(this, webhookId);
        }
    }
}