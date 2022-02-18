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
    public partial class Form5 : Form
    {
        List<Data> partidas = new List<Data>();
        string partidasFile = "C:\\Users\\Public\\Partidas.json";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if(validarArchivos())
            {
                using (StreamReader rs = new StreamReader(partidasFile))
                {
                    partidas = JsonConvert.DeserializeObject<List<Data>>(rs.ReadToEnd());
                    rs.Close();
                }

                if (partidas == null)
                {
                    partidas = new List<Data>();
                }

                MessageBox.Show(partidas.Count() + " " + partidas[0].NameCuenta);
            }
            else
            {
                File.Create("C:\\Users\\Public\\Partidas.json");
            }

        }
        protected bool validarArchivos()
        {
            return
                File.Exists(partidasFile);
        }
    }
}
