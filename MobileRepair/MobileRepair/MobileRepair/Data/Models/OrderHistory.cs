namespace MobileRepair.Data.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public DateTime? EditDate { get; set; }
        public string? OldStatus { get; set; }
        public string? NewStatus { get; set; }
        public string? Note { get; set; }
        public ApplicationUser? EditUser { get; set; }
        public int? EditUserId { get; set; }
    }
}
