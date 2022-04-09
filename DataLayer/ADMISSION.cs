namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMISSION")]
    public partial class ADMISSION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADMISSION()
        {
            CHARGEs = new HashSet<CHARGE>();
            NOTEs = new HashSet<NOTE>();
            PATIENTs = new HashSet<PATIENT>();
        }

        [Key]
        public int ADMISSION_NUMBER { get; set; }

        public int PATIENT_NUMBER { get; set; }

        public DateTime DATE_ADMITTED { get; set; }

        public DateTime? DATE_DISCHARGED { get; set; }

        public short ROOM_NUMBER { get; set; }

        [Required]
        [StringLength(1)]
        public string BED_CHAR { get; set; }

        public virtual BED BED { get; set; }

        public virtual PATIENT PATIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHARGE> CHARGEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTE> NOTEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATIENT> PATIENTs { get; set; }
    }
}
