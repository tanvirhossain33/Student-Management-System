using System;
using System.Windows;
using StudentManagementSystem.Infrastructure;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            (this.DataContext as MainWindowViewModel).ShowMessageBox += delegate(object sender, EventArgs args)
            {
                MessageBox.Show(((MessageEventArgs) args).Message);
            };
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
