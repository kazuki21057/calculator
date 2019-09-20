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

namespace calculator
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] input;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button0.Content.ToString();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button1.Content.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button2.Content.ToString();

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button3.Content.ToString();

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button4.Content.ToString();

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button5.Content.ToString();

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button6.Content.ToString();

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button7.Content.ToString();

        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button8.Content.ToString();

        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button9.Content.ToString();

        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += buttonDot.Content.ToString();

        }

        private void Button_equ_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button_equ.Content.ToString();

        }

        private void Button_plu_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button_plu.Content.ToString();

        }

        private void Button_min_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button_min.Content.ToString();

        }

        private void Button_mal_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button_mal.Content.ToString();

        }

        private void Button_dev_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += button_dev.Content.ToString();

        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += buttonC.Content.ToString();

        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += buttonAC.Content.ToString();

        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            calculateBox.Text += buttonReset.Content.ToString();

        }

    }
}
