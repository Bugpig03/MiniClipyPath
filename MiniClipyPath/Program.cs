namespace MiniClipyPath
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainForm mainForm = new MainForm();
            mainForm.initButtonName();
            Application.Run(mainForm);
        }
    }
}