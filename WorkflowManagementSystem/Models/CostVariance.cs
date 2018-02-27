namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CostVariance")]
    public partial class CostVariance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CostVariance()
        {
            CostVarianceItems = new HashSet<CostVarianceItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CostVarianceId { get; set; }

        public int? Analysis { get; set; }

        [StringLength(300)]
        public string Note { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateSubmitted { get; set; }

        public int FEmployeeId { get; set; }

        public int CostSheetId { get; set; }

        public virtual CostSheet CostSheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostVarianceItem> CostVarianceItems { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
