namespace WorkflowManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventProject")]
    public partial class EventProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventProject()
        {
            ClientSatisfactions = new HashSet<ClientSatisfaction>();
            CostSheets = new HashSet<CostSheet>();
            Documents = new HashSet<Document>();
            ProjectSchedules = new HashSet<ProjectSchedule>();
            EmployeeTasks = new HashSet<EmployeeTask>();
            UsherAppointeds = new HashSet<UsherAppointed>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventProjectId { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string EventType { get; set; }

        [Required]
        [StringLength(1000)]
        public string Brief { get; set; }

        [StringLength(25)]
        public string Street { get; set; }

        [StringLength(25)]
        public string District { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string Presentation { get; set; }

        [StringLength(200)]
        public string EventReportTemplate { get; set; }

        [StringLength(200)]
        public string EventReport { get; set; }

        [StringLength(200)]
        public string ThreeDModel { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        public int CSEmployeeId { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientSatisfaction> ClientSatisfactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostSheet> CostSheets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSchedule> ProjectSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeTask> EmployeeTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsherAppointed> UsherAppointeds { get; set; }
    }
}
