namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHARGE_TRANSACTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHARGE_TRANSACTION()
        {
            CHARGEs = new HashSet<CHARGE>();
        }

        [Key]
        public int TRANSACTION_NUMBER { get; set; }

        public short STATUS_ID { get; set; }

        public DateTime DATE { get; set; }

        [Column(TypeName = "money")]
        public decimal PAID { get; set; }

        public virtual FINANCIAL_STATUS FINANCIAL_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARGE> CHARGEs { get; set; }
    }
}
