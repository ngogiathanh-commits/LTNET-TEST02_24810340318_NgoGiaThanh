namespace test_02_3;

internal static class AppSession
{
    public static string Username { get; set; } = "admin";
    public static string Password { get; set; } = "123";
    public static string StaffName { get; set; } = "Cán bộ quản lý";
    public static bool RequestRelogin { get; set; }
}
