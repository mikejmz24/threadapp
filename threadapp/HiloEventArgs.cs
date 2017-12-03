using System;
using System.Windows.Forms;

namespace threadapp
{
    public class HiloEventArgs : EventArgs
    {
        public TextBox input1 { get; set; }
        public TextBox input2 { get; set; }
        public TextBox input3 { get; set; }
        public TextBox calc1 { get; set; }
        public TextBox calc2 { get; set; }
        public TextBox calc3 { get; set; }
        public TextBox res { get; set; }
    }
}
