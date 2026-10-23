namespace test_02_3.Models;

public class Student
{
    public string MaSv { get; set; } = "";
    public string HoTen { get; set; } = "";
    public DateTime NgaySinh { get; set; } = DateTime.Today.AddYears(-20);
    public string GioiTinh { get; set; } = "Nam";
    public string MaLop { get; set; } = "";
    public string Email { get; set; } = "";
    public string DienThoai { get; set; } = "";
}
