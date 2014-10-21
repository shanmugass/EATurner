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
    [Table("TitleGenre")]
    public partial class TitleGenre
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title identifier.
        /// </summary>
        /// <value>
        /// The title identifier.
        /// </value>
        public int TitleId { get; set; }

        /// <summary>
        /// Gets or sets the genre identifier.
        /// </summary>
        /// <value>
        /// The genre identifier.
        /// </value>
        public int GenreId { get; set; }

        /// <summary>
        /// Gets or sets the genre.
        /// </summary>
        /// <value>
        /// The genre.
        /// </value>
        public virtual Genre Genre { get; set; }


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
