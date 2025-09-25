using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class SceneParagraphType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public bool AllowedForUser { get; set; }

        public List<SceneParagraph> SceneParagraphs { get; set; }
    }
}
