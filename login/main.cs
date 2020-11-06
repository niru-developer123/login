using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class main : MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main F1 = new main();
            panel1.Hide ();
            //F1.Show ();
        }
    }
}
