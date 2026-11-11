using System;
using System.Text.Json.Nodes;

namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents the configuration of a share link, including its content, identifier, title, and associated site.
    /// </summary>
    public class ShareLinkConfigurationDTO
    {
        /// <summary>
        /// Gets or sets the JSON object representing the share link content.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public required JsonObject Link { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (GUID) of the share link.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public Guid LinkGUID { get; set; }

        /// <summary>
        /// Gets or sets the title of the share link.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID of the site associated with the share link.
        /// </summary>
        public int? SiteId { get; set; }
    }

}
