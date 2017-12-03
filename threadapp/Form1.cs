using System;
using System.Windows.Forms;
using System.Threading;

namespace threadapp
{
    public partial class Form1 : Form
    {
        Thread hilo, hilo2, hilo3 = null;
        Hilo H = new Hilo();
        Helper Helper = new Helper();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            H.HiloIniciado += Helper.OnHiloIniciado;
            hilo = new Thread(() => H.Mensaje(input1, input2, input3, calc1, calc2, calc3, res));
            hilo.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            H.HiloIniciado += Helper.OnHiloIniciado;
            hilo2 = new Thread(() => H.Mensaje(input1, input2, input3, calc1, calc2, calc3, res));
            hilo2.Start();
        }

        private void input1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.ValidarNum(sender, e);
        }

        private void input2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.ValidarNum(sender, e);
        }

        private void input3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.ValidarNum(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            H.HiloIniciado += Helper.OnHiloIniciado;
            hilo3 = new Thread(() => H.Mensaje(input1, input2, input3, calc1, calc2, calc3, res));
            hilo3.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input1.Text = string.Empty;
            input2.Text = string.Empty;
            input3.Text = string.Empty;
            calc1.Text = string.Empty;
            calc2.Text = string.Empty;
            calc3.Text = string.Empty;
            res.Text = string.Empty;
            input1.ReadOnly = false;
            input2.ReadOnly = false;
            input3.ReadOnly = false;
        }
    }
}
