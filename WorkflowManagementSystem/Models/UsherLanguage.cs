namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsherLanguage")]
    public partial class UsherLanguage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UshId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string Language { get; set; }

        public virtual Usher Usher { get; set; }
    }
}
