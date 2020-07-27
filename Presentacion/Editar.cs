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
    public partial class Editar : Form
    {

        private string ID;
            Clase obj = new Clase();
        private bool Editarr = false;

        //https://www.youtube.com/watch?v=fl585lWV3vo

        private void Mostrar()
        {
            Clase obj = new Clase();
            dataGridView1.DataSource = obj.mostrar();
        }

        public Editar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                obj.Eliminiar(ID);

                MessageBox.Show("se elmino la encuesta");
                Mostrar();
            }
            else
            {
                MessageBox.Show("seleccione una encuesta");
            }
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                limpiar();
                Editarr = true;
                ID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["region"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("seleccione una fila ");
            }
        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
                


        }
    }
}
