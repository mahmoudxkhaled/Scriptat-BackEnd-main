using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ComponentType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ComponentTitle { get; set; }

        public string? ComponentDescription { get; set; }

        public bool IsProjectElementLinkAllowed { get; set; }

        public bool IsProjectLocationLinkAllowed { get; set; }

        public bool IsProjectCharacterLinkAllowed { get; set; }

        public bool ElementCountALlowed { get; set; }

        public int OrderNo { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime InsertionDate { get; set; }

        [Required]
        public string UserId { get; set; }

        public bool IsDelete { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DeleteTime { get; set; }

        public string? DeleteUserId { get; set; }

        public virtual int? ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project? Project { get; set; }

        public virtual List<ProjectElement> ProjectElements { get; set; }

        public virtual List<ComponentTypeLink> ComponentTypeLinks { get; set; }
    }
}
