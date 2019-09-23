using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

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
            // powershellに計算を投げる
            using (var rs = RunspaceFactory.CreateRunspace())
            {
                rs.Open();
                using (var ps = PowerShell.Create())
                {
                    ps.Runspace = rs;
                    //ps.AddCommand("echo \"" + formula + "\"");
                    //ps.AddCommand("5+5");
                    ps.AddScript(formula);
                    foreach (var result in ps.Invoke())
                    {
                        return result.ToString();
                        //showMessage(result.ToString());
                    }
                }
            }
            return null;
        }
    }
}
