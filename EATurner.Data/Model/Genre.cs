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
    [Table("Genre")]
    public partial class Genre
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Genre"/> class.
        /// </summary>
        public Genre()
        {
            TitleGenres = new HashSet<TitleGenre>();
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the title genres.
        /// </summary>
        /// <value>
        /// The title genres.
        /// </value>
        [JsonIgnore]
        public virtual ICollection<TitleGenre> TitleGenres { get; set; }
    }
}
