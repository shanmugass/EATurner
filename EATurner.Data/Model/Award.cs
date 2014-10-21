namespace EATurner.Data.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [Table("Award")]
    public partial class Award
    {
        /// <summary>
        /// Gets or sets the title identifier.
        /// </summary>
        /// <value>
        /// The title identifier.
        /// </value>
        public int TitleId { get; set; }

        /// <summary>
        /// Gets or sets the award won.
        /// </summary>
        /// <value>
        /// The award won.
        /// </value>
        public bool? AwardWon { get; set; }

        /// <summary>
        /// Gets or sets the award year.
        /// </summary>
        /// <value>
        /// The award year.
        /// </value>
        public int? AwardYear { get; set; }

        [Column("Award")]
        [StringLength(100)]
        public string AwardName { get; set; }

        /// <summary>
        /// Gets or sets the award company.
        /// </summary>
        /// <value>
        /// The award company.
        /// </value>
        [StringLength(100)]
        public string AwardCompany { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonIgnore]
        public virtual Title Title { get; set; }
    }
}
