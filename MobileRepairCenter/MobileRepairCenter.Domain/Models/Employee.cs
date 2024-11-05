namespace MobileRepairCenter.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic {  get; set; }
        public string? Position { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
