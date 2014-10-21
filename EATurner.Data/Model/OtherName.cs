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
    [Table("OtherName")]
    public partial class OtherName
    {
        /// <summary>
        /// Gets or sets the title identifier.
        /// </summary>
        /// <value>
        /// The title identifier.
        /// </value>
        public int? TitleId { get; set; }

        /// <summary>
        /// Gets or sets the title name language.
        /// </summary>
        /// <value>
        /// The title name language.
        /// </value>
        [StringLength(100)]
        public string TitleNameLanguage { get; set; }

        /// <summary>
        /// Gets or sets the type of the title name.
        /// </summary>
        /// <value>
        /// The type of the title name.
        /// </value>
        [StringLength(100)]
        public string TitleNameType { get; set; }

        /// <summary>
        /// Gets or sets the title name sortable.
        /// </summary>
        /// <value>
        /// The title name sortable.
        /// </value>
        [StringLength(100)]
        public string TitleNameSortable { get; set; }

        /// <summary>
        /// Gets or sets the name of the title.
        /// </summary>
        /// <value>
        /// The name of the title.
        /// </value>
        [StringLength(100)]
        public string TitleName { get; set; }

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
