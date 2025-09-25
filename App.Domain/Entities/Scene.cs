using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class Scene
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderNo { get; set; }

        [Required]
        public int SceneNo { get; set; }

        [Required]
        public string? SceneNoText { get; set; }

        public string? SceneDescription { get; set; }

        public int? SceneTime { get; set; }

        public int? LocationType { get; set; }

        public string? SceneTimeText { get; set; }

        public string? SceneTransitionType { get; set; }

        public string? SceneTransitionTypeText { get; set; }

        [Required]
        public int StartingParagraphIndex { get; set; }

        [Required]
        public int EndingParagraphIndex { get; set; }

        public string? SceneBreakdownStartUserId { get; set; }

        public DateTime? SceneBreakdownStartTime { get; set; }

        public string? SceneBreakdownEndUserId { get; set; }

        public DateTime? SceneBreakdownEndTime { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime InsertionDate { get; set; }

        [Required]
        public string UserId { get; set; }

        public bool IsDelete { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DeleteTime { get; set; }

        public string? DeleteUserId { get; set; }

        public virtual int? TransitionTypeId { get; set; }

        [ForeignKey("TransitionTypeId")]
        public virtual TransitionType? TransitionType { get; set; }

        [Required]
        public virtual int ProjectPartId { get; set; }

        [Required]
        [ForeignKey("ProjectPartId")]
        public virtual ProjectPart ProjectPart { get; set; }

        public List<SceneParagraph> SceneParagraphs { get; set; }
    }
}
