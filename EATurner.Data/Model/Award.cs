namespace EATurner.Data.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Award")]
    public partial class Award
    {
        public int TitleId { get; set; }

        public bool? AwardWon { get; set; }

        public int? AwardYear { get; set; }

        [Column("Award")]
        [StringLength(100)]
        public string AwardName { get; set; }

        [StringLength(100)]
        public string AwardCompany { get; set; }

        public int Id { get; set; }

        [JsonIgnore]
        public virtual Title Title { get; set; }
    }
}
