using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace threadapp
{
    public class Hilo
    {
        Helper helper = new Helper();

        public decimal sumatotal(decimal dec1, decimal dec2, decimal dec3)
        {
            decimal res = dec1 + dec2 + dec3;
            return res;
        }

        public decimal suma(decimal dec1)
        {
            decimal res = dec1 + dec1;
            return res;
        }

        public void mensaje(TextBox input1, TextBox input2, TextBox input3, TextBox calc1, TextBox calc2, TextBox calc3, TextBox res)
        {
            if (calc1.Text == string.Empty && input1.Text != string.Empty)
            {
                calc1.Text = suma(helper.convierteDec(input1.Text)).ToString();
                input1.Text = string.Empty;
                input1.ReadOnly = true;
            }
            else
            {
                calc1.Text = suma(helper.convierteDec(calc1.Text)) == 0 ? string.Empty : suma(helper.convierteDec(calc1.Text)).ToString();
            }
            if (calc2.Text == string.Empty && input2.Text != string.Empty)
            {
                calc2.Text = suma(helper.convierteDec(input2.Text)).ToString();
                input2.Text = string.Empty;
                input2.ReadOnly = true;
            }
            else
            {
                calc2.Text = suma(helper.convierteDec(calc2.Text)) == 0 ? string.Empty : suma(helper.convierteDec(calc2.Text)).ToString();
            }
            if (calc3.Text == string.Empty && input3.Text != string.Empty)
            {
                calc3.Text = suma(helper.convierteDec(input3.Text)).ToString();
                input3.Text = string.Empty;
                input3.ReadOnly = true;
            }
            else
            {
                calc3.Text = suma(helper.convierteDec(calc3.Text)) == 0 ? string.Empty : suma(helper.convierteDec(calc3.Text)).ToString();
            }
            res.Text = sumatotal(helper.convierteDec(calc1.Text), helper.convierteDec(calc2.Text), helper.convierteDec(calc3.Text)).ToString();
        }
    }
}