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
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Windows.Navigation;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Tasks.xaml
    /// </summary>
    public partial class Tasks : System.Windows.Window
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Lession_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Лекции_первый курс.docx"));
            app.Visible = true;
        }

        private void Pr_1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_1.doc"));
            app.Visible = true;

        }

        private void Pr_2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_2.docx"));
            app.Visible = true;
        }

        private void Pr_3_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_3.doc"));
            app.Visible = true;
        }

        private void Pr_3_1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_3_1.doc"));
            app.Visible = true;
        }

        private void Pr_3_2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_3_2.docx"));
            app.Visible = true;
        }

        private void Pr_4_1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_4_1.docx"));
            app.Visible = true;
        }

        private void Pr_4_2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_4_2.docx"));
            app.Visible = true;
        }

        private void Pr_4_5_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_4_5.docx"));
            app.Visible = true;
        }

        private void Pr_5_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_5.docx"));
            app.Visible = true;
        }

        private void Pr_5_1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_5.docx"));
            app.Visible = true;
        }

        private void Pr_6_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_6.doc"));
            app.Visible = true;
        }

        private void Pr_6_2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_6_2.docx"));
            app.Visible = true;
        }

        private void Pr_7_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_7.doc"));
            app.Visible = true;
        }

        private void Pr_8_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_8.docx"));
            app.Visible = true;
        }

        private void Pr_9_10_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_9_и_10.docx"));
            app.Visible = true;
        }

        private void Pr_11_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_11.doc"));
            app.Visible = true;
        }

        private void Pr_11_1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_11.docx"));
            app.Visible = true;
        }

        private void Pr_12_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_12.docx"));
            app.Visible = true;
        }

        private void Pr_13_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_13.docx"));
            app.Visible = true;
        }

        private void Pr_13Sl_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_13_сложная.docx"));
            app.Visible = true;
        }

        private void Pr_14_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_14.docx"));
            app.Visible = true;
        }

        private void Pr_15_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_15.docx"));
            app.Visible = true;
        }

        private void Pr_16_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_16.doc"));
            app.Visible = true;
        }

        private void Pr_16_1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_16.docx"));
            app.Visible = true;
        }

        private void Pr_17_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_17.docx"));
            app.Visible = true;
        }

        private void Pr_18_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_18.docx"));
            app.Visible = true;
        }

        private void Pr_19_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_19.docx"));
            app.Visible = true;
        }

        private void Pr_21_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_21.docx"));
            app.Visible = true;
        }

        private void Pr_22_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_22.docx"));
            app.Visible = true;
        }

        private void Pr_23_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_23.doc"));
            app.Visible = true;
        }

        private void Pr_24_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_24.doc"));
            app.Visible = true;
        }

        private void Pr_25_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_25.doc"));
            app.Visible = true;
        }

        private void Pr_26_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document document = app.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа_26.docx"));
            app.Visible = true;

        }

        private void BtnUsExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void Btn_Komplekt_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            Document document = ap.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Кос_1курс (2).docx"));
            ap.Visible = true;
        }
        private void Pr_29_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            Document document = ap.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Практическая работа 29.docx"));
            ap.Visible = true;
        }

        private void Test_1_Click(object sender, RoutedEventArgs e)
        {
         Window1 ylica1 =  new Window1();
            ylica1.Show();
            Close();
        }

        private void Test_2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Test_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Test_4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Test_5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Test_6_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
