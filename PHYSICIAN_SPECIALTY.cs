namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHYSICIAN_SPECIALTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHYSICIAN_SPECIALTY()
        {
            PHYSICIANs = new HashSet<PHYSICIAN>();
        }

        [Key]
        [StringLength(3)]
        public string SPECIALTY_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string SPECIALTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHYSICIAN> PHYSICIANs { get; set; }
    }
}
