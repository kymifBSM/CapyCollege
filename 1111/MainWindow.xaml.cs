using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
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

namespace _1111
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn1(object sender, RoutedEventArgs e)
        {
            MailAddress from = new MailAddress("sandmanfin@gmail.com", "Tom");

            MailAddress to = new MailAddress("korch.igor.98@list.ru");

            MailMessage m = new MailMessage(from, to);

            m.Subject = "Тест";

            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";

            m.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new NetworkCredential("sandmanfin@gmail.com", "jbmn vfnt ykhk wmxp");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
