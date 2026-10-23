using test_02_3.Models;

namespace test_02_3.Data;

internal static class SchoolRepository
{
    public static List<Student> Students { get; } =
    [
        new() { MaSv = "SV001", HoTen = "Nguyễn Văn An", NgaySinh = new DateTime(2004, 5, 12), GioiTinh = "Nam", MaLop = "CNTT01", Email = "an.nguyen@school.edu.vn", DienThoai = "0901111222" },
        new() { MaSv = "SV002", HoTen = "Trần Thị Bích", NgaySinh = new DateTime(2005, 1, 20), GioiTinh = "Nữ", MaLop = "CNTT01", Email = "bich.tran@school.edu.vn", DienThoai = "0902222333" },
        new() { MaSv = "SV003", HoTen = "Lê Hoàng Nam", NgaySinh = new DateTime(2004, 9, 8), GioiTinh = "Nam", MaLop = "KTPM02", Email = "nam.le@school.edu.vn", DienThoai = "0903333444" }
    ];

    public static List<Teacher> Teachers { get; } =
    [
        new() { MaGv = "GV001", HoTen = "Phạm Minh Tuấn", HocVi = "Tiến sĩ", ChuyenMon = "Cơ sở dữ liệu", DienThoai = "0911111222", Email = "tuan.pham@school.edu.vn" },
        new() { MaGv = "GV002", HoTen = "Đỗ Thị Lan", HocVi = "Thạc sĩ", ChuyenMon = "Lập trình .NET", DienThoai = "0912222333", Email = "lan.do@school.edu.vn" },
        new() { MaGv = "GV003", HoTen = "Vũ Quốc Huy", HocVi = "Thạc sĩ", ChuyenMon = "Mạng máy tính", DienThoai = "0913333444", Email = "huy.vu@school.edu.vn" }
    ];

    public static List<SchoolClass> Classes { get; } =
    [
        new() { MaLop = "CNTT01", TenLop = "Công nghệ thông tin 01", Khoa = "CNTT", SiSo = 45, Gvcn = "Đỗ Thị Lan" },
        new() { MaLop = "KTPM02", TenLop = "Kỹ thuật phần mềm 02", Khoa = "CNTT", SiSo = 40, Gvcn = "Phạm Minh Tuấn" },
        new() { MaLop = "QTKD01", TenLop = "Quản trị kinh doanh 01", Khoa = "Kinh tế", SiSo = 50, Gvcn = "Vũ Quốc Huy" }
    ];

    public static List<Course> Courses { get; } =
    [
        new() { MaMh = "MH001", TenMh = "Lập trình Windows Forms", SoTinChi = 3, SoTiet = 45, Khoa = "CNTT" },
        new() { MaMh = "MH002", TenMh = "Cơ sở dữ liệu", SoTinChi = 3, SoTiet = 45, Khoa = "CNTT" },
        new() { MaMh = "MH003", TenMh = "Mạng máy tính", SoTinChi = 2, SoTiet = 30, Khoa = "CNTT" }
    ];
}
