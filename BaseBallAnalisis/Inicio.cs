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
    public partial class Inicio : Form
    {
        Timer gg = new Timer();
        Capa_Negocios Datos = new Capa_Negocios();
        DataTable d1, d2, d3;

        public Inicio()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            gg.Interval = 1000;
            gg.Tick += new EventHandler(this.T_Tick);
            gg.Start();
            d1 = Datos.ContarEquipos();
            d2 = Datos.ContarJugadores();
            d3 = Datos.ContarJuegos();
            btnEquipos.Text = Convert.ToString(d1.Rows[0]["Equipo"]);
            btnJuegos.Text = Convert.ToString(d3.Rows[0]["JUEGOS"]);
            btnJugadores.Text = Convert.ToString(d2.Rows[0]["JUGADOR"]);
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string Time = "";

            if (hh < 10)
            {
                Time += "0" + hh;
            }
            else
            {
                Time += hh;
            }
            Time += ":";

            if (mm < 10)
            {
                Time += "0" + mm;
            }
            else
            {
                Time += mm;
            }
            Time += ":";

            if (ss < 10)
            {
                Time += "0" + ss;
            }
            else
            {
                Time += ss;
            }

            LbTime.Text = Time;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
