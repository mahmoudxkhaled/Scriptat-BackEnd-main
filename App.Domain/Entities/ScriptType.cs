using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ScriptType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Instruction { get; set; }

        public string? InstructionImageUrl { get; set; }

        public List<ProjectPart> ProjectParts { get; set; }
    }
}
