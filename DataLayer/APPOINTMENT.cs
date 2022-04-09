namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APPOINTMENT")]
    public partial class APPOINTMENT
    {
        [Key]
        public int APPOINTMENT_NUMBER { get; set; }

        public int PATIENT_NUMBER { get; set; }

        public DateTime TIME { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public virtual PATIENT PATIENT { get; set; }
    }
}
