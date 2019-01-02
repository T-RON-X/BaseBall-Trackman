namespace BaseBallAnalisis
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbTime = new System.Windows.Forms.Label();
            this.LbJugadores = new System.Windows.Forms.Label();
            this.LbEquipos = new System.Windows.Forms.Label();
            this.LbJuegos = new System.Windows.Forms.Label();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnJuegos = new System.Windows.Forms.Button();
            this.ProspectAnalizer = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteDJuegos
            // 
            // 
            // dataTable1BindingSource
            // 
            // 
            // dataTable1TableAdapter
            // 

            // 
            // tableAdapterManager
            // 
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbTime.Location = new System.Drawing.Point(887, 127);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(385, 101);
            this.LbTime.TabIndex = 21;
            this.LbTime.Text = "00:00:00";
            // 
            // LbJugadores
            // 
            this.LbJugadores.AutoSize = true;
            this.LbJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbJugadores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbJugadores.Location = new System.Drawing.Point(393, 878);
            this.LbJugadores.Name = "LbJugadores";
            this.LbJugadores.Size = new System.Drawing.Size(379, 83);
            this.LbJugadores.TabIndex = 22;
            this.LbJugadores.Text = "Jugadores";
            // 
            // LbEquipos
            // 
            this.LbEquipos.AutoSize = true;
            this.LbEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEquipos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbEquipos.Location = new System.Drawing.Point(918, 878);
            this.LbEquipos.Name = "LbEquipos";
            this.LbEquipos.Size = new System.Drawing.Size(302, 83);
            this.LbEquipos.TabIndex = 23;
            this.LbEquipos.Text = "Equipos";
            // 
            // LbJuegos
            // 
            this.LbJuegos.AutoSize = true;
            this.LbJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbJuegos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbJuegos.Location = new System.Drawing.Point(1417, 878);
            this.LbJuegos.Name = "LbJuegos";
            this.LbJuegos.Size = new System.Drawing.Size(273, 83);
            this.LbJuegos.TabIndex = 24;
            this.LbJuegos.Text = "Juegos";
            // 
            // btnJugadores
            // 
            this.btnJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.Location = new System.Drawing.Point(431, 1009);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(303, 191);
            this.btnJugadores.TabIndex = 25;
            this.btnJugadores.Text = "0";
            this.btnJugadores.UseVisualStyleBackColor = true;
            // 
            // btnEquipos
            // 
            this.btnEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.Location = new System.Drawing.Point(918, 1009);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(303, 191);
            this.btnEquipos.TabIndex = 26;
            this.btnEquipos.Text = "0";
            this.btnEquipos.UseVisualStyleBackColor = true;
            // 
            // btnJuegos
            // 
            this.btnJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuegos.Location = new System.Drawing.Point(1402, 1009);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Size = new System.Drawing.Size(303, 191);
            this.btnJuegos.TabIndex = 27;
            this.btnJuegos.Text = "0";
            this.btnJuegos.UseVisualStyleBackColor = true;
            // 
            // ProspectAnalizer
            // 
            this.ProspectAnalizer.AutoSize = true;
            this.ProspectAnalizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProspectAnalizer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProspectAnalizer.Location = new System.Drawing.Point(767, 9);
            this.ProspectAnalizer.Name = "ProspectAnalizer";
            this.ProspectAnalizer.Size = new System.Drawing.Size(624, 101);
            this.ProspectAnalizer.TabIndex = 28;
            this.ProspectAnalizer.Text = "Game Analizer";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(685, 245);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(788, 521);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 29;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(2218, 1318);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.ProspectAnalizer);
            this.Controls.Add(this.btnJuegos);
            this.Controls.Add(this.btnEquipos);
            this.Controls.Add(this.btnJugadores);
            this.Controls.Add(this.LbJuegos);
            this.Controls.Add(this.LbEquipos);
            this.Controls.Add(this.LbJugadores);
            this.Controls.Add(this.LbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbJugadores;
        private System.Windows.Forms.Label LbEquipos;
        private System.Windows.Forms.Label LbJuegos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnJuegos;
        private System.Windows.Forms.Label ProspectAnalizer;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}