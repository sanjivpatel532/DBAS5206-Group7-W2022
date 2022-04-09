namespace LakeridgeCommunityHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOTE")]
    public partial class NOTE
    {
        [Key]
        public long NOTE_NUMBER { get; set; }

        public int ADMISSION_NUMBER { get; set; }

        [Required]
        [StringLength(200)]
        public string ENTRY { get; set; }

        public virtual ADMISSION ADMISSION { get; set; }
    }
}
