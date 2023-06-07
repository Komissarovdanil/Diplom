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
using static Diplom.Tasks;
using Microsoft.Office.Interop.Word;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Lession1.xaml
    /// </summary>
    public partial class Lession1 : System.Windows.Window
    {
        public Lession1()
        {
            InitializeComponent();
            

            RichTextBox rtb = new RichTextBox();
            System.Windows.Documents.Paragraph p = rtb.Document.Blocks.FirstBlock as System.Windows.Documents.Paragraph;

            p.LineHeight = 12;
            p.Margin = new Thickness(12);

            switch (id)
            {
                case 1:
                    var text = File.ReadAllText(@"Resources/Лекция.txt");
                    LessionBox.Text = text;
                    break;
                case 2:
                    //StreamReader streamReader2 = new StreamReader(@"Resources\Приложение3.docx");
                    //LessionBox.Text = streamReader2.ReadToEnd();
                    //streamReader2.Close();
                    //Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
                    //Document document = ap.Documents.Open(@"C:\Users\Администратор\source\repos\Diplom\Diplom\bin\Debug\Resources\Приложение3.docx");
                    //ap.Visible = true;
                    break;
                
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Owner = this;
            Close();
        }
    }
}
