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
using Microsoft.Win32;
using System.Windows.Threading;

namespace Lab_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DispatcherTimer _timer;

        private void Lenght_TextChanged(object sender, TextChangedEventArgs e)
        {
            Area.Clear();
            Volume.Clear();
            if (int.TryParse(Lenght.Text, out int lenght))
            {
                Area.Text = $"{lenght * lenght}";
                Volume.Text = $"{lenght * lenght * lenght}";
            }
            else MessageBox.Show("Поле заполнено неверно или не заполнено");
        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            Ton.Clear();
            Kg.Clear();
            if (int.TryParse(Weight.Text, out int weight))
            {
                Ton.Text = $"{weight / 1000}";
                Kg.Text = $"{weight % 1000}";
            }
            else MessageBox.Show("Поле заполнено неверно или не заполнено");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("4. Реализовать расчет задачи:" +
                " Дана длина ребра куба А.Найти объем куба V и площадь его поверхности S." +
                " Дана масса M в килограммах.Используя операцию деления целых чисел, найти" +
                "количество полных тонн и килограмм(1 тонна = 1000 кг).");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (Lenght.Text != string.Empty) Lenght.Clear();
            if (Weight.Text != string.Empty) Weight.Clear();
        }

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Tick += Timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            _timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            date.Text = d.ToString("dd.MM.yyyy");
        }

    }
}
