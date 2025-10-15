using System.Configuration;
using System.Data;
using System.Windows;
using StudentViolationApplication.View;

namespace StudentViolationApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new Login_View();
            loginView.Show();
            loginView.Closed += (s, ev) =>
            {
                // Once the login view is closed, show the main view
                var mainView = new MainView();
                mainView.Show();
            };
        }
            
            
     }
    

}
