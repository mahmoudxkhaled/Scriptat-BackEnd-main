using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ProjectElementImage
    {
        [Key]
        public int Id { get; set; }

        public string ElementImageTitle { get; set; }

        public string ElementImageUrl { get; set; }

        [Required]
        public virtual int ProjectElementId { get; set; }

        [Required]
        [ForeignKey("ProjectElementId")]
        public virtual ProjectElement ProjectElement { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime InsertionDate { get; set; }

        [Required]
        public string UserId { get; set; }

        public bool IsApprove { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ApproveTime { get; set; }

        public string? ApproveUserId { get; set; }

        public bool IsDelete { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DeleteTime { get; set; }

        public string? DeleteUserId { get; set; }
    }
}
