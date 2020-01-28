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
using StudentManagementSystem.Model;

namespace StudentManagementSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Business _business;
        private Admin _admin;

        public LoginWindow()
        {
            InitializeComponent();
            _business = new Business();
            _admin = new Admin();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _admin.Username = txtUsername.Text;
                _admin.Password = txtPassword.Password;

                bool status = _business.Login(_admin);
                if (status)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username and password is incorrect !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
