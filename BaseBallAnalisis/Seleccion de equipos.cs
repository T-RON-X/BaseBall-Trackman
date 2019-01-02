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
    public partial class Seleccion_de_equipos : Form
    {

        

        MenuBase FormMenu = new MenuBase();

        CN_ComboBox ComboCN = new CN_ComboBox();
        string Equipo;
        string Posicion;

        public void Geta( ref string Parama)
        {

        }

        public Seleccion_de_equipos()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void Seleccion_de_equipos_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBoxHome_DropDown(object sender, EventArgs e)
        {
            ListarEquiposCB();
        }

        //Muestra el equipo en el ComboBox
        private void ListarEquiposCB()
        {
            
            CBoxHome.DisplayMember = "Equip_Nombre";
            CBoxHome.ValueMember = "Equip_ID";
            CBoxHome.DataSource = ComboCN.MostrarLista();
        }

        //Muestra los jugadores basandose en el equipo seleccionado
        private void ListarPosicionCB()
        {
            Equipo = CBoxHome.Text;
            switch (Posicion)
            {

                case "Bateador Desig":
                    CBoxBateadorDes.DisplayMember = "Nombre Jugador";
                    CBoxBateadorDes.ValueMember = "Pos_ID";
                    CBoxBateadorDes.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Catcher":                    
                    CBoxCatcher.DisplayMember = "Nombre Jugador";
                    CBoxCatcher.ValueMember = "Pos_ID";
                    CBoxCatcher.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    
                    SubBoxCatcher.DisplayMember = "Nombre Jugador";
                    SubBoxCatcher.ValueMember = "Pos_ID";
                    SubBoxCatcher.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Center Field":                    
                    CBoxCenterField.DisplayMember = "Nombre Jugador";
                    CBoxCenterField.ValueMember = "Pos_ID";
                    CBoxCenterField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    SubBoxCenterFiled.DisplayMember = "Nombre Jugador";
                    SubBoxCenterFiled.ValueMember = "Pos_ID";
                    SubBoxCenterFiled.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Pitcher":                    
                    CBoxPitcher.DisplayMember = "Nombre Jugador";
                    CBoxPitcher.ValueMember = "Pos_ID";
                    CBoxPitcher.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                   
                    CBoxPitcherAbridor.DisplayMember = "Nombre Jugador";
                    CBoxPitcherAbridor.ValueMember = "Pos_ID";
                    CBoxPitcherAbridor.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    CBoxPitcherRelevista.DisplayMember = "Nombre Jugador";
                    CBoxPitcherRelevista.ValueMember = "Pos_ID";
                    CBoxPitcherRelevista.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    CBoxPitcherCerrador.DisplayMember = "Nombre Jugador";
                    CBoxPitcherCerrador.ValueMember = "Pos_ID";
                    CBoxPitcherCerrador.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Primera Base":
                    
                    CBoxPrimeraBase.DisplayMember = "Nombre Jugador";
                    CBoxPrimeraBase.ValueMember = "Pos_ID";
                    CBoxPrimeraBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    SubBoxFirstBase.DisplayMember = "Nombre Jugador";
                    SubBoxFirstBase.ValueMember = "Pos_ID";
                    SubBoxFirstBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Right Field":
                    
                    CBoxRightField.DisplayMember = "Nombre Jugador";
                    CBoxRightField.ValueMember = "Pos_ID";
                    CBoxRightField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    SubBoxRightField.DisplayMember = "Nombre Jugador";
                    SubBoxRightField.ValueMember = "Pos_ID";
                    SubBoxRightField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Segunda Base":
                    
                    CBoxSegundaBase.DisplayMember = "Nombre Jugador";
                    CBoxSegundaBase.ValueMember = "Pos_ID";
                    CBoxSegundaBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    SubBoxSecondBase.DisplayMember = "Nombre Jugador";
                    SubBoxSecondBase.ValueMember = "Pos_ID";
                    SubBoxSecondBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Short Stop":
                    
                    CBoxShortStop.DisplayMember = "Nombre Jugador";
                    CBoxShortStop.ValueMember = "Pos_ID";
                    CBoxShortStop.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    SubBoxShortStop.DisplayMember = "Nombre Jugador";
                    SubBoxShortStop.ValueMember = "Pos_ID";
                    SubBoxShortStop.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Tercera Base":
                    
                    CBoxTerceraBase.DisplayMember = "Nombre Jugador";
                    CBoxTerceraBase.ValueMember = "Pos_ID";
                    CBoxTerceraBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    SubBoxThirdBase.DisplayMember = "Nombre Jugador";
                    SubBoxThirdBase.ValueMember = "Pos_ID";
                    SubBoxThirdBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;

                case "Left Field":
                    
                    CBoxLeftField.DisplayMember = "Nombre Jugador";
                    CBoxLeftField.ValueMember = "Pos_ID";
                    CBoxLeftField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);

                    
                    SubBoxLeftField.DisplayMember = "Nombre Jugador";
                    SubBoxLeftField.ValueMember = "Pos_ID";
                    SubBoxLeftField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    break;
            }
                
            
        }

        private void CBoxLeftField_DropDown(object sender, EventArgs e)
        {
            Posicion = "Left Field";
            ListarPosicionCB();
        }

        private void CBoxPitcher_DropDown(object sender, EventArgs e)
        {
            Posicion = "Pitcher";
            ListarPosicionCB();
        }

        private void CBoxPrimeraBase_DropDown(object sender, EventArgs e)
        {
            Posicion = "Primera Base";
            ListarPosicionCB();
        }

        private void CBoxTerceraBase_DropDown(object sender, EventArgs e)
        {
            Posicion = "Tercera Base";
            ListarPosicionCB();
        }

        private void CBoxSegundaBase_DropDown(object sender, EventArgs e)
        {
            Posicion = "Segunda Base";
            ListarPosicionCB();
        }

        private void CBoxCatcher_DropDown(object sender, EventArgs e)
        {
            Posicion = "Catcher";
            ListarPosicionCB();
        }

        private void CBoxBateadorDes_DropDown(object sender, EventArgs e)
        {
            Posicion = "Bateador Desig";
            ListarPosicionCB();
        }

        private void CBoxShortStop_DropDown(object sender, EventArgs e)
        {
            Posicion = "Short Stop";
            ListarPosicionCB();
        }

        private void CBoxCenterField_DropDown(object sender, EventArgs e)
        {
            Posicion = "Center Field";
            ListarPosicionCB();
        }

        private void CoBoxLeftField_DropDown(object sender, EventArgs e)
        {
            Posicion = "Left Field";
            ListarPosicionCB();
        }

        private void CBoxRightField_DropDown(object sender, EventArgs e)
        {
            Posicion = "Right Field";
            ListarPosicionCB();
        }

        private void CBoxLeftField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBoxPitcher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ClaseCompartida.EquipoHome = CBoxHome.Text;
            ClaseCompartida.PitcherHome = CBoxPitcher.Text;
            ClaseCompartida.ShortStopHome = CBoxShortStop.Text;
            ClaseCompartida.CatcherHome = CBoxCatcher.Text;
            ClaseCompartida.PrimeraHome = CBoxPrimeraBase.Text;
            ClaseCompartida.SegundaHome = CBoxSegundaBase.Text;
            ClaseCompartida.TerceraHome = CBoxTerceraBase.Text;
            ClaseCompartida.LeftHome = CBoxLeftField.Text;
            ClaseCompartida.CenterHome = CBoxCenterField.Text;
            ClaseCompartida.RightHome = CBoxRightField.Text;
            ClaseCompartida.PitcherAHome = CBoxPitcherAbridor.Text;
            ClaseCompartida.PitcherCHome = CBoxPitcherCerrador.Text;
            ClaseCompartida.PitcherRHome = CBoxPitcherRelevista.Text;
            ClaseCompartida.SubShortStopHome = SubBoxShortStop.Text;
            ClaseCompartida.SubCatcherHome = SubBoxCatcher.Text;
            ClaseCompartida.SubPrimeraHome = SubBoxFirstBase.Text;
            ClaseCompartida.SubSegundaHome = SubBoxSecondBase.Text;
            ClaseCompartida.SubTerceraHome = SubBoxThirdBase.Text;
            ClaseCompartida.SubLeftHome = SubBoxLeftField.Text;
            ClaseCompartida.SubCenterHome = SubBoxCenterFiled.Text;
            ClaseCompartida.SubRightHome = SubBoxRightField.Text;
            Seleccion_de_equipos_2 Form1 = new Seleccion_de_equipos_2();
            Form1.Show();
            this.Close();
        }

        private void Seleccion_de_equipos_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void Seleccion_de_equipos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CBoxPrimeraBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SubBoxCenterFiled_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBoxRightField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
