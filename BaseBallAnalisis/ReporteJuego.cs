using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseBallAnalisis
{
    public partial class ReporteJuego : Form
    {
        public ReporteJuego()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReporteDeJuegosDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.FillJuego(this.ReporteDeJuegosDataSet.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
