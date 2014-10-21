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
    [Table("Participant")]
    public partial class Participant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class.
        /// </summary>
        public Participant()
        {
            TitleParticipants = new HashSet<TitleParticipant>();
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
        /// Gets or sets the type of the participant.
        /// </summary>
        /// <value>
        /// The type of the participant.
        /// </value>
        [StringLength(100)]
        public string ParticipantType { get; set; }
        /// <summary>
        /// Gets or sets the title participants.
        /// </summary>
        /// <value>
        /// The title participants.
        /// </value>
        [JsonIgnore]
        public virtual ICollection<TitleParticipant> TitleParticipants { get; set; }
    }
}
