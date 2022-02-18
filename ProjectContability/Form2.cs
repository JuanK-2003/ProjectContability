using Newtonsoft.Json;
using ProjectContability.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectContability
{
    public partial class Form2 : Form
    {
        List<Data> cuentaDisponible = new List<Data>();
        List<Data> partidas = new List<Data>();

        string cuentaFile = "C:\\Users\\Public\\Cuenta.json";
        string partidasFile = "C:\\Users\\Public\\Partidas.json";
        public Form2()
        {
            InitializeComponent();
        }

        protected void Form2_Load(object sender, EventArgs e)
        {
            if(validarArchivos())
            {
                using(StreamReader sr = new StreamReader(cuentaFile))
                {
                    cuentaDisponible = JsonConvert.DeserializeObject<List<Data>>(sr.ReadToEnd());
                    for (int i = 0; i < cuentaDisponible.Count; i++)
                    {
                        comboBox1.Items.Add(cuentaDisponible[i].NameCuenta);
                    }
                }
                using(StreamReader rs = new StreamReader(partidasFile))
                {
                    partidas = JsonConvert.DeserializeObject<List<Data>>(rs.ReadToEnd());
                }

                if (cuentaDisponible == null)
                {
                    cuentaDisponible = new List<Data>();
                }
                if(partidas == null)
                {
                    partidas = new List<Data>();
                }
            }

            else
            {
                File.Create("C:\\Users\\Public\\Cuenta.json");
                File.Create("C:\\Users\\Public\\Partidas.json");
            }
        }
        
        protected bool validarArchivos()
        {
            return File.Exists(cuentaFile)
            &&
                File.Exists(partidasFile);
        }

        private int valiButton( )
        {
            if(radioButton1.Checked == true)
            {
                return 0;
            }
            else if(radioButton2.Checked == true)
            {
                return 1;
            }
            else if(radioButton3.Checked == true)
            {
                return 2;
            }
            else if(radioButton4.Checked == true)
            {
                return 3;
            }
            else if( radioButton5.Checked == true)
            {
                return 4;
            }
            else if(radioButton6.Checked == true)
            {
                return 5;
            }
            else if(radioButton7.Checked == true)
            {
                return 6;
            }
            else
            {
                return -1;
            }
            return -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(this.valiButton() != -1 )
                {
                    int val = valiButton();
                    this.cuentaDisponible.Add(new Data(textBox1.Text, 0,
                        0, val/3, val%3));
                    this.comboBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                }

                using(StreamWriter sw = new StreamWriter(cuentaFile))
                {
                    sw.Write(JsonConvert.SerializeObject(cuentaDisponible));
                    sw.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(this.comboBox1.SelectedIndex != -1 && textBox2.Text != "" && textBox3.Text != "")
            {
                double credito = 0;
                double debito = 0;
                if(textBox2.Text != "")
                {
                    credito = double.Parse(textBox2.Text);
                }
                if(textBox3.Text != "")
                {
                    debito = double.Parse(textBox3.Text);
                }
                partidas.Add(new Data(this.cuentaDisponible[comboBox1.SelectedIndex].NameCuenta,
                                      credito, debito, cuentaDisponible[comboBox1.SelectedIndex].Type1,
                                      cuentaDisponible[comboBox1.SelectedIndex].Type2));
                using(StreamWriter sr = new StreamWriter(partidasFile))
                {
                    sr.Write(JsonConvert.SerializeObject(partidas));
                    sr.Close();
                }
            }
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton2.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton2.Checked = false;
            radioButton7.Checked = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton2.Checked = false;
            radioButton6.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Enabled = false;
            }
            else if(checkBox1.Checked == false)
            {
                textBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                textBox2.Enabled = false;
            }
            else if(checkBox2.Checked == false)
            {
                textBox2.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
