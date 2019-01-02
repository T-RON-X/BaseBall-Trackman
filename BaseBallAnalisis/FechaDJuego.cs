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
    public partial class FechaDJuego : Form
    {
        Capa_Negocios Datos = new Capa_Negocios();
        DataTable dt;
        public FechaDJuego()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dateTimePicker1.Value;
                dt = Datos.InsertarJuegos(fecha);
                if (dt.Rows.Count == 1)
                {
                    ClaseCompartida.Juego_ID = Convert.ToInt32(dt.Rows[0]["Juego_ID"]);
                }
                Seleccion_de_equipos Frm = new Seleccion_de_equipos();
                MessageBox.Show("Se inserto Correctamente");
                Frm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
        }
    }
}
