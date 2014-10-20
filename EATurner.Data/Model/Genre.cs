namespace EATurner.Data.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Genre")]
    public partial class Genre
    {
        public Genre()
        {
            TitleGenres = new HashSet<TitleGenre>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<TitleGenre> TitleGenres { get; set; }
    }
}
