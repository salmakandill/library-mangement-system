using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemproject
{
    public partial class Studentdashboard : Form
    {
        public Studentdashboard()
        {
            InitializeComponent();
        }

        private void Studentdashboard_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(120, 255, 255, 255);
            panel3.BackColor = Color.FromArgb(120, 255, 255, 255);
        }
    }
}
