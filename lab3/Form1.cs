﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Свойства : Form
    {
        public Свойства()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tbName.Text.Trim();
            if (userName.Length < 3)
            {
                MessageBox.Show("Vvedite name polzovatelya");
            }
            else
            {
                MessageBox.Show("Privet " + userName);
            }
        }

        private void button2_MouseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
