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
    public partial class RegistoProspecto : Form
    {
        int ps;
        Capa_Negocios objetoCN = new Capa_Negocios();
        CN_ComboBox objetoCB = new CN_ComboBox();
        string Estado = "true";

        public RegistoProspecto()
        {
            InitializeComponent();
        }

        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lbnombre_Click(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbEstatura_Click(object sender, EventArgs e)
        {

        }

        private void txtDocumentoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbDocumentoID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {
             
        }

        private void LbPosiciones_Click(object sender, EventArgs e)
        {

        }

        private void checkboxCenterField_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCatcher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxShortStop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtPeso.Clear();
            txtDocumentoID.Clear();
            txtEstatura.Clear();
            CbxEquipo.Text="";
            txtApellido.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarJugador(txtDocumentoID.Text, Convert.ToInt32(CbxEquipo.SelectedValue), txtNombre.Text, txtApellido.Text, txtPeso.Text, txtEstatura.Text, txtEdad.Text, Estado);
                if (checkBoxBateadorDesignado.CheckState == CheckState.Checked)
                {
                    ps = 11;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxBateador.CheckState == CheckState.Checked)
                {
                    ps = 10;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxPitcher.CheckState == CheckState.Checked)
                {
                    ps = 9;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxCatcher.CheckState == CheckState.Checked)
                {
                    ps = 8;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxShortStop.CheckState == CheckState.Checked)
                {
                    ps = 7;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxTerceraBase.CheckState == CheckState.Checked)
                {
                    ps = 6;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxSecondBase.CheckState == CheckState.Checked)
                {
                    ps = 5;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (CheckBoxPrimeraBase.CheckState == CheckState.Checked)
                {
                    ps = 4;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkboxCenterField.CheckState == CheckState.Checked)
                {
                    ps = 3;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxLeftField.CheckState == CheckState.Checked)
                {
                    ps = 2;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }
                if (checkBoxRigthField.CheckState == CheckState.Checked)
                {
                    ps = 1;
                    objetoCN.InsertarRelacion(txtDocumentoID.Text, ps);
                }                
                MessageBox.Show("Se inserto Correctamente");
            }catch
            {
                MessageBox.Show("No se pudo insertar los datos porfavor, revise que ningun campo este vacio y que contengan datos validos");
            }


        }

        private void ListarEquiposCB()
        {
            CbxEquipo.DataSource = objetoCB.MostrarLista();
            CbxEquipo.DisplayMember = "Equip_Nombre";
            CbxEquipo.ValueMember = "Equip_ID";
        }

        private void CbxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarEquiposCB();
        }

        private void CbxEquipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBoxTerceraBase_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
