using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyText_Box
{
    public partial class MyTextBox : TextBox
    {
        public MyTextBox()
        {
            BackColor = Color.Beige;
            ForeColor = Color.BlueViolet;
            HasDecimal = true;
            HasNegative = false;
        }

        [Category("Behavior")]public bool HasDecimal { get; set; }
        [Category("Behavior")]public bool HasNegative{ get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >='0' && e.KeyChar<='9' || e.KeyChar ==8 ))
            {
                e.Handled = false;
            }
        }
    }
}
