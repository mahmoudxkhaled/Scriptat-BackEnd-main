using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProjectTitle { get; set; }

        public string? ProjectCode { get; set; }

        public string? ProjectSummary { get; set; }

        public string? ProjectSummaryFileUrl { get; set; }

        public string? ProjectDescription { get; set; }

        [Required]
        public int ProjectPartCount { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime InsertionDate { get; set; }

        [Required]
        public string UserId { get; set; }

        public bool IsDelete { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DeleteTime { get; set; }

        public string? DeleteUserId { get; set; }

        [Required]
        public virtual int ProjectTypeId { get; set; }

        [Required]
        [ForeignKey("ProjectTypeId")]
        public virtual ProjectType ProjectType { get; set; }

        public List<ProjectPart> ProjectParts { get; set; }

        public List<ProjectElement> ProjectElements { get; set; }
    }
}
