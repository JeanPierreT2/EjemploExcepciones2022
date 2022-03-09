using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExcepciones2022
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        Personas personas = new Personas();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                persona.Nombres = mtxtNombre.Text;
                persona.Apellidos = mtxtApellido.Text;
                persona.Edad = Convert.ToInt32(txtEdad.Text);
                personas.AgregarPersona(persona);
                MessageBox.Show("Datos almacenados correctamente!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = personas.ListPersonas;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            mtxtNombre.Text = " ";
                mtxtApellido.Text = " ";
            txtEdad.Text = "0";
        }
    }
}
