namespace App.Infrastructure
{
    public class AspNetUserDevices
    {
        public int Id { get; set; }
        public string? DeviceId { get; set; }
        public string TokenKey { get; set; }
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;
        public DateTime? LogoutTime { get; set; }
        public DateTime ExpireTime { get; set; } = DateTime.UtcNow.AddDays(7);
        public bool IsExpired => DateTime.UtcNow >= ExpireTime;
        public DateTime? RevokeTime { get; set; }
        public bool IsActive => RevokeTime == null && !IsExpired;
        public int? DeviceType { get; set; } // 1 = WebBrowser , 2 = Android , 3 = IOS
        public string? DeviceVersion { get; set; } // 1 = WebBrowser , 2 = Android , 3 = IOS
        public ApplicationUser ApplicationUser { get; set; }
    }
}
