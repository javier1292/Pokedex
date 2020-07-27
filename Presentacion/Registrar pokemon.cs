using Metodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Registrar_pokemon : Form
    {

        Clase objetoc = new Clase();
        Image foto;
        public Registrar_pokemon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult rs = op.ShowDialog();
            if (rs==DialogResult.OK)
                    {
                pictureBox1.Image = Image.FromFile(op.FileName); 

                    }
        }               

        private void button1_Click(object sender, EventArgs e)
        {
            



            {
                try
                {

                    objetoc.Insertar(textBox1.Text, textBox2.Text, textBox3.Text);
                    MessageBox.Show("Registro completado ");


                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar " + ex);
                }

                Inicio ss = new Inicio();
                ss.Show();
                this.Hide();
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
