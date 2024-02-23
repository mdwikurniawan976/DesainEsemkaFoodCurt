using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesainEsemkaFoodCurt.Library
{
    public class Alert
    {
        public static DialogResult Error(string text)
        {
            return MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Information(string text)
        {
            return MessageBox.Show(text, "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Confirmation(string text)
        {
            return MessageBox.Show(text, "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
