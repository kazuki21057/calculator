using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace calculator
{
    class Calculate
    {
        static public List<string> operatorStr = new List<string>() { "+", "-", "*", "/" };

        static public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        static public string calculation (string formula)
        {
            showMessage(formula);
            return null;
        }
    }
}
