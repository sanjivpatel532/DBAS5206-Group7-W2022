namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FINANCIAL_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FINANCIAL_STATUS()
        {
            CHARGE_TRANSACTION = new HashSet<CHARGE_TRANSACTION>();
            PATIENTs = new HashSet<PATIENT>();
        }

        [Key]
        public short STATUS_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string PROVIDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARGE_TRANSACTION> CHARGE_TRANSACTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATIENT> PATIENTs { get; set; }
    }
}
