using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DAL.Models
{
    [Serializable]
    public class CertiDetails
    {
        [Key]
        public int CertiId { get; set; }
        [DataMember]
        public string ExamCode { get; set; }
        [DataMember]
        public string CertiName { get; set; }
        [DataMember]
        public int TechId { get; set; }
        [DataMember]
        public DateTime ReleaseDate { get; set; }
        [DataMember]
        public DateTime ExpiryDate { get; set; }

        public virtual TechInfo TechInfo { get; set; }
    }
}