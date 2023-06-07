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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();

            if (login.Length < 3)
            {
                textBoxLogin.ToolTip = "Поле введено некорректно";
                textBoxLogin.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Поле введено некорректно";
                passBox.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext db = new ApplicationContext()) {
                    authUser = db.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    Tasks tasks = new Tasks();
                    tasks.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены некорректно!");
                    passBox.Password = "";
                    textBoxLogin.ToolTip = "Введите логин";
                    passBox.ToolTip = "Введите пароль";
                }
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Owner = this;
            registration.Show();
            Hide();
            
        }

        private void BtnSkip_Click(object sender, RoutedEventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            Close();
        }
    }
}
