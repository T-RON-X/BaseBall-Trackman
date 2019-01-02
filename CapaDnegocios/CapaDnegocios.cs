using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDdatos;

namespace CapaDnegocios
{
    public class Capa_Negocios
    {
        private CD_Jugadores JugadorCD = new CD_Jugadores();
        private CD_Equipo EquipoCD = new CD_Equipo();
        CD_Jugadas JugadasCD = new CD_Jugadas();
        Ining_CD IningCD = new Ining_CD();
        CD_Contar Contar = new CD_Contar();

        public DataTable MostrarJugadores(string Variable, string Modo)
        {
            DataTable tabla = new DataTable();
            tabla = JugadorCD.Mostrar(Variable, Modo);
            return tabla;
        }
        
        public DataTable MostrarEquipos()
        {
            DataTable tabla = new DataTable();
            tabla = EquipoCD.Mostrar();
            return tabla;
        }

        public DataTable ContarJuegos()
        {
            DataTable tabla = new DataTable();
            tabla = Contar.ContarJuegos();
            return tabla;
        }

        public DataTable ContarJugadores()
        {
            DataTable tabla = new DataTable();
            tabla = Contar.ContarJugadores();
            return tabla;
        }

        public DataTable ContarEquipos()
        {
            DataTable tabla = new DataTable();
            tabla = Contar.ContarEquipos();
            return tabla;
        }

        public DataTable dataTable()
        {
            DataTable tabla = new DataTable();
            tabla = EquipoCD.Mostrar();
            return tabla;
        }



        public DataTable ReporteJuego(DateTime FechaDJuego)
        {
            DataTable tabla = new DataTable();
            tabla = IningCD.ReporteJuego(FechaDJuego);
            return tabla;
        }


        public void InsertarJugador(string Documento, int Equipo, string Nombre, string Apellido, string Peso, string Estatura, string Edad, string Estado)
        {
            JugadorCD.insertarJugador(Documento, Equipo, Nombre, Apellido, Convert.ToInt32(Peso), Convert.ToInt32(Estatura), Convert.ToInt32(Edad), Convert.ToBoolean(Estado));
        }

        public void InsertarRelacion(string Documento, int ps)
        {
            JugadorCD.insertarPosision(Documento, ps);
        }

        public void EditarJugador(string Documento, int Equipo, string Nombre, string Apellido, string Peso, string Estatura, string Edad, string Estado)
        {
            JugadorCD.EditarJugador(Documento, Equipo, Nombre, Apellido, Convert.ToInt32(Peso), Convert.ToInt32(Estatura), Convert.ToInt32(Edad), Convert.ToBoolean(Estado));
        }

        public void EditarPosicion(string Documento, int ps)
        {
            JugadorCD.EditarPosicion(Documento, ps);
        }

        public void InsertarEquipo(string Nombre)
        {
            EquipoCD.InsertarEquipo(Nombre);
        }
        
        public void EditarEquipo(string Nombre, int ID)
        {
            EquipoCD.EditarEquipo(Nombre, ID);
        }

        public void InsertarRela_Bateador_Turno(int IDJudador, int IDTurno)
        {
            EquipoCD.InsertarRela_Bateador_Turno(IDJudador, IDTurno);
        }

        public DataTable GuardarJugada(int NombreJugada, int BolaTrayectoria, int FuerzaBateo, bool Primera, bool Segunda, bool Tercera)
        {
            DataTable tabla = new DataTable();
            tabla = JugadasCD.GuardarJugadas(NombreJugada, BolaTrayectoria, FuerzaBateo, Primera, Segunda, Tercera);
            return tabla;
        }

        public DataTable GuardarTurno(int IDPitcher, int Velocidad, int IDSwing, int IDStrikeZ, int IDCantado)
        {
            DataTable tabla = new DataTable();
            tabla = JugadasCD.GuardarTurno(IDPitcher, Velocidad, IDSwing, IDStrikeZ, IDCantado);
            return tabla;
        }
        public DataTable InsertarJuegos(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            tabla = JugadasCD.InsertarJuegos(fecha);
            return tabla;
        }
        
        public DataTable RelacionJuegoIning(int IningID, int JuegoID, int JugadaID)
        {
            DataTable tabla = new DataTable();
            tabla = IningCD.RelacionJuegoIning(IningID, JuegoID, JugadaID);
            return tabla;
        }


        public DataTable GuardarIning(int IningNumero, int TurnoID, int JugadaID, int CarreraH, int CarreraV)
        {
            DataTable tabla = new DataTable();
            tabla = IningCD.GuardarIning(IningNumero, TurnoID, JugadaID, CarreraH, CarreraV);
            return tabla;
        }
    }

    public class CN_ComboBox
    {
        private CD_ComboBox objetoComboEquipos = new CD_ComboBox();

        public DataTable MostrarLista()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objetoComboEquipos.MostrarEquipos();
            return tabla1;
        }

        public DataTable MostrarPosicionJugador(string Equipo, string Posicion)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objetoComboEquipos.MostrarPosicionJugador(Equipo, Posicion);
            return tabla2;
        }

        public DataTable MostrarTipoSwing()
        {
            DataTable tabla3 = new DataTable();
            tabla3 = objetoComboEquipos.MostrarTipoSwing();
            return tabla3;
        }

        public DataTable MostrarStrikeZone()
        {
            DataTable tabla4 = new DataTable();
            tabla4 = objetoComboEquipos.MostrarStrikeZone();
            return tabla4;
        }

        public DataTable MostrarCantado()
        {
            DataTable tabla5 = new DataTable();
            tabla5 = objetoComboEquipos.MostrarCantado();
            return tabla5;
        }

        public DataTable MostrarJugada()
        {
            DataTable tabla6 = new DataTable();
            tabla6 = objetoComboEquipos.MostrarJugada();
            return tabla6;
        }

        public DataTable MostrarTrayectoria()
        {
            DataTable tabla7 = new DataTable();
            tabla7 = objetoComboEquipos.MostrarTrayectoria();
            return tabla7;
        }

        public DataTable MostrarPitch()
        {
            DataTable tabla7 = new DataTable();
            tabla7 = objetoComboEquipos.MostrarPitch();
            return tabla7;
        }

        public DataTable BuscarBateador(string Equipo)
        {
            DataTable tabla8 = new DataTable();
            tabla8 = objetoComboEquipos.BuscarBateador(Equipo);
            return tabla8;
        }
    }
}