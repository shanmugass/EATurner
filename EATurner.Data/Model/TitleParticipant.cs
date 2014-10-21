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
    [Table("TitleParticipant")]
    public partial class TitleParticipant
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
        /// Gets or sets the participant identifier.
        /// </summary>
        /// <value>
        /// The participant identifier.
        /// </value>
        public int ParticipantId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is key.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is key; otherwise, <c>false</c>.
        /// </value>
        public bool IsKey { get; set; }

        /// <summary>
        /// Gets or sets the type of the role.
        /// </summary>
        /// <value>
        /// The type of the role.
        /// </value>
        [StringLength(100)]
        public string RoleType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is on screen.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is on screen; otherwise, <c>false</c>.
        /// </value>
        public bool IsOnScreen { get; set; }

        /// <summary>
        /// Gets or sets the participant.
        /// </summary>
        /// <value>
        /// The participant.
        /// </value>
        public virtual Participant Participant { get; set; }


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
