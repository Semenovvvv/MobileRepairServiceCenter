﻿namespace MobileRepair.Data.Models
{
    public class Device
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientUser ClientUser { get; set; }
        public int? Type { get; set; }
        public DateTime? Date {  get; set; }
        public string IMEI { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public bool IsWarranty {  get; set; }
    }
}