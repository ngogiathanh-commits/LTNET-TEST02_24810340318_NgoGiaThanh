namespace test_02_3;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            using var login = new frmLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                break;
            }

            AppSession.RequestRelogin = false;
            Application.Run(new frmSchoolMain());

            if (!AppSession.RequestRelogin)
            {
                break;
            }
        }
    }
}
