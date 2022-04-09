namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHARGE")]
    public partial class CHARGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHARGE()
        {
            CHARGE_TRANSACTION = new HashSet<CHARGE_TRANSACTION>();
        }

        [Key]
        public int CHARGE_NUMBER { get; set; }

        public int ADMISSION_NUMBER { get; set; }

        public int ITEM_CODE { get; set; }

        public byte QUANTITY { get; set; }

        public DateTime DATE_CHARGED { get; set; }

        public virtual ADMISSION ADMISSION { get; set; }

        public virtual ITEM ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARGE_TRANSACTION> CHARGE_TRANSACTION { get; set; }
    }
}
