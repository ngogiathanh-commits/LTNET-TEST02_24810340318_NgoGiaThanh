using System;

namespace test_02_1
{
    public class BookingModel
    {
        public string BookingId { get; set; }        // Mã đặt phòng
        public string CustomerName { get; set; }     // Tên khách hàng
        public string IdentityCard { get; set; }     // Số CCCD/CMND
        public string RoomType { get; set; }         // Loại phòng
        public DateTime CheckInDate { get; set; }    // Ngày nhận phòng
        public int DaysCount { get; set; }           // Số ngày ở
        public decimal PricePerNight { get; set; }   // Giá phòng/đêm

        public BookingModel() { }

        public BookingModel(string bookingId, string customerName, string identityCard,
                            string roomType, DateTime checkInDate, int daysCount, decimal pricePerNight)
        {
            BookingId = bookingId;
            CustomerName = customerName;
            IdentityCard = identityCard;
            RoomType = roomType;
            CheckInDate = checkInDate;
            DaysCount = daysCount;
            PricePerNight = pricePerNight;
        }
    }
}
