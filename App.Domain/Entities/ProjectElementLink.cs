using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ProjectElementLink
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ElementLinkType { get; set; }

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
        [ForeignKey("ProjectElement")]
        public virtual int ProjectElementId { get; set; }

        [Required]
        [ForeignKey("ProjectElementId")]
        public virtual ProjectElement ProjectElement { get; set; }

        [Required]
        public virtual int LinkedProjectElementId { get; set; }
    }
}
