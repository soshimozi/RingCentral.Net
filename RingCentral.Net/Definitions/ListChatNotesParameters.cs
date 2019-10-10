namespace RingCentral
{
    public class ListChatNotesParameters
    {
        /// <summary>
        /// The end datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2019-03-10T18:23:45. The default value is Now.
        /// </summary>
        public string creationTimeTo;

        /// <summary>
        /// The start datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone
        /// </summary>
        public string creationTimeFrom;

        /// <summary>
        /// Internal identifier of the user that created the note. Multiple values are supported
        /// </summary>
        public string creatorId;

        /// <summary>
        /// Status of notes to be fetched; if not specified all notes are fetched by default.
        /// Enum: Active, Draft
        /// </summary>
        public string status;

        /// <summary>
        /// Pagination token
        /// </summary>
        public string pageToken;

        /// <summary>
        /// Max number of notes to be fetched by one request; the value range is 1-250.
        /// Maximum: 250
        /// Default: 30
        /// </summary>
        public long? recordCount;
    }
}