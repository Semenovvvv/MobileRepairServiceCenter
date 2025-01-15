namespace MobileRepair.Interfaces
{
    public interface IExportService
    {
        public Task<byte[]> ExportOrdersAsync(DateTime? startDate, DateTime? endDate, int? maxRecords);
        public Task<byte[]> ExportDevicesAsync(DateTime? startDate, DateTime? endDate, int? maxRecords);
        public Task<byte[]> ExportClientsAsync(int? maxRecords);
        public Task<byte[]> ExportOrderHistoryAsync(DateTime? startDate, DateTime? endDate, int? maxRecords);
    }
}
