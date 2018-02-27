namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CostVarianceItem")]
    public partial class CostVarianceItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CostVarId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItmId { get; set; }

        public decimal ActualCost { get; set; }

        public int ActualQuantity { get; set; }

        public virtual CostVariance CostVariance { get; set; }

        public virtual Item Item { get; set; }
    }
}
