namespace ATMWindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Login();
        }

        private static void Login()
        {
            ATMLogin loginForm = new ATMLogin();
            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
                // MainForm is defined elsewhere
                Application.Run(new HomePage(loginForm.GetUser(), loginForm.GetUserService(), loginForm.GetBankService(), loginForm.GetTransactionService()));
            }
        }
    }
}