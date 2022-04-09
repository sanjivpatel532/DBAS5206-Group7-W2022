namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PATIENT")]
    public partial class PATIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PATIENT()
        {
            ADMISSIONs = new HashSet<ADMISSION>();
            APPOINTMENTs = new HashSet<APPOINTMENT>();
            TREATMENTs = new HashSet<TREATMENT>();
            ADMISSIONs1 = new HashSet<ADMISSION>();
        }

        [Key]
        public int PATIENT_NUMBER { get; set; }

        [Required]
        [StringLength(40)]
        public string PATIENT_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string PATIENT_ADDRESS { get; set; }

        [Required]
        [StringLength(15)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string PROVINCE { get; set; }

        [Required]
        [StringLength(7)]
        public string POSTAL_CODE { get; set; }

        [Required]
        [StringLength(12)]
        public string TELEPHONE { get; set; }

        [Required]
        [StringLength(6)]
        public string SEX { get; set; }

        public short STATUS_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADMISSION> ADMISSIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPOINTMENT> APPOINTMENTs { get; set; }

        public virtual FINANCIAL_STATUS FINANCIAL_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TREATMENT> TREATMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADMISSION> ADMISSIONs1 { get; set; }
    }
}
