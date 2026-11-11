namespace OpenDCP.Framework.ShareLink.Models
{
    /// <summary>
    /// Represents the display information for a share link alias.
    /// </summary>
    public class ShareLinkAliasDisplayDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the alias.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the alias name for display purposes.
        /// </summary>
        public required string Alias { get; set; }
    }

}
