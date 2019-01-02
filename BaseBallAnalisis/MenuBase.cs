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
    public partial class MenuBase : Form
    {

        
        public MenuBase()
        {
            InitializeComponent();
            AbrirFormInPanel(new Inicio());
        }

        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void MenuBase_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPelotero_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RegistoProspecto());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ReporteJuego());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            FechaDJuego FormSelec = new FechaDJuego();
            FormSelec.Show();

            AbrirFormInPanel(new Analisis_Bateo());
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarEquipo_Click(object sender, EventArgs e)
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Busqueda());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Inicio());
        }

        private void btnRegistrarEquipo_Click_1(object sender, EventArgs e)
        {
            Equipos frm = new Equipos();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
