using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using MobileRepair.Data;
using MobileRepair.Interfaces;

namespace MobileRepair.Services;

public class ExportService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : IExportService
{
    public async Task<byte[]> ExportOrdersAsync(DateTime? startDate, DateTime? endDate, int? maxRecords)
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();
        var query = dbContext.Orders.Include(o => o.Device)
            .Include(o => o.Device.Client)
            .AsQueryable();

        if (startDate.HasValue)
            query = query.Where(o => o.DateBy >= startDate.Value);

        if (endDate.HasValue)
            query = query.Where(o => o.DateBy <= endDate.Value);

        if (maxRecords.HasValue)
            query = query.Take(maxRecords.Value);

        var orders = await query.ToListAsync();

        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Orders");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Устройство";
        worksheet.Cell(1, 3).Value = "Клиент";
        worksheet.Cell(1, 4).Value = "Статус";
        worksheet.Cell(1, 5).Value = "Описание";
        worksheet.Cell(1, 6).Value = "Дата";

        for (var i = 0; i < orders.Count; i++)
        {
            var order = orders[i];
            worksheet.Cell(i + 2, 1).Value = order.Id;
            worksheet.Cell(i + 2, 2).Value = $"{order.Device.Manufacturer} {order.Device.Model}";
            worksheet.Cell(i + 2, 3).Value = order.Device.Client?.Surname + order.Device.Client?.Name + order.Device.Client?.Patronymic;
            worksheet.Cell(i + 2, 4).Value = order.Status;
            worksheet.Cell(i + 2, 5).Value = order.Descryption;
            worksheet.Cell(i + 2, 6).Value = order.DateBy;
        }

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }

    public async Task<byte[]> ExportDevicesAsync(DateTime? startDate, DateTime? endDate, int? maxRecords)
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();
        var query = dbContext.Devices.AsQueryable();

        if (startDate.HasValue)
            query = query.Where(d => d.DateBy >= startDate.Value);

        if (endDate.HasValue)
            query = query.Where(d => d.DateBy <= endDate.Value);

        if (maxRecords.HasValue)
            query = query.Take(maxRecords.Value);

        var devices = await query.ToListAsync();

        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Devices");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Производитель";
        worksheet.Cell(1, 3).Value = "Модель";
        worksheet.Cell(1, 4).Value = "Тип устройства";
        worksheet.Cell(1, 5).Value = "Дата добавления";

        for (int i = 0; i < devices.Count; i++)
        {
            var device = devices[i];
            worksheet.Cell(i + 2, 1).Value = device.Id;
            worksheet.Cell(i + 2, 2).Value = device.Manufacturer;
            worksheet.Cell(i + 2, 3).Value = device.Model;
            worksheet.Cell(i + 2, 4).Value = device.Type;
            worksheet.Cell(i + 2, 5).Value = device.DateBy;
        }

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }

    public async Task<byte[]> ExportClientsAsync(int? maxRecords)
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();
        var query = dbContext.Users.AsQueryable();

        if (maxRecords.HasValue)
            query = query.Take(maxRecords.Value);

        var clients = await query.ToListAsync();

        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Clients");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Фамилия";
        worksheet.Cell(1, 3).Value = "Имя";
        worksheet.Cell(1, 4).Value = "Отчество";
        worksheet.Cell(1, 5).Value = "Почта";
        worksheet.Cell(1, 6).Value = "Телефонный номер";

        for (int i = 0; i < clients.Count; i++)
        {
            var client = clients[i];
            worksheet.Cell(i + 2, 1).Value = client.Id;
            worksheet.Cell(i + 2, 2).Value = client.Surname;
            worksheet.Cell(i + 2, 3).Value = client.Name;
            worksheet.Cell(i + 2, 4).Value = client.Patronymic;
            worksheet.Cell(i + 2, 5).Value = client.Email;
            worksheet.Cell(i + 2, 6).Value = client.PhoneNumber;
        }

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }

    public async Task<byte[]> ExportOrderHistoryAsync(DateTime? startDate, DateTime? endDate, int? maxRecords)
    {
        await using var dbContext = await dbContextFactory.CreateDbContextAsync();
        var query = dbContext.OrdersHistory.Include(h => h.Order)
            .AsQueryable();

        if (startDate.HasValue)
            query = query.Where(h => h.EditDate >= startDate.Value);

        if (endDate.HasValue)
            query = query.Where(h => h.EditDate <= endDate.Value);

        if (maxRecords.HasValue)
            query = query.Take(maxRecords.Value);

        var histories = await query.ToListAsync();

        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("OrderHistory");

        worksheet.Cell(1, 1).Value = "Order ID";
        worksheet.Cell(1, 2).Value = "Старый статус";
        worksheet.Cell(1, 3).Value = "Новый статус";
        worksheet.Cell(1, 4).Value = "Примечание";
        worksheet.Cell(1, 5).Value = "Дата изменения статуса";

        for (int i = 0; i < histories.Count; i++)
        {
            var history = histories[i];
            worksheet.Cell(i + 2, 1).Value = history.Order.Id;
            worksheet.Cell(i + 2, 2).Value = history.OldStatus;
            worksheet.Cell(i + 2, 3).Value = history.NewStatus;
            worksheet.Cell(i + 2, 4).Value = history.Note;
            worksheet.Cell(i + 2, 5).Value = history.EditDate;
        }

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }
}


