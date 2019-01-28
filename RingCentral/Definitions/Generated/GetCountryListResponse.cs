namespace RingCentral
{
    public class GetCountryListResponse
    {
        // List of countries with the country data
        public GetCountryInfoDictionaryResponse[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}