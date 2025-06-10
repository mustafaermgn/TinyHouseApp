namespace TinyHouseApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
