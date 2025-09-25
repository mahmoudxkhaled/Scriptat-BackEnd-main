using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class SceneParagraph
    {
        [Key]
        public int Id { get; set; }

        public int OrderNo { get; set; }

        public string ParagraphText { get; set; }

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

        public virtual int? SceneParagraphTypeId { get; set; }

        [Required]
        [ForeignKey("SceneParagraphTypeId")]
        public virtual SceneParagraphType? SceneParagraphType { get; set; }

        public List<SceneParagraphLink> SceneParagraphLinks { get; set; }
    }
}
