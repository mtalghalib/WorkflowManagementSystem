namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTask")]
    public partial class EmployeeTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeTask()
        {
            TaskAssignments = new HashSet<TaskAssignment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeTaskId { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public int Status { get; set; }

        public int Priority { get; set; }

        public int EventProjectId { get; set; }

        public int CSEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EventProject EventProject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }
    }
}
