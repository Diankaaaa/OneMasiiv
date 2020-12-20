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

namespace OneMasiiv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public int[] Parse_String(string str)
        {
            return str.Split(' ').Select(x => int.Parse(x)).ToArray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string num = INPUT.Text;
                string re = " ";
                int[] nums = Parse_String(num);
                int[] sum_mas = Parse_String(num); 
                
               
                string st = " "; 
                
                for (int g = 0; g < nums.Length; g++)
                {
                    st += nums[g] + " ";
                }

                for(int d = 0; d < nums.Length; d++)
                {
                        int n1 = nums[d] / 10;
                        int n2 = nums[d] % 10;
                        sum_mas[d] = n1 + n2;
                        re += sum_mas[d] + " ";             
                }
                OUTPUT.Text += "Исходный массив: " + st + " " + Environment.NewLine;
                OUTPUT.Text += "Массив сумм: " + re + " " + Environment.NewLine;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OUTPUT.Text = String.Empty;
        }
    }
}
