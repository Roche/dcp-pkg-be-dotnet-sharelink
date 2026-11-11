using System;

namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents an alias for a shareable link, including its identifier, name, and associated share link GUID.
    /// </summary>
    public class ShareLinkAliasDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the alias.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the alias.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the GUID of the share link associated with this alias.
        /// </summary>
        public Guid ShareLinkGuid { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who owns the share link alias.
        /// </summary>
        public int OwnerUserId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the share link alias was last modified.
        /// </summary>
        public DateTime LastModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who last modified the share link alias.
        /// </summary>
        public int LastModifiedBy { get; set; }
    }

}
