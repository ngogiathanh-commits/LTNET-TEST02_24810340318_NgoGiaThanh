namespace test_02_4
{
    public class InventoryReportModel
    {
        public string ItemCode { get; set; }        // Mã vật tư/Sản phẩm
        public string ItemName { get; set; }        // Tên vật tư
        public string Category { get; set; }        // Danh mục
        public int StockQuantity { get; set; }     // Số lượng tồn
        public decimal UnitPrice { get; set; }      // Đơn giá
        public decimal TotalValue { get; set; }     // Giá trị tồn kho
    }
}
