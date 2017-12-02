using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace threadapp
{
    public partial class Form1 : Form
    {
        Thread hilo, hilo2, hilo3 = null;
        bool terminarHilo = false;
        delegate void Delegado(TextBox input1, TextBox input2, TextBox input3, TextBox calc1, TextBox calc2, TextBox calc3, TextBox res);
        Delegado delegado = null;
        Hilo h = new Hilo();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delegado = new Delegado(() => h.mensaje(input1, input2, input3, calc1, calc2, calc3, res));
            delegado = h.mensaje;
            //hilo = new Thread(() => {Thread.Sleep(10000); h.mensaje(input1, input2, input3, calc1, calc2, calc3, res);});
            hilo = new Thread(() => { Thread.Sleep(10000); delegado(input1, input2, input3, calc1, calc2, calc3, res); });
            hilo.Start();
            //h.mensaje(input1, input2, input3, calc1, calc2, calc3, res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hilo2 = new Thread(() => { Thread.Sleep(10000); h.mensaje(input1, input2, input3, calc1, calc2, calc3, res); });
            hilo2.Start();
            //h.mensaje(input1, input2, input3, calc1, calc2, calc3, res);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hilo3 = new Thread(() => { Thread.Sleep(10000); h.mensaje(input1, input2, input3, calc1, calc2, calc3, res); });
            hilo3.Start();
            //h.mensaje(input1, input2, input3, calc1, calc2, calc3, res);
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
