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
    public partial class Analisis_Bateo : Form
    {
        Variables_Analisis_Bateo LoadData = new Variables_Analisis_Bateo();
        Capa_Negocios objetoCN = new Capa_Negocios();
        CN_ComboBox LoadData2 = new CN_ComboBox();
        DataTable Data = new DataTable();
        int CarreraH = 0;
        int CarreraV = 0;
        string Equipo = "Home";
        bool Primera = false, Segunda = false, Tercera= false;
        int Ining = 1;
        int Strikes = 0;
        int Bolas = 0;
        int FuerzaBateo1 = 0;
        int Trayectoria1 = 6;
        int Jugada1 = 0;
        int Outs = 0;
        int n = 0;
     
        public Analisis_Bateo()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Analisis_Bateo_Load(object sender, EventArgs e)
        {
            
            LbBolas.Text = Convert.ToString(Bolas);
            lbIningNum.Text = Convert.ToString(Ining);
            LbStrikes.Text = Convert.ToString(Strikes);
            lbOuts.Text = Convert.ToString(Outs);
        }

        
        public void CargarDatos(string Var1)
        {
            txtFuerzaBateo.Text = Var1;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siguiente Ining");
            if (Equipo == "Home")
            {
                Equipo = "Visitor";
            }
            Equipo = "Home";
            Ining = Ining + 1;
            lbIningNum.Text = Convert.ToString(Ining);
            cBoxPrimera.Checked = false;
            cBoxSegunda.Checked = false;
            cBoxTercera.Checked = false;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void label20_Click(object sender, EventArgs e)
        {
            
        }

        private void BasesActivas()
        {
            if (cBoxPrimera.CheckState == CheckState.Checked)
            {
                Primera = true;
            } else
            {
                Primera = false;
            }
            if (cBoxSegunda.CheckState == CheckState.Checked)
            {
                Segunda = true;
            }
            else
            {
                Segunda = false;
            }
            if (cBoxTercera.CheckState == CheckState.Checked)
            {
                Tercera = true;
            }
            else
            {
                Tercera = false;
            }

            if (txtFuerzaBateo.Enabled == false)
            {
                FuerzaBateo1 = 0;
            }
            else
            {
                FuerzaBateo1 = Convert.ToInt32(txtFuerzaBateo.Text);
            }
            if (LbTrayectoria.Enabled == false)
            {
                Trayectoria1 = 6;
            }
            else
            {
                Trayectoria1 = Convert.ToInt32(cBoxTrayectoria.SelectedValue);
            }
            if (cBoxJugada.Enabled == true)
            {
                Jugada1 = 0;
            }
            else
            {
                Jugada1 = Convert.ToInt32(cBoxJugada.SelectedValue);
            }
        }

        private void cBoxSwing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxSwing_DropDown(object sender, EventArgs e)
        {
            cBoxSwing.DisplayMember = "Swing_Nombre";
            cBoxSwing.ValueMember = "Swing_ID";
            cBoxSwing.DataSource = LoadData2.MostrarTipoSwing();
        }

        private void cBoxStikeZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxStikeZone_DropDown(object sender, EventArgs e)
        {
            cBoxStikeZone.DisplayMember = "StrikeZ_Nombre";
            cBoxStikeZone.ValueMember = "StrikeZ_ID";
            cBoxStikeZone.DataSource = LoadData2.MostrarStrikeZone();
        }

        private void cBoxCantado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCantado.Text == "Hit")
            {
                txtFuerzaBateo.Enabled = true;
                cBoxTrayectoria.Enabled = true;
                cBoxJugada.Enabled = true;
                LbJugada.Enabled = true;
                LbTrayectoria.Enabled = true;
                LbFuerzaBateo.Enabled = true;
                LbFuerzaVelocidad.Enabled = true;
                cBoxPrimera.Enabled = true;
                cBoxSegunda.Enabled = true;
                cBoxTercera.Enabled = true;
            }
            else
            {
                txtFuerzaBateo.Enabled = false;
                cBoxTrayectoria.Enabled = false;
                cBoxJugada.Enabled = false;
                LbJugada.Enabled = false;
                LbTrayectoria.Enabled = false;
                LbFuerzaBateo.Enabled = false;
                LbFuerzaVelocidad.Enabled = false;
                cBoxPrimera.Enabled = false;
                cBoxSegunda.Enabled = false;
                cBoxTercera.Enabled = false;
                Clean2();
            }
        }

        private void cBoxCantado_DropDown(object sender, EventArgs e)
        {
            cBoxCantado.DisplayMember = "Cantado_Nombre";
            cBoxCantado.ValueMember = "Cantado_ID";
            cBoxCantado.DataSource = LoadData2.MostrarCantado();
        }

        private void cBoxJugada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBoxJugada_DropDown(object sender, EventArgs e)
        {
            cBoxJugada.DisplayMember = "EstaBol_Nombre";
            cBoxJugada.ValueMember = "EstaBol_ID";
            cBoxJugada.DataSource = LoadData2.MostrarJugada();
        }

        private void cBoxTrayectoria_DropDown(object sender, EventArgs e)
        {
            cBoxTrayectoria.DisplayMember = "Bol_Nombre";
            cBoxTrayectoria.ValueMember = "Bol_ID";
            cBoxTrayectoria.DataSource = LoadData2.MostrarTrayectoria();
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            CarreraPunto();
        }

        private void CarreraPunto()
        {
            if (Equipo == "Home")
            {
                CarreraH = CarreraH + 1;
                lbPuntajeH.Text = Convert.ToString(CarreraH);
            }
            else
                CarreraV = CarreraV + 1;
            lbPuntajeV.Text = Convert.ToString(CarreraV);
        }

        private void lbPuntajeV_Click(object sender, EventArgs e)
        {

        }

        private void Clean()
        {
            cBoxPitcher.Text = "";
            cBoxBateador.Text = "";
            txtFuerzaBateo.Clear();
            txtVelocidadPitcheo.Clear();
            cBoxStikeZone.Text = "";
            cBoxCantado.Text = "";
            cBoxJugada.Text = "";
            cBoxTipoPitcheo.Text = "";
            cBoxStikeZone.Text = "";
            cBoxTrayectoria.Text = "";
            
        }

        private void Clean2()
        {
            txtFuerzaBateo.Clear();
            cBoxJugada.Text = "";
            cBoxTrayectoria.Text = "";
        }

        private void OutsMethod(int n)
        {
            Outs = Outs + n;
            if (Outs >= 3)
            {
                MessageBox.Show("Siguiente Ining");
                if (Equipo == "Home")
                {
                    Equipo = "Visitor";                    
                }
                Equipo = "Home";
                Ining = Ining + 1;
                lbIningNum.Text = Convert.ToString(Ining);
                cBoxPrimera.Checked = false;
                cBoxSegunda.Checked = false;
                cBoxTercera.Checked = false;
            }
            else
            {
                lbOuts.Text = Convert.ToString(Outs);
            }

        }
        private void CorridaDbase()
        {
            if (cBoxPrimera.CheckState == CheckState.Checked)
            {
                if (cBoxSegunda.CheckState == CheckState.Checked)
                {
                    if (cBoxTercera.CheckState == CheckState.Checked)
                    {
                        CarreraPunto();
                    }
                    else
                    {
                        cBoxTercera.Checked = true;
                    }
                }
                else
                {
                    cBoxSegunda.Checked = true;
                }
            }
            else
            {
                cBoxPrimera.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                if (cBoxCantado.Text == "Hit")
                {
                    if (cBoxJugada.Text == "Double Play")
                    {
                        n = 2;
                        OutsMethod(n);
                    }
                    if (cBoxJugada.Text == "Out")
                    {
                        n = 1;
                        OutsMethod(n);

                    }
                    if (cBoxJugada.Text == "Fielder Choice")
                    {
                        n = 1;
                        OutsMethod(n);
                    }
                    if (cBoxJugada.Text == "Triple Play")
                    {
                        n = 3;
                        OutsMethod(n);
                    }
                }
                if (cBoxCantado.Text == "Strike")
                {
                    Strikes = Strikes + 1;
                    if (Strikes == 3)
                    {
                        n = 1;
                        OutsMethod(n);
                        LbStrikes.Text = "0";
                        Strikes = 0;
                    }
                    else
                    LbStrikes.Text = Convert.ToString(Strikes);
                }
                if (cBoxCantado.Text == "Bola")
                {
                    Bolas = Bolas + 1;
                    if (Bolas == 4)
                    {
                        CorridaDbase();
                    }
                    else
                    LbBolas.Text = Convert.ToString(Bolas);
                } 
                if (cBoxCantado.Text == "Foul")
                {
                    if (Strikes == 2)
                    {

                    }
                    else
                    {
                        n = 1;
                        OutsMethod(n);
                    }

                        
                }
                if (cBoxCantado.Text == "Hit by Pitch")
                {
                    CorridaDbase();
                }
            }//Condiciones de outs, strikes, bolas, etc.
            try
            {
                DataTable dt1, dt2, dt3;
                BasesActivas();
                dt1 = objetoCN.GuardarJugada(Jugada1, Trayectoria1, FuerzaBateo1, Primera, Segunda, Tercera);
                ClaseCompartida.Jugada_ID = Convert.ToInt32(dt1.Rows[0]["Jug_ID"]);

                dt2 = objetoCN.GuardarTurno(Convert.ToInt32(cBoxPitcher.SelectedValue), Convert.ToInt32(txtVelocidadPitcheo.Text), Convert.ToInt32(cBoxSwing.SelectedValue), Convert.ToInt32(cBoxStikeZone.SelectedValue), Convert.ToInt32(cBoxCantado.SelectedValue));
                ClaseCompartida.Turno_ID = Convert.ToInt32(dt2.Rows[0]["Turno_ID"]);

                objetoCN.InsertarRela_Bateador_Turno(Convert.ToInt32(cBoxBateador.SelectedValue), ClaseCompartida.Turno_ID);

                dt3 = objetoCN.GuardarIning(Ining, ClaseCompartida.Turno_ID, ClaseCompartida.Jugada_ID, Convert.ToInt32(lbPuntajeH.Text), Convert.ToInt32(lbPuntajeV.Text));
                ClaseCompartida.Ining_ID = Convert.ToInt32(dt3.Rows[0]["Inning_ID"]);


                dataGridView1.DataSource = objetoCN.RelacionJuegoIning(ClaseCompartida.Ining_ID, ClaseCompartida.Juego_ID, ClaseCompartida.Jugada_ID);
                txtFuerzaBateo.Enabled = false;
                cBoxTrayectoria.Enabled = false;
                cBoxJugada.Enabled = false;
                LbJugada.Enabled = false;
                LbTrayectoria.Enabled = false;
                LbFuerzaBateo.Enabled = false;
                LbFuerzaVelocidad.Enabled = false;
                MessageBox.Show("Se inserto Correctamente");
                Clean();
                dt1.Clear();
                dt2.Clear();
                dt3.Clear();
                
            }
            catch
            {
                MessageBox.Show("No se pudo insertar los datos porfavor, revise que ningun campo este vacio o que contengan datos validos");
            }

        }

        private void cBoxTipoPitcheo_DropDown(object sender, EventArgs e)
        {
            cBoxTipoPitcheo.DisplayMember = "Pitch_Tipo";
            cBoxTipoPitcheo.ValueMember = "Pitch_ID";
            cBoxTipoPitcheo.DataSource = LoadData2.MostrarPitch();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cBoxCantado_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void TerminarJuego_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pasar a la ventana de reporte para ver los resultados del Juego");
            this.Hide();
        }

        private void cBoxBateador_DropDown(object sender, EventArgs e)
        {
            lbHomeOrVisitor.Text = Convert.ToString(ClaseCompartida.EquipoHome) + "VS" + Convert.ToString(ClaseCompartida.EquipoVisitor);
            cBoxBateador.DisplayMember = "Nombre";
            cBoxBateador.ValueMember = "ID";
            if (Equipo == "Home")
            {
                LbEquipoBate.Text = Convert.ToString(ClaseCompartida.EquipoHome);
                cBoxBateador.DataSource = LoadData2.BuscarBateador(Convert.ToString(ClaseCompartida.EquipoVisitor));
            }
            else
            {
                LbEquipoBate.Text = Convert.ToString(ClaseCompartida.EquipoVisitor);
                cBoxBateador.DataSource = LoadData2.BuscarBateador(Convert.ToString(ClaseCompartida.EquipoHome));
            }
            

        }

        private void cBoxPitcher_DropDown(object sender, EventArgs e)
        {
            lbHomeOrVisitor.Text = Convert.ToString(ClaseCompartida.EquipoHome) + "VS" + Convert.ToString(ClaseCompartida.EquipoVisitor);
            cBoxPitcher.DisplayMember = "Nombre";
            cBoxPitcher.ValueMember = "ID";
            if (Equipo == "Home")
            {
                LbEquipoBate.Text = Convert.ToString(ClaseCompartida.EquipoHome);
                cBoxPitcher.DataSource = LoadData.PeloterosHomePitcher();
            }
            else
            {
                LbEquipoBate.Text = Convert.ToString(ClaseCompartida.EquipoVisitor);
                cBoxPitcher.DataSource = LoadData.PeloterosVisitorPitcher();
            }
            
            
        }
    }
}
