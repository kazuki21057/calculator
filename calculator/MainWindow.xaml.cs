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
        static readonly string FailedMessage = "failed";
        static readonly int MaxFormulaLength = 16;


        public MainWindow()
        {
            InitializeComponent();
            setEvents();
        }

        private void setEvents()
        {
            // Grid配下からボタンコントロールを探す
            foreach (var ctrl in LogicalTreeHelper.GetChildren(mainGrid))
            {
                if (!(ctrl is Button))
                {
                    continue;
                }
                // ctrlオブジェクトをButtonにアップキャストして，クリック処理を追加
                (ctrl as Button).Click += (sender, e) =>
                {
                    string input = (sender as Button).Content.ToString();
                    switch (input)
                    {
                        case "AC":
                            // all clear
                            History.Text = null;
                            calculateBox.Text = null;
                            break;
                        case "C":
                            // clear only calculationBox
                            calculateBox.Text = null;
                            break;
                        case "=":
                            if (calculateBox.Text == FailedMessage)
                            {
                                calculateBox.Text = "0";
                            }
                            else
                            {
                                calculateBox.Text = Calculate.calculation(calculateBox.Text);
                            }
                            break;
                        default:
                            if (MaxFormulaLength <= calculateBox.Text.Length)
                            {
                                break;
                            }
                            else if (calculateBox.Text == "0")
                            {
                                foreach (var letter in Calculate.operatorStr)
                                {
                                    if (letter == input)
                                        calculateBox.Text += input;
                                }
                                // 0が入力されているのに数字が入力されたら，数字を上書きする
                                calculateBox.Text = input;
                            }
                            else if (calculateBox.Text == FailedMessage)
                            {
                                // failedMessageでも数字を上書き
                                calculateBox.Text = input;
                            }
                            else if (input == ".")
                            {
                                // 二回以上'.'を入力しないようにする
                                foreach (var letter in calculateBox.Text)
                                {
                                    if (letter == '.')
                                    {
                                        MessageBox.Show("Can't input 'Dot' twice");
                                        break;
                                    }
                                }
                                calculateBox.Text += input;
                            }
                            else if (Calculate.operatorStr.Contains(input) && calculateBox.Text.EndsWith(input))
                            {
                                // calculateBoxの末尾がオペレータなら入力値に入れ替え
                                calculateBox.Text.Remove(calculateBox.Text.Length - 1);
                                calculateBox.Text += input;
                            }
                            else
                            {
                                calculateBox.Text += input;
                            }
                            break;
                    }
                };
            }
        }

    }
}
