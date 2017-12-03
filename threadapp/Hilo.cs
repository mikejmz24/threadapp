using System;
using System.Windows.Forms;

namespace threadapp
{
    public class Hilo
    {
        public delegate void HiloEventHandler(object source, HiloEventArgs args);
        public event EventHandler<HiloEventArgs> HiloIniciado;
        Helper Helper = new Helper();

        protected virtual void OnHiloIniciado(TextBox input1, TextBox input2, TextBox input3, TextBox calc1, TextBox calc2, TextBox calc3, TextBox res)
        {
            HiloIniciado?.Invoke(this, new HiloEventArgs() { input1 = input1, input2 = input2, input3 = input3, calc1 = calc1, calc2 = calc2, calc3 = calc3, res = res });
        }

        public void Mensaje(TextBox input1, TextBox input2, TextBox input3, TextBox calc1, TextBox calc2, TextBox calc3, TextBox res)
        {
            if (Form1.ActiveForm.InvokeRequired)
                Form1.ActiveForm.Invoke((MethodInvoker)delegate () { OnHiloIniciado(input1, input2, input3, calc1, calc2, calc3, res); });
        }
    }
}