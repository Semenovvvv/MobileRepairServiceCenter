namespace MobileRepair.Constants
{
    public class OrderStatusConstants
    {
        public const string Created = "Заказ создан";
        public const string Consideration = "На рассмотрении";
        public const string Rejected = "Отклонен";
        public const string Accept = "Принят в работу";
        public const string Work = "В процессе ремонта";
        public const string Ready = "Готов к выдаче";
        public const string BeyondRepair = "Не подлежит ремонту";

        public static IDictionary<string, string> GetAllStatuses()
        {
            return new Dictionary<string, string>
            {
                { Created, "Заказ создан" },
                { Consideration, "На рассмотрении" },
                { Rejected, "Отклонен" },
                { Accept, "Принят в работу" },
                { Work, "В процессе ремонта" },
                { Ready, "Готов к выдаче" },
                { BeyondRepair, "Не подлежит ремонту" }

            };
        }
    }
}
