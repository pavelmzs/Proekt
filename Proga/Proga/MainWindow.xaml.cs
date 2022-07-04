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

namespace Proga
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double[] dataX = new double[] { 5432, 3566, 3467, 6578, 5322 };
            DateTime[] date = new DateTime[5];
            for(int i = 0; i < date.Length; i++)
            {
                date[i] = new DateTime(2020, 11, 1).AddDays(1 * i);
            }
            double[] da = date.Select(x => x.ToOADate()).ToArray();
            Chart.Plot.AddScatter(da, dataX);
            Chart.Plot.XAxis.DateTimeFormat(true);
            Chart.Refresh();
        }
    }
}
