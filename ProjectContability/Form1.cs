﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectContability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ingresoDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.StartPosition = FormStartPosition.CenterScreen;                                                                                                                  
            f1.ShowDialog();
        }

        private void tablaDeDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.ShowDialog();
        }

        private void tablaDeMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.StartPosition = FormStartPosition.CenterScreen;  
            f3.ShowDialog();
        }

        private void tablaDeBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f4 = new Form5();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.ShowDialog();
        }
    }
}
