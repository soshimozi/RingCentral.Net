namespace RingCentral
{
    public class CallQueueMembers
    {
        // Link to a call queue members resource
        public string uri; // Required

        // List of call queue members
        public CallQueueMemberInfo[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}