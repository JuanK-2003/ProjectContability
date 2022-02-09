using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Enabled = false;
            textBox1.Enabled = false;
            button1.Enabled = false;
            label2.Enabled = false;
            textBox2.Enabled = false;
            label3.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Enabled = true;
                textBox1.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
                textBox2.Enabled = false;
                label3.Enabled = false;
                textBox3.Enabled = false;
                comboBox1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Enabled = true;
                textBox2.Enabled = true;
                label3.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label2.Enabled = true;
                textBox2.Enabled = true;
                label3.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label2.Enabled = true;
                textBox2.Enabled = true;
                label3.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label2.Enabled = true;
                textBox2.Enabled = true;
                label3.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
