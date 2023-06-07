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
using static Diplom.User;
using System.Data.Entity;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        ApplicationContext db;

        public Registration()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        public void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if(login.Length < 3)
            {
                FailBlock.Text = "Слишком короткий логин";
                FailBlock.Visibility = Visibility.Visible;
                textBoxLogin.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                FailBlock.Text = "Слишком короткий пароль";
                FailBlock.Visibility = Visibility.Visible;
                passBox.Background = Brushes.Red;
            }
            else if (pass != pass_2)
            {
                passBox_2.Background = Brushes.Red;
                FailBlock.Text = "Пароли не совпадают";
                FailBlock.Visibility = Visibility.Visible;
            }
            else if (email.Length < 5 || !email.Contains ("@") || !email.Contains("."))
            {
                textBoxEmail.Background = Brushes.Red;
                FailBlock.Text = "Некорректная электронная почта";
                FailBlock.Visibility = Visibility.Visible;
            } 
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;



                MainWindow window = new MainWindow();
                window.Show();


                Close();

                User user = new User(login, pass, email);

                db.Users.Add(user);
                db.SaveChanges();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
