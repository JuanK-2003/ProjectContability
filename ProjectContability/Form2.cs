using ProjectContability.Class;
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
        List<Data> data = new List<Data>();
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
            checkBox1.Enabled = false;
            textBox2.Enabled = false;
            checkBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data temp = new Data();
            temp.NameCuenta = textBox1.Text;
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            data.Add(temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    Data data2 = new Data();
                    data2.Credit = double.Parse(textBox2.Text);
                    comboBox1.SelectedItem = data2;
                    textBox2.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Crédito)");
                }

                if (checkBox2.Checked)
                {
                    Data data2 = new Data();
                    data2.Debit = double.Parse(textBox3.Text);
                    comboBox1.SelectedItem = data2;
                    textBox3.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Dédito) ");
                }
            }
            if (radioButton3.Checked)
            {
                if (checkBox1.Checked)
                {
                    Data data2 = new Data();
                    data2.Credit = double.Parse(textBox2.Text);
                    comboBox1.SelectedItem = data2;
                    textBox2.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Crédito) ");
                }

                if (checkBox2.Checked)
                {
                    Data data2 = new Data();
                    data2.Debit = double.Parse(textBox3.Text);
                    comboBox1.SelectedItem = data2;
                    textBox3.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Dédito) ");
                }
            }
            if (radioButton4.Checked)
            {
                if (checkBox1.Checked)
                {
                    Data data2 = new Data();
                    data2.Credit = double.Parse(textBox2.Text);
                    comboBox1.SelectedItem = data2;
                    textBox2.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Crédito) ");
                }

                if (checkBox2.Checked)
                {
                    Data data2 = new Data();
                    data2.Debit = double.Parse(textBox3.Text);
                    comboBox1.SelectedItem = data2;
                    textBox3.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Dédito) ");
                }
            }
            if (radioButton5.Checked)
            {
                if (checkBox1.Checked)
                {
                    Data data2 = new Data();
                    data2.Credit = double.Parse(textBox2.Text);
                    comboBox1.SelectedItem = data2;
                    textBox2.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Crédito) ");
                }

                if (checkBox2.Checked)
                {
                    Data data2 = new Data();
                    data2.Debit = double.Parse(textBox3.Text);
                    comboBox1.SelectedItem = data2;
                    textBox3.Text = "";
                    data.Add(data2);
                    MessageBox.Show(" Se agregaron los datos a los libros correspondientes (Dédito) ");
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Enabled = true;
                textBox1.Enabled = true;
                button1.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                button2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                button2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                textBox2.Enabled = false;
            }
        }
    }
}
