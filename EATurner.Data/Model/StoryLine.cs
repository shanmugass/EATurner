namespace EATurner.Data.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("StoryLine")]
    public partial class StoryLine
    {
        public int TitleId { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Language { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public int Id { get; set; }

        [JsonIgnore]
        public virtual Title Title { get; set; }
    }
}
