using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Teams.Add
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/add";
        }

        /// <summary>
        /// Operation: Add Team Members
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}/add
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Post(RingCentral.GlipPostMembersListBody glipPostMembersListBody,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), glipPostMembersListBody, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Add.Index Add()
        {
            return new Restapi.Glip.Teams.Add.Index(this);
        }
    }
}