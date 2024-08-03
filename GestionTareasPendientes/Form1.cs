using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                // Agrega el texto del TextBox al ListBox
                Tareas1.Items.Add(txtTarea.Text);
                // Limpia el TextBox
                txtTarea.Clear();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tareas1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnElimiarTarea_Click(object sender, EventArgs e)
        {
            if (Tareas1.SelectedIndex != -1)
            {
                // Elimina la tarea seleccionada
                Tareas1.Items.RemoveAt(Tareas1.SelectedIndex);
            }
            else
            {
            }
        }
    }
}