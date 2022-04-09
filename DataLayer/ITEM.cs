namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEM")]
    public partial class ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITEM()
        {
            CHARGEs = new HashSet<CHARGE>();
        }

        [Key]
        public int ITEM_CODE { get; set; }

        public byte COST_CENTER_NUMBER { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHARGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARGE> CHARGEs { get; set; }

        public virtual COST_CENTER COST_CENTER { get; set; }
    }
}
