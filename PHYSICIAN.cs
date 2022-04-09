namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHYSICIAN")]
    public partial class PHYSICIAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHYSICIAN()
        {
            TREATMENTs = new HashSet<TREATMENT>();
        }

        [Key]
        public int PHYSICIAN_NUMBER { get; set; }

        public int USER_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string PHYSICIAN_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string TELEPHONE { get; set; }

        [Required]
        [StringLength(3)]
        public string SPECIALTY_ID { get; set; }

        public virtual DB_USER DB_USER { get; set; }

        public virtual PHYSICIAN_SPECIALTY PHYSICIAN_SPECIALTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TREATMENT> TREATMENTs { get; set; }
    }
}
