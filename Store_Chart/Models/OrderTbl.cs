namespace Store_Chart.Models
{
    public class OrderTbl
    {
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public int ItemQty { get; set; }
        public DateTime OrderDelivery { get; set; }
        public string? OrderAddress { get; set; }
        public string? PhoneNumber { get; set; }

        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(ItemCode);
    }
}
