namespace EATurner.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Title")]
    public partial class Title
    {
        public Title()
        {
            Awards = new HashSet<Award>();
            OtherNames = new HashSet<OtherName>();
            StoryLines = new HashSet<StoryLine>();
            TitleGenres = new HashSet<TitleGenre>();
            TitleParticipants = new HashSet<TitleParticipant>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TitleId { get; set; }

        [StringLength(100)]
        public string TitleName { get; set; }

        [StringLength(100)]
        public string TitleNameSortable { get; set; }

        public int? TitleTypeId { get; set; }
        /// <summary>
        /// Release Year
        /// </summary>
        public int? ReleaseYear { get; set; }

        public DateTime? ProcessedDateTimeUTC { get; set; }

        public virtual ICollection<Award> Awards { get; set; }

        public virtual ICollection<OtherName> OtherNames { get; set; }

        public virtual ICollection<StoryLine> StoryLines { get; set; }

        public virtual ICollection<TitleGenre> TitleGenres { get; set; }

        public virtual ICollection<TitleParticipant> TitleParticipants { get; set; }
    }
}
