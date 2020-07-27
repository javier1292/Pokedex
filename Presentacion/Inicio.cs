using Metodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            Clase obj = new Clase();
            dataGridView1.DataSource = obj.mostrar();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar_pokemon ss = new Registrar_pokemon();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editar ss = new Editar();
            ss.Show();
            this.Hide();
        }
    }
}
