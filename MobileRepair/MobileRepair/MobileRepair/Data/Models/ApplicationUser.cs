using Microsoft.AspNetCore.Identity;

namespace MobileRepair.Data
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }
        public DateTime CreatedDate { get; set; }


        public string? Position { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
