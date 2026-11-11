using System;

namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents the user configuration of a share link alias, including its name and associated share link identifier.
    /// </summary>
    public class ShareLinkAliasConfigurationDTO
    {
        /// <summary>
        /// Gets or sets the name of the share link alias.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (GUID) of the share link to which this alias belongs.
        /// </summary>
        public Guid ShareLinkGuid { get; set; }
    }

}
