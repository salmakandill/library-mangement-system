using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace systemproject
{
    public partial class logindashboard : Form
    {
        public logindashboard()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 255, 255, 255);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left=(this.ClientSize.Width-panel1.Width)/2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
