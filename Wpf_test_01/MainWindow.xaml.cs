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

namespace Wpf_test_01
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void heightBoxBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
 
        private void WeightBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          if(IsInitiaized) // 當所有值都輸入後...
          {
          WeightBox.Text = WeightBar.Value.ToString();
            
            double w = double.Parse(WeightBox.Text) ;
            double h = double.Parse(HeightBox.Text) / 100;
            double bmi = w / (h * h);
            
            ResultBox.Text = bmi.ToString();
           }        
        }
}
