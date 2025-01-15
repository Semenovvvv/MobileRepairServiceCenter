namespace MobileRepair.Data.Models
{
    public class Device
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ApplicationUser Client { get; set; }
        public string Type { get; set; }
        public DateTime? DateBy {  get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? SerialNumber { get; set; }
        public bool? IsWarranty {  get; set; }
    }
}
