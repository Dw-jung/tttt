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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void tbSideC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((tbSideA.Text==tbSideB.Text)&(tbSideB.Text==tbSideC.Text))
            {
                chbMedian.Visibility = Visibility.Visible;
                chbBisector.Visibility = Visibility.Visible;
            }
            else
            {
                chbMedian.Visibility = Visibility.Hidden;
                chbBisector.Visibility = Visibility.Hidden;
            }
        }

        private void tbSideA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789,".IndexOf(e.Text) < 0;
        }

        private void tbSideB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789,".IndexOf(e.Text) < 0;
        }

        private void tbSideC_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789,".IndexOf(e.Text) < 0;
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            /*double sideA = Convert.ToDouble(tbSideA.Text);
            double sideB = Convert.ToDouble(tbSideB.Text);
            double sideC = Convert.ToDouble(tbSideC.Text);*/
            if ((tbSideA.Text==null)&&(tbSideB.Text == null)&&(tbSideC.Text == null))
            {
                MessageBox.Show("Пожалуйста введите данные!", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Warning); ;
            }
            else
            {
                Result newW = new Result();
                newW.Show();
            }

        }



        static public double perimetr;
        static public bool bPerimetr;
        private void chbPerimetr_Checked(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tbSideA.Text);
            double b = Convert.ToDouble(tbSideB.Text);
            double c = Convert.ToDouble(tbSideC.Text);
            perimetr = a + b + c;
            bPerimetr = true;
        }

        static public double area;
        static public bool bArea;
        private void chbArea_Checked(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tbSideA.Text);
            double b = Convert.ToDouble(tbSideB.Text);
            double c = Convert.ToDouble(tbSideC.Text);
            double P = (a + b + c)/2; //по формуле Герона
            area = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
            bArea = true;
        }

        // // // //     ТРЕУГОЛЬНИК ПРАВИЛЬНЫЙ
        static public double median;
        static public bool bMedian;
        private void chbMedian_Checked(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tbSideA.Text);
            median = 0.5 * Math.Sqrt(2 * (Math.Pow(a, 2) + Math.Pow(a, 2) - Math.Pow(a, 2))); 
            bMedian = true;
        }

        static public double bisector;
        static public bool bBisector;
        private void chbBisector_Checked(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tbSideA.Text);
            bisector = (a * Math.Sqrt(3)) / 2;
            bBisector = true;
        }
    }
}
