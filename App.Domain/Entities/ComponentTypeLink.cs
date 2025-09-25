using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ComponentTypeLink
    {
        [Key]
        public int Id { get; set; }

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
        [ForeignKey("ComponentType")]
        public virtual int ComponentTypeId { get; set; }

        [Required]
        [ForeignKey("ComponentTypeId")]
        public virtual ComponentType ComponentType { get; set; }

        [Required]
        public virtual int LinkedComponentTypeId { get; set; }
    }
}
