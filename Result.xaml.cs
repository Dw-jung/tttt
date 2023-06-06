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

namespace Wpf_pr8
{
    /// <summary>
    /// Логика взаимодействия для Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        public Result()
        {
            InitializeComponent();

            if (Window1.bPerimetr == true)
            {
                tbPerimeter.Text = Convert.ToString(Math.Round(Window1.perimetr, 3));
            }
            else tbPerimeter.Text = "Вы не выбрали";

            if (Window1.bArea == true)
            {
                tbArea.Text = Convert.ToString(Math.Round(Window1.area, 3));
            }
            else tbArea.Text = "Вы не выбрали";

            if (Window1.bMedian == true)
            {
                tbMedian.Text = Convert.ToString(Math.Round(Window1.median, 3));
            }
            else tbMedian.Text = "Вы не выбрали";

            if (Window1.bBisector == true)
            {
                tbBisector.Text = Convert.ToString(Math.Round(Window1.bisector, 3));
            }
            else tbBisector.Text = "Вы не выбрали";

            /*tbPerimeter.Text = Convert.ToString(Window1.perimetr);
            tbArea.Text = Convert.ToString(Window1.area);
            tbMedian.Text = Convert.ToString(Window1.median);
            tbBisector.Text = Convert.ToString(Window1.bisector);*/
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
