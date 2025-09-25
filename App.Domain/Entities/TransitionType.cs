using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class TransitionType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? TitleAr { get; set; }

        [Required]
        public string? TitleEn { get; set; }

        [Required]
        public int TransitionValue { get; set; }

        public List<Scene> Scenes { get; set; }
    }
}
