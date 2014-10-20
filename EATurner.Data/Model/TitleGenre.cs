namespace EATurner.Data.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("TitleGenre")]
    public partial class TitleGenre
    {
        public int Id { get; set; }

        public int TitleId { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }


        [JsonIgnore]
        public virtual Title Title { get; set; }
    }
}
