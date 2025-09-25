using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ProjectPart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("PartNo", TypeName = "int")]
        public int PartNo { get; set; }

        [Required]
        [Column("ProjectPartTitle", TypeName = "nvarchar(MAX)")]
        public string ProjectPartTitle { get; set; }

        [Column("ProjectPartSummary", TypeName = "nvarchar(MAX)")]
        public string? ProjectPartSummary { get; set; }

        public string? ProjectPartSummaryFileUrl { get; set; }

        [Column("ProjectPartIntroduction", TypeName = "nvarchar(MAX)")]
        public string? ProjectPartIntroduction { get; set; }

        public string? ProjectPartFileUrl { get; set; }

        public int? ProjectPartPageCount { get; set; }

        public int? ProjectPartWordCount { get; set; }

        public int? ProjectPartSceneCount { get; set; }

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
        public virtual int ScriptTypeId { get; set; }

        [Required]
        [ForeignKey("ScriptTypeId")]
        public virtual ScriptType ScriptType { get; set; }

        public List<Scene>? Scenes { get; set; }

        public List<ProjectPartParagraph>? ProjectPartParagraphs { get; set; }
    }
}
