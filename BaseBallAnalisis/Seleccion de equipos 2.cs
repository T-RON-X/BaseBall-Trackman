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
    public partial class Seleccion_de_equipos_2 : Form
    {


        MenuBase FormMenu = new MenuBase();

        CN_ComboBox ComboCN = new CN_ComboBox();
        string Equipo;
        string Posicion;

        public Seleccion_de_equipos_2()
        {
            InitializeComponent();
        }

        private void Seleccion_de_equipos_2_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
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
            cbxVisitors.DataSource = ComboCN.MostrarLista();
            cbxVisitors.DisplayMember = "Equip_Nombre";
            cbxVisitors.ValueMember = "Equip_ID";

        }

        //Muestra los jugadores basandose en el equipo seleccionado
        private void ListarPosicionCB()
        {
            Equipo = cbxVisitors.Text;
            switch (Posicion)
            {

                case "Bateador Desig":
                    CBoxBateadorDes.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxBateadorDes.DisplayMember = "Nombre Jugador";
                    CBoxBateadorDes.ValueMember = "Pos_ID";
                    break;

                case "Catcher":
                    CBoxCatcher.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxCatcher.DisplayMember = "Nombre Jugador";
                    CBoxCatcher.ValueMember = "Pos_ID";

                    SubBoxCatcher.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxCatcher.DisplayMember = "Nombre Jugador";
                    SubBoxCatcher.ValueMember = "Pos_ID";
                    break;

                case "Center Field":
                    CBoxCenterField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxCenterField.DisplayMember = "Nombre Jugador";
                    CBoxCenterField.ValueMember = "Pos_ID";

                    SubBoxCenterFiled.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxCenterFiled.DisplayMember = "Nombre Jugador";
                    SubBoxCenterFiled.ValueMember = "Pos_ID";
                    break;

                case "Pitcher":
                    CBoxPitcher.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxPitcher.DisplayMember = "Nombre Jugador";
                    CBoxPitcher.ValueMember = "Pos_ID";

                    CBoxPitcherAbridor.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxPitcherAbridor.DisplayMember = "Nombre Jugador";
                    CBoxPitcherAbridor.ValueMember = "Pos_ID";

                    CBoxPitcherRelevista.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxPitcherRelevista.DisplayMember = "Nombre Jugador";
                    CBoxPitcherRelevista.ValueMember = "Pos_ID";

                    CBoxPitcherCerrador.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxPitcherCerrador.DisplayMember = "Nombre Jugador";
                    CBoxPitcherCerrador.ValueMember = "Pos_ID";
                    break;

                case "Primera Base":
                    CBoxPrimeraBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxPrimeraBase.DisplayMember = "Nombre Jugador";
                    CBoxPrimeraBase.ValueMember = "Pos_ID";

                    SubBoxFirstBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxFirstBase.DisplayMember = "Nombre Jugador";
                    SubBoxFirstBase.ValueMember = "Pos_ID";
                    break;

                case "Right Field":
                    CBoxLeftField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxLeftField.DisplayMember = "Nombre Jugador";
                    CBoxLeftField.ValueMember = "Pos_ID";

                    SubBoxRightField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxRightField.DisplayMember = "Nombre Jugador";
                    SubBoxRightField.ValueMember = "Pos_ID";
                    break;

                case "Segunda Base":
                    CBoxSegundaBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxSegundaBase.DisplayMember = "Nombre Jugador";
                    CBoxSegundaBase.ValueMember = "Pos_ID";

                    SubBoxSecondBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxSecondBase.DisplayMember = "Nombre Jugador";
                    SubBoxSecondBase.ValueMember = "Pos_ID";
                    break;

                case "Short Stop":
                    CBoxShortStop.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxShortStop.DisplayMember = "Nombre Jugador";
                    CBoxShortStop.ValueMember = "Pos_ID";

                    SubBoxShortStop.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxShortStop.DisplayMember = "Nombre Jugador";
                    SubBoxShortStop.ValueMember = "Pos_ID";
                    break;

                case "Tercera Base":
                    CBoxTerceraBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxTerceraBase.DisplayMember = "Nombre Jugador";
                    CBoxTerceraBase.ValueMember = "Pos_ID";

                    SubBoxThirdBase.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxThirdBase.DisplayMember = "Nombre Jugador";
                    SubBoxThirdBase.ValueMember = "Pos_ID";
                    break;

                case "Left Field":
                    CBoxRightField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    CBoxRightField.DisplayMember = "Nombre Jugador";
                    CBoxRightField.ValueMember = "Pos_ID";

                    SubBoxLeftField.DataSource = ComboCN.MostrarPosicionJugador(Equipo, Posicion);
                    SubBoxLeftField.DisplayMember = "Nombre Jugador";
                    SubBoxLeftField.ValueMember = "Pos_ID";
                    break;
            }


        }

        private void CBoxLeftField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBoxPitcher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MenuBase Form1 = new MenuBase();
            Form1.AbrirFormInPanel(new RegistoProspecto());
            this.Close();
        }

        private void Seleccion_de_equipos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Seleccion_de_equipos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {

            ClaseCompartida.EquipoVisitor = cbxVisitors.Text;
            ClaseCompartida.PitcherVisitor = CBoxPitcher.Text;
            ClaseCompartida.ShortStopVisitor = CBoxShortStop.Text;
            ClaseCompartida.CatcherVisitor = CBoxCatcher.Text;
            ClaseCompartida.PrimeraVisitor = CBoxPrimeraBase.Text;
            ClaseCompartida.SegundaVisitor = CBoxSegundaBase.Text;
            ClaseCompartida.TerceraVisitor = CBoxTerceraBase.Text;
            ClaseCompartida.LeftVisitor = CBoxLeftField.Text;
            ClaseCompartida.CenterVisitor = CBoxCenterField.Text;
            ClaseCompartida.RightVisitor = CBoxRightField.Text;
            ClaseCompartida.PitcherAVisitor = CBoxPitcherAbridor.Text;
            ClaseCompartida.PitcherCVisitor = CBoxPitcherCerrador.Text;
            ClaseCompartida.PitcherRVisitor = CBoxPitcherRelevista.Text;
            ClaseCompartida.SubShortStopVisitor = SubBoxShortStop.Text;
            ClaseCompartida.SubCatcherVisitor = SubBoxCatcher.Text;
            ClaseCompartida.SubPrimeraVisitor = SubBoxFirstBase.Text;
            ClaseCompartida.SubSegundaVisitor = SubBoxSecondBase.Text;
            ClaseCompartida.SubTerceraVisitor = SubBoxThirdBase.Text;
            ClaseCompartida.SubLeftVisitor = SubBoxLeftField.Text;
            ClaseCompartida.SubCenterVisitor = SubBoxCenterFiled.Text;
            ClaseCompartida.SubRightVisitor = SubBoxRightField.Text;

            this.Close();
        }

        private void cbxVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxVisitors_DropDown(object sender, EventArgs e)
        {
            cbxVisitors.DataSource = ComboCN.MostrarLista();
            cbxVisitors.DisplayMember = "Equip_Nombre";
            cbxVisitors.ValueMember = "Equip_ID";
        }

        private void CBoxCenterField_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Center Field";
            ListarPosicionCB();
        }

        private void CBoxLeftField_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Left Field";
            ListarPosicionCB();
        }

        private void CBoxPitcher_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Pitcher";
            ListarPosicionCB();
        }

        private void CBoxRightField_DropDown(object sender, EventArgs e)
        {
            Posicion = "Right Field";
            ListarPosicionCB();
        }

        private void CBoxSegundaBase_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Segunda Base";
            ListarPosicionCB();
        }

        private void CBoxPrimeraBase_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Primera Base";
            ListarPosicionCB();
        }

        private void CBoxTerceraBase_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Tercera Base";
            ListarPosicionCB();
        }

        private void CBoxShortStop_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Short Stop";
            ListarPosicionCB();
        }

        private void CBoxCatcher_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Catcher";
            ListarPosicionCB();
        }

        private void CBoxBateadorDes_DropDown_1(object sender, EventArgs e)
        {
            Posicion = "Bateador Desig";
            ListarPosicionCB();
        }
    }
}
