using JobScheduler.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace JobScheduler.WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Task task = new Task();
        public MainWindow()
        {
            InitializeComponent();
            dateAndTime.Value = DateTime.Now;
        }

        private void DateAndTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            task.FirstStart = (DateTime)dateAndTime.Value;
        }

        private void DownloadFile(string url)
        {
            using (var client = new WebClient())
            {
                string fileName = Path.GetFileName("http://video.wapos.ru/films/2011/04/11_14_1.mp4");
                client.DownloadFile(url, fileName);
            }
        }

        private void PeriodComboBox_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
