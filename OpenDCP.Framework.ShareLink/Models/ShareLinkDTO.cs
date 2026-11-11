using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents a shareable link with associated metadata, aliases, and modification information.
    /// </summary>
    public class ShareLinkDTO
    {
        /// <summary>
        /// Gets or sets the JSON object representing the actual link data.
        /// </summary>
        public required JsonObject Link { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (GUID) for the share link.
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets the title or descriptive name of the share link.
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Gets or sets the collection of alias representations for the share link.
        /// </summary>
        public List<ShareLinkAliasDisplayDTO> Aliases { get; set; }
            = new List<ShareLinkAliasDisplayDTO>();

        /// <summary>
        /// Gets or sets the user ID of the person who last modified the share link.
        /// </summary>
        public int LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of when the share link was last modified.
        /// </summary>
        public DateTime LastModifiedAt { get; set; }
    }
}
