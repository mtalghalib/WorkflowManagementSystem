namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsherAppointed")]
    public partial class UsherAppointed
    {
        public int UsherAppointedId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateAppointed { get; set; }

        public int UsherId { get; set; }

        public int EventProjectId { get; set; }

        public int PEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EventProject EventProject { get; set; }

        public virtual Usher Usher { get; set; }
    }
}
