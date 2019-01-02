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
    public partial class Busqueda : Form
    {
        int ps;
        Capa_Negocios objetoCN = new Capa_Negocios();
        CN_ComboBox objetoCB = new CN_ComboBox();
        private Boolean Editar = false;
        private string Estado;

        public Busqueda()
        {
            InitializeComponent();
        }

        private void posicion()
        {
            if (checkBoxBateadorDesignado.CheckState == CheckState.Checked)
            {
                ps = 11;
            }
            if (checkBoxBateador.CheckState == CheckState.Checked)
            {
                ps = 10;
            }
            if (checkBoxPitcher.CheckState == CheckState.Checked)
            {
                ps = 9;
            }
            if (checkBoxCatcher.CheckState == CheckState.Checked)
            {
                ps = 8;
            }
            if (checkBoxShortStop.CheckState == CheckState.Checked)
            {
                ps = 7;
            }
            if (checkBoxTerceraBase.CheckState == CheckState.Checked)
            {
                ps = 6;
            }
            if (checkBoxSecondBase.CheckState == CheckState.Checked)
            {
                ps = 5;
            }
            if (CheckBoxPrimeraBase.CheckState == CheckState.Checked)
            {
                ps = 4;
            }
            if (checkboxCenterField.CheckState == CheckState.Checked)
            {
                ps = 3;
            }
            if (checkBoxLeftField.CheckState == CheckState.Checked)
            {
                ps = 2;
            }
            if (checkBoxRigthField.CheckState == CheckState.Checked)
            {
                ps = 1;
            }
        }

        private void LimpiarForm()
        {
            txtApellido.Clear();
            txtDocumentoID.Clear();
            txtEdad.Clear();
            txtEstatura.Clear();
            txtNombre.Clear();
            txtPeso.Clear();
        }

        private void ListarEquiposCB()
        {
            CbxEquipo.DataSource = objetoCB.MostrarLista();
            CbxEquipo.DisplayMember = "Equip_Nombre";
            CbxEquipo.ValueMember = "Equip_ID";
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            MostrarJugadores();
            ListarEquiposCB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxProspecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guarda Jugador Nuevo
                if (Editar == true)
                {
                    objetoCN.InsertarJugador(txtDocumentoID.Text, Convert.ToInt32(CbxEquipo.SelectedValue), txtNombre.Text, txtApellido.Text, txtPeso.Text, txtEstatura.Text, txtEdad.Text, Estado);
                    posicion();
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarJugadores();
                    LimpiarForm();
                }
               
            }catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por:" + ex);
            }

            try
            {
                //Edita un jugador
                if (Editar == false)
                {
                    Editar = true;
                    objetoCN.EditarJugador(txtDocumentoID.Text, Convert.ToInt32(CbxEquipo.SelectedValue), txtNombre.Text, txtApellido.Text, txtPeso.Text, txtEstatura.Text, txtEdad.Text, Estado);
                    posicion();
                    objetoCN.EditarPosicion(txtDocumentoID.Text, ps);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarJugadores();
                    LimpiarForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos porfavor, revise que ningun campo este vacio y que contengan datos validos");
            }

        }

        private void MostrarJugadores()
        {
            dataGridView1.DataSource = objetoCN.MostrarJugadores(txtBusqueda.Text, cBoxBusqueda.Text);
        }

        private void CheckBoxActivo(string Estado)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Inserta en cada campo las variables de la base de datos
                Editar = false; 
                ListarEquiposCB();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDocumentoID.Text = dataGridView1.CurrentRow.Cells["Identificacion"].Value.ToString();
                txtEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                txtEstatura.Text = dataGridView1.CurrentRow.Cells["Estatura"].Value.ToString();
                txtPeso.Text = dataGridView1.CurrentRow.Cells["Peso"].Value.ToString();
                Estado = dataGridView1.CurrentRow.Cells["Jugador Activo"].Value.ToString();
                CbxEquipo.Text = dataGridView1.CurrentRow.Cells["Equipo"].Value.ToString();
                CheckBoxActivo(Estado);
                switch (dataGridView1.CurrentRow.Cells["Posicion"].Value)
                {
                    //Busca cual es el checkbox que debe activarse
                    case "Right Field":
                        checkBoxBateadorDesignado.CheckState = CheckState.Checked;
                        break;

                    case "Left Field":
                        checkBoxLeftField.CheckState = CheckState.Checked;
                        break;

                    case "Center  Field":
                        checkboxCenterField.CheckState = CheckState.Checked;
                        break;

                    case "Primera Base":
                        CheckBoxPrimeraBase.CheckState = CheckState.Checked;
                        break;

                    case "Segunda Base":
                        checkBoxSecondBase.CheckState = CheckState.Checked;
                        break;

                    case "Tercera Base":
                        checkBoxTerceraBase.CheckState = CheckState.Checked;
                        break;

                    case "Short Stop":
                        checkBoxShortStop.CheckState = CheckState.Checked;
                        break;

                    case "Catcher":
                        checkBoxCatcher.CheckState = CheckState.Checked;
                        break;

                    case "Pitcher":
                        checkBoxPitcher.CheckState = CheckState.Checked;
                        break;

                    case "Bateador":
                        checkBoxBateador.CheckState = CheckState.Checked;
                        break;

                    case "Bateador Desig":
                        checkBoxBateadorDesignado.CheckState = CheckState.Checked;
                        break;

                }
            }
            else
                MessageBox.Show("Seleccione una fila Porfavor");
        }

        private void CbxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarJugadores();
        }
    }
}
