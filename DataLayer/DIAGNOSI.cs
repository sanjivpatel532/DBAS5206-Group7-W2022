namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIAGNOSIS")]
    public partial class DIAGNOSI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIAGNOSI()
        {
            TREATMENTs = new HashSet<TREATMENT>();
        }

        [Key]
        public int DIAGNOSIS_NUMBER { get; set; }

        [Required]
        [StringLength(200)]
        public string DIAGNOSIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TREATMENT> TREATMENTs { get; set; }
    }
}
