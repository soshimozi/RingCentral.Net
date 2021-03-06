namespace RingCentral
{
    public class ReadGlipPostsParameters
    {
        /// <summary>
        /// Max number of posts to be fetched by one request (not more than 250)
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount;

        /// <summary>
        /// Pagination token.
        /// </summary>
        public string pageToken;
    }
}