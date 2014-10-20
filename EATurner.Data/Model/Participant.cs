namespace EATurner.Data.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Participant")]
    public partial class Participant
    {
        public Participant()
        {
            TitleParticipants = new HashSet<TitleParticipant>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ParticipantType { get; set; }
        [JsonIgnore]
        public virtual ICollection<TitleParticipant> TitleParticipants { get; set; }
    }
}
