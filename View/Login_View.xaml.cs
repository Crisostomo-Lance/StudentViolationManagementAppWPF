using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentViolationApplication.View
{
    /// <summary>
    /// Interaction logic for Login_View.xaml
    /// </summary>
    public partial class Login_View : Window
    {
        public Login_View()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
            btnMaximize.Visibility = Visibility.Collapsed; // Hide maximize button
            btnNormal.Visibility = Visibility.Visible; // Show normalize button
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            btnMaximize.Visibility = Visibility.Visible; // Show maximize button
            btnNormal.Visibility = Visibility.Collapsed; // Hide normalize button
        }

        private void cmbUserType_Loaded(object sender, RoutedEventArgs e)
        {

        }


    }
}
