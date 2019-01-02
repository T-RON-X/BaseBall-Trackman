using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDnegocios;

namespace BaseBallAnalisis
{
    public partial class Equipos : Form
    {
        bool Editar = true;
        Capa_Negocios EquipoCN = new Capa_Negocios();

        public Equipos()
        {
            InitializeComponent();
        }

        private void LimpiarForm()
        {
            txtNombreDeEquipo.Clear();
            txtID.Clear();
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            MostrarEquipos();
        }

        private void MostrarEquipos()
        {
            dataGridView1.DataSource = EquipoCN.MostrarEquipos();
        }

        private void lbInsertarImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guarda Jugador Nuevo
                if (Editar == true)
                {
                    EquipoCN.InsertarEquipo(txtNombreDeEquipo.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarEquipos();
                    LimpiarForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por:" + ex);
            }

            try
            {
                //Edita un jugador
                if (Editar == false)
                {
                    EquipoCN.EditarEquipo(txtNombreDeEquipo.Text, Convert.ToInt32(txtID.Text));
                    MessageBox.Show("Se inserto correctamente");
                    MostrarEquipos();
                    LimpiarForm();
                    Editar = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por:" + ex);
            }

        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Inserta en cada campo las variables de la base de datos
                Editar = false;
                txtNombreDeEquipo.Text = dataGridView1.CurrentRow.Cells["Nombre de equipo"].Value.ToString();
                txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila Porfavor");
        }
    }
}
