using EjercicioDebug2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDebug2
{
    public partial class FormListadoFlores : Form
    {
        bool consultar = false;

        public FormListadoFlores()
        {
            InitializeComponent();
        }

        public void CargarFlor(Flor flor)
        {
            textBoxCodigo.Text = flor.Codigo;
            textBoxCodigo.Enabled = false;
            textBoxNombre.Text = flor.Nombre;
            textBoxTemporada.Text = flor.Temporada;
            comboBoxOlor.Text =  flor.Olor;
            numericUpDownPetalos.Value = flor.CantidadPetalos;
            consultar = false;
            buttonAtras.Visible = true;
            buttonEliminar.Visible = true;
            groupBoxAgregar.Text = "Modificar";
        }

        public Flor InstanciarFlor()
        {
            return new Flor()
            {
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                CantidadPetalos = (int)numericUpDownPetalos.Value,
                Olor = comboBoxOlor.Text
            };
        }

        public void AgregarFlor()
        {
            Flor flor = InstanciarFlor();
            FlorRepositorio.AgregarFlor(flor);
            MessageBox.Show("Flor agregada con éxito",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ModificarFlor()
        {
            Flor flor = InstanciarFlor();
            FlorRepositorio.ModificarFlor(flor);
            MessageBox.Show("El formulario fue modificado",
                "Information");
            LlenarTabla();
                
               
        }

        public void EliminarFlor()
        {
            var des = MessageBox.Show("¿Desea borrar la flor?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            //if (des == DialogResult.Yes) FlorRepositorio.EliminarFlor(textBoxCodigo.Text);
            if(des == DialogResult.Yes)
            {
                int indice = dataGridViewFlores.CurrentCell.RowIndex;
                string codigo = (string)dataGridViewFlores.Rows[indice].Cells[0].Value;
                FlorRepositorio.EliminarFlor(codigo);
            }
            LlenarTabla();
        }

        public void Limpiar()
        {
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxTemporada.Clear();
            comboBoxOlor.SelectedIndex = -1;
            numericUpDownPetalos.Value = 0;
        }

        public void Atras()
        {
            Limpiar();
            textBoxCodigo.Enabled = true;
            consultar = false;
            buttonAtras.Visible = false;
            buttonEliminar.Visible = false;
            buttonGuardar.Visible = false;
            buttonModificar.Visible = false;
            dataGridViewFlores.ClearSelection();
            groupBoxAgregar.Text = "Agregar";
        }

        public bool ValidarFormulario()
        {
            return textBoxCodigo.Text != string.Empty &&
                textBoxNombre.Text != string.Empty &&
                textBoxTemporada.Text != string.Empty &&
                comboBoxOlor.SelectedIndex != -1 &&
                numericUpDownPetalos.Value != 0;
        }

        public void Guardar()
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Debe llenar el formulario",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            
            if (consultar) ModificarFlor();
            else AgregarFlor();

            LlenarTabla();
            
        }

        public void LlenarTabla()
        {
            dataGridViewFlores.DataSource = FlorRepositorio.ListarFlores();
        }

        private void FormListadoFlores_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void dataGridViewFlores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = dataGridViewFlores.CurrentCell.RowIndex;
                string codigo = (string)dataGridViewFlores.Rows[indice].Cells[0].Value;
                Flor flor = FlorRepositorio.ConsultarFlor(codigo);
            } catch
            {
                
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void buttonmodificar_Click_1(object sender, EventArgs e)
        {
            ModificarFlor();
        }

        private void buttonatras_Click_1(object sender, EventArgs e)
        {
            Atras();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            EliminarFlor();
        }
    }
}
