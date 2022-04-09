namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TREATMENT")]
    public partial class TREATMENT
    {
        [Key]
        public int TREATMENT_NUMBER { get; set; }

        public int DIAGNOSIS_NUMBER { get; set; }

        public int PHYSICIAN_NUMBER { get; set; }

        public int PATIENT_NUMBER { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public virtual DIAGNOSI DIAGNOSI { get; set; }

        public virtual PATIENT PATIENT { get; set; }

        public virtual PHYSICIAN PHYSICIAN { get; set; }
    }
}
