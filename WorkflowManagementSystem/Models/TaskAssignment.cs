namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskAssignment")]
    public partial class TaskAssignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskAssignmentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime AssignmentDate { get; set; }

        public int TaskId { get; set; }

        public int EmployeeId { get; set; }

        public int CSEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee AnyEmployee { get; set; }

        public virtual EmployeeTask EmployeeTask { get; set; }
    }
}
