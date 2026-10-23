namespace test_02_5
{
    public class IoTLogModel
    {
        public string Timestamp { get; set; }     // Thời gian ghi nhận
        public double Temperature { get; set; }   // Nhiệt độ (°C)
        public string Status { get; set; }        // Trạng thái (Bình thường / Cảnh báo)

        public IoTLogModel() { }

        public IoTLogModel(string timestamp, double temperature, string status)
        {
            Timestamp = timestamp;
            Temperature = temperature;
            Status = status;
        }
    }
}