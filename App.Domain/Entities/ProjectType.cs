using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ProjectType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProjectTypeTitle { get; set; }

        public List<Project> Projects { get; set; }
    }
}
