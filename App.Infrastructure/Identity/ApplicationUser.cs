using Microsoft.AspNetCore.Identity;

namespace App.Infrastructure
{
    public class ApplicationUser : IdentityUser
    {
        public string UserFullName { get; set; }
        public string UserJobTitle { get; set; }
        public string? UserImageUrl { get; set; }
        public ICollection<AspNetUserDevices> AspNetUserDevices { get; set; } = new List<AspNetUserDevices>();

    }
}
