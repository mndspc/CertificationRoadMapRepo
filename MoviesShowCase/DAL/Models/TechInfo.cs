using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DAL.Models
{
    [Serializable]
    public class TechInfo
    {
        [Key]
        [DataMember]
        public int TechId { get; set; }
        [DataMember]
        public string TechName { get; set; }

        public virtual List<CertiDetails> Certifications { get; set; }
    }
}