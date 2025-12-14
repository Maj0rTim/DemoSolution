namespace DemoFrontEnd.Models
{
    public class SystemUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
