﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // main F2 = new main();
            //this.Hide();
            //F2.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            main F2 = new main();
            this.Hide();
            F2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
