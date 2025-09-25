using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ProjectElement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ElementName { get; set; }

        public string ElementDescription { get; set; }

        public bool IsApprove { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ApproveTime { get; set; }

        public string? ApproveUserId { get; set; }

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
        public virtual int ProjectId { get; set; }

        [Required]
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [Required]
        public virtual int ComponentTypeId { get; set; }

        [Required]
        [ForeignKey("ComponentTypeId")]
        public virtual ComponentType ComponentType { get; set; }

        public virtual List<SceneParagraphLink> SceneParagraphLinks { get; set; }

        public virtual List<ProjectElementImage> ProjectElementImages { get; set; }

        public virtual List<ProjectElementLink> ProjectElementLinks { get; set; }
    }
}
