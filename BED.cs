namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BED")]
    public partial class BED
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BED()
        {
            ADMISSIONs = new HashSet<ADMISSION>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ROOM_NUMBER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string BED_CHAR { get; set; }

        public short EXTENSION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADMISSION> ADMISSIONs { get; set; }

        public virtual ROOM ROOM { get; set; }
    }
}
