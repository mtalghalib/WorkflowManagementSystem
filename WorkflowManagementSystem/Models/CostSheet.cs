namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CostSheet")]
    public partial class CostSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CostSheet()
        {
            CostSheetItems = new HashSet<CostSheetItem>();
           // CostVariance = new HashSet<CostVariance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CostSheetId { get; set; }

        public int Status { get; set; }

        public int CDecision { get; set; }

        [StringLength(300)]
        public string CFeedback { get; set; }

        public int FDecision { get; set; }

        [StringLength(300)]
        public string FFeedback { get; set; }

        public int PEmployeeId { get; set; }

        public int EventProjectId { get; set; }

        public int CEmployeeId { get; set; }

        public int FEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostSheetItem> CostSheetItems { get; set; }

        public virtual EventProject EventProject { get; set; }

        public virtual Employee FinanceEmployee { get; set; }

        public virtual Employee ProductionEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CostVariance> CostVariances { get; set; }
        public virtual CostVariance CostVariance { get; set; }
    }
}
