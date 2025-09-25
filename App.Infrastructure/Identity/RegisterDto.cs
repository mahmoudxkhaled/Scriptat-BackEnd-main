namespace App.Infrastructure
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string UserJobTitle { get; set; }

        public string UserFullName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
