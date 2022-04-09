namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DB_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DB_USER()
        {
            PHYSICIANs = new HashSet<PHYSICIAN>();
        }

        [Key]
        public int USER_ID { get; set; }

        public short USER_TYPE_NUMBER { get; set; }

        [Required]
        [StringLength(40)]
        public string PASSWORD { get; set; }

        public virtual USER_TYPE USER_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHYSICIAN> PHYSICIANs { get; set; }
    }
}
