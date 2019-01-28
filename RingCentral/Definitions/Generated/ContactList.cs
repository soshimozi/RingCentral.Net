namespace RingCentral
{
    public class ContactList
    {
        // List of personal contacts from the extension address book
        public PersonalContactResource[] records;

        // Information on navigation
        public NavigationInfo navigation;

        // Information on paging
        public PagingInfo paging;
    }
}