using System.Windows.Forms;

namespace threadapp
{
    public class Helper : IHelper
    {
        public void ValidarNum(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        public decimal Sumatotal(decimal dec1, decimal dec2, decimal dec3)
        {
            decimal res = dec1 + dec2 + dec3;
            return res;
        }

        public decimal Suma(decimal dec1)
        {
            decimal res = dec1 + dec1;
            return res;
        }

        public decimal ConvierteDec(string dec)
        {
            decimal res;
            res = (string.IsNullOrEmpty(dec)) ? 0 : decimal.Parse(dec);
            return res;
        }

        public decimal ConvierteDecAll(string dec1, string dec2, string dec3)
        {
            decimal res;
            res = ConvierteDec(dec1) + ConvierteDec(dec2) + ConvierteDec(dec3);
            return res;
        }

        public void OnHiloIniciado(object source, HiloEventArgs e)
        {
            if (e.calc1.Text == string.Empty && e.input1.Text != string.Empty)
            {
                e.calc1.Text = Suma(ConvierteDec(e.input1.Text)).ToString();
                e.input1.Text = string.Empty;
                e.input1.ReadOnly = true;
            }
            else
            {
                e.calc1.Text = Suma(ConvierteDec(e.calc1.Text)) == 0 ? string.Empty : Suma(ConvierteDec(e.calc1.Text)).ToString();
            }
            if (e.calc2.Text == string.Empty && e.input2.Text != string.Empty)
            {
                e.calc2.Text = Suma(ConvierteDec(e.input2.Text)).ToString();
                e.input2.Text = string.Empty;
                e.input2.ReadOnly = true;
            }
            else
            {
                e.calc2.Text = Suma(ConvierteDec(e.calc2.Text)) == 0 ? string.Empty : Suma(ConvierteDec(e.calc2.Text)).ToString();
            }
            if (e.calc3.Text == string.Empty && e.input3.Text != string.Empty)
            {
                e.calc3.Text = Suma(ConvierteDec(e.input3.Text)).ToString();
                e.input3.Text = string.Empty;
                e.input3.ReadOnly = true;
            }
            else
            {
                e.calc3.Text = Suma(ConvierteDec(e.calc3.Text)) == 0 ? string.Empty : Suma(ConvierteDec(e.calc3.Text)).ToString();
            }
            e.res.Text = Sumatotal(ConvierteDec(e.calc1.Text), ConvierteDec(e.calc2.Text), ConvierteDec(e.calc3.Text)).ToString();
        }
    }
}
