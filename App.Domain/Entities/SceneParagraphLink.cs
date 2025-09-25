using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class SceneParagraphLink
    {
        [Key]
        public int Id { get; set; }

        public int? RequiredCount { get; set; }

        public string? ElementText { get; set; }

        public int? ParagraphElementIndex { get; set; }

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
        public virtual int SceneId { get; set; }

        [Required]
        [ForeignKey("SceneId")]
        public virtual Scene Scene { get; set; }

        public virtual int? SceneParagraphId { get; set; }

        [ForeignKey("SceneParagraphId")]
        public virtual SceneParagraph? SceneParagraph { get; set; }

        [Required]
        public virtual int ProjectElementId { get; set; }

        [Required]
        [ForeignKey("ProjectElementId")]
        public virtual ProjectElement ProjectElement { get; set; }
    }
}
