using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents query parameters used to filter or resolve share links.
    /// </summary>
    /// <remarks>
    /// This DTO is typically used to query share links by one or more aliases
    /// and/or unique identifiers.
    /// </remarks>
    public class ShareLinkQueryDTO
    {
        /// <summary>
        /// Gets or sets a list of aliases used to identify share links.
        /// </summary>
        /// <remarks>
        /// When provided, only share links matching one of the specified aliases
        /// will be included in the query result.
        /// </remarks>
        public List<string> Alias { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a list of unique identifiers used to identify share links.
        /// </summary>
        /// <remarks>
        /// When provided, only share links matching one of the specified GUIDs
        /// will be included in the query result.
        /// </remarks>
        public List<Guid> Guid { get; set; } = new List<Guid>();

        /// <summary>
        /// Gets or sets a list of site identifiers used to filter share links.
        /// </summary>
        /// <remarks>
        /// When provided, only share links associated with one of the specified site IDs
        /// will be included in the query result.
        /// </remarks>
        public List<int> SiteId { get; set; } = new List<int>();
    }
}
