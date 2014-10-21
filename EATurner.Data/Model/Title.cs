namespace EATurner.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// 
    /// </summary>
    [Table("Title")]
    public partial class Title
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Title"/> class.
        /// </summary>
        public Title()
        {
            Awards = new HashSet<Award>();
            OtherNames = new HashSet<OtherName>();
            StoryLines = new HashSet<StoryLine>();
            TitleGenres = new HashSet<TitleGenre>();
            TitleParticipants = new HashSet<TitleParticipant>();
        }

        /// <summary>
        /// Gets or sets the title identifier.
        /// </summary>
        /// <value>
        /// The title identifier.
        /// </value>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TitleId { get; set; }

        /// <summary>
        /// Gets or sets the name of the title.
        /// </summary>
        /// <value>
        /// The name of the title.
        /// </value>
        [StringLength(100)]
        public string TitleName { get; set; }

        /// <summary>
        /// Gets or sets the title name sortable.
        /// </summary>
        /// <value>
        /// The title name sortable.
        /// </value>
        [StringLength(100)]
        public string TitleNameSortable { get; set; }

        /// <summary>
        /// Gets or sets the title type identifier.
        /// </summary>
        /// <value>
        /// The title type identifier.
        /// </value>
        public int? TitleTypeId { get; set; }
        /// <summary>
        /// Release Year
        /// </summary>
        /// <value>
        /// The release year.
        /// </value>
        public int? ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the processed date time UTC.
        /// </summary>
        /// <value>
        /// The processed date time UTC.
        /// </value>
        public DateTime? ProcessedDateTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets the awards.
        /// </summary>
        /// <value>
        /// The awards.
        /// </value>
        public virtual ICollection<Award> Awards { get; set; }

        /// <summary>
        /// Gets or sets the other names.
        /// </summary>
        /// <value>
        /// The other names.
        /// </value>
        public virtual ICollection<OtherName> OtherNames { get; set; }

        /// <summary>
        /// Gets or sets the story lines.
        /// </summary>
        /// <value>
        /// The story lines.
        /// </value>
        public virtual ICollection<StoryLine> StoryLines { get; set; }

        /// <summary>
        /// Gets or sets the title genres.
        /// </summary>
        /// <value>
        /// The title genres.
        /// </value>
        public virtual ICollection<TitleGenre> TitleGenres { get; set; }

        /// <summary>
        /// Gets or sets the title participants.
        /// </summary>
        /// <value>
        /// The title participants.
        /// </value>
        public virtual ICollection<TitleParticipant> TitleParticipants { get; set; }
    }
}
