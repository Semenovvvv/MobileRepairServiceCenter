namespace MobileRepairCenter.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int DeviceId {  get; set; }
        public Device Device { get; set; }
        public DateTime DateBy { get; set; }
        public DateTime? DateEnd { get; set; }
        public string? Descryption {  get; set; }
        public string Status { get; set; }
        public decimal Price {  get; set; }
    }
}
