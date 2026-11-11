using System;

namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents the configuration of a share link, including its content, identifier, title, and associated site.
    /// </summary>
    public class ShareLinkConfigurationUpdateDTO
    {
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
    }

}
