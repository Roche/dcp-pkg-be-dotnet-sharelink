using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents a shareable link item, including its unique identifier, title, owner, and associated aliases.
    /// </summary>
    public class ShareLinkListItemDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier (GUID) of the share link.
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets the title of the share link.
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who owns the share link.
        /// </summary>
        /// <remarks>
        /// Nullable if the owner is not specified.
        /// </remarks>
        public int? OwnerUserId { get; set; }
        /// <summary>
        /// Get or set the page inside the application where share link is pointing
        /// </summary>
        public string Page { get; set; }
        /// <summary>
        /// Gets or sets the timestamp of when the share link was last modified.
        /// </summary>
        public DateTime LastModifiedAt { get; set; }
        /// <summary>
        /// Gets or sets the list of aliases associated with the share link.
        /// </summary>
        /// <remarks>
        /// Initialized to an empty list by default to avoid null references.
        /// </remarks>
        [NotMapped]
        public List<ShareLinkAliasDisplayDTO> Aliases { get; set; } = new List<ShareLinkAliasDisplayDTO>();
    }

}
