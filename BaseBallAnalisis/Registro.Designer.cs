namespace BaseBallAnalisis
{
    partial class RegistoProspecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistoProspecto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.CbxEquipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.LbEstatura = new System.Windows.Forms.Label();
            this.txtDocumentoID = new System.Windows.Forms.TextBox();
            this.LbApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LbDocumentoID = new System.Windows.Forms.Label();
            this.Lbnombre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkboxCenterField = new System.Windows.Forms.CheckBox();
            this.checkBoxTerceraBase = new System.Windows.Forms.CheckBox();
            this.checkBoxShortStop = new System.Windows.Forms.CheckBox();
            this.checkBoxSecondBase = new System.Windows.Forms.CheckBox();
            this.CheckBoxPrimeraBase = new System.Windows.Forms.CheckBox();
            this.checkBoxPitcher = new System.Windows.Forms.CheckBox();
            this.checkBoxRigthField = new System.Windows.Forms.CheckBox();
            this.checkBoxLeftField = new System.Windows.Forms.CheckBox();
            this.checkBoxCatcher = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBateador = new System.Windows.Forms.CheckBox();
            this.checkBoxBateadorDesignado = new System.Windows.Forms.CheckBox();
            this.GBPosiciones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GBPosiciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.CbxEquipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEstatura);
            this.groupBox1.Controls.Add(this.LbEstatura);
            this.groupBox1.Controls.Add(this.txtDocumentoID);
            this.groupBox1.Controls.Add(this.LbApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LbDocumentoID);
            this.groupBox1.Controls.Add(this.Lbnombre);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(888, 863);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Informacion Personal";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.txtEdad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEdad.Location = new System.Drawing.Point(467, 637);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(329, 44);
            this.txtEdad.TabIndex = 15;
            // 
            // CbxEquipo
            // 
            this.CbxEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.CbxEquipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CbxEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbxEquipo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CbxEquipo.FormattingEnabled = true;
            this.CbxEquipo.Location = new System.Drawing.Point(64, 506);
            this.CbxEquipo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CbxEquipo.Name = "CbxEquipo";
            this.CbxEquipo.Size = new System.Drawing.Size(471, 45);
            this.CbxEquipo.TabIndex = 13;
            this.CbxEquipo.DropDown += new System.EventHandler(this.CbxEquipo_SelectedIndexChanged);
            this.CbxEquipo.SelectedIndexChanged += new System.EventHandler(this.CbxEquipo_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Equipo";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.txtPeso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPeso.Location = new System.Drawing.Point(64, 637);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(329, 44);
            this.txtPeso.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 599);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Peso (Libra)";
            // 
            // txtEstatura
            // 
            this.txtEstatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.txtEstatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEstatura.Location = new System.Drawing.Point(64, 754);
            this.txtEstatura.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(329, 44);
            this.txtEstatura.TabIndex = 16;
            // 
            // LbEstatura
            // 
            this.LbEstatura.AutoSize = true;
            this.LbEstatura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbEstatura.Location = new System.Drawing.Point(56, 715);
            this.LbEstatura.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LbEstatura.Name = "LbEstatura";
            this.LbEstatura.Size = new System.Drawing.Size(214, 38);
            this.LbEstatura.TabIndex = 15;
            this.LbEstatura.Text = "Estatura (cm)";
            // 
            // txtDocumentoID
            // 
            this.txtDocumentoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.txtDocumentoID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDocumentoID.Location = new System.Drawing.Point(64, 367);
            this.txtDocumentoID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDocumentoID.Name = "txtDocumentoID";
            this.txtDocumentoID.Size = new System.Drawing.Size(484, 44);
            this.txtDocumentoID.TabIndex = 12;
            this.txtDocumentoID.TextChanged += new System.EventHandler(this.txtDocumentoID_TextChanged);
            // 
            // LbApellido
            // 
            this.LbApellido.AutoSize = true;
            this.LbApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbApellido.Location = new System.Drawing.Point(56, 198);
            this.LbApellido.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LbApellido.Name = "LbApellido";
            this.LbApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbApellido.Size = new System.Drawing.Size(132, 38);
            this.LbApellido.TabIndex = 1;
            this.LbApellido.Text = "Apellido";
            this.LbApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(64, 122);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(484, 44);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApellido.Location = new System.Drawing.Point(64, 243);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(484, 44);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(467, 599);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(93, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edad";
            // 
            // LbDocumentoID
            // 
            this.LbDocumentoID.AutoSize = true;
            this.LbDocumentoID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbDocumentoID.Location = new System.Drawing.Point(56, 329);
            this.LbDocumentoID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LbDocumentoID.Name = "LbDocumentoID";
            this.LbDocumentoID.Size = new System.Drawing.Size(279, 38);
            this.LbDocumentoID.TabIndex = 2;
            this.LbDocumentoID.Text = "Documento de ID.";
            this.LbDocumentoID.Click += new System.EventHandler(this.LbDocumentoID_Click);
            // 
            // Lbnombre
            // 
            this.Lbnombre.AutoSize = true;
            this.Lbnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbnombre.Location = new System.Drawing.Point(56, 83);
            this.Lbnombre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbnombre.Name = "Lbnombre";
            this.Lbnombre.Size = new System.Drawing.Size(133, 38);
            this.Lbnombre.TabIndex = 0;
            this.Lbnombre.Text = "Nombre";
            this.Lbnombre.Click += new System.EventHandler(this.Lbnombre_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1468, 951);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // checkboxCenterField
            // 
            this.checkboxCenterField.AutoSize = true;
            this.checkboxCenterField.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkboxCenterField.Location = new System.Drawing.Point(685, 122);
            this.checkboxCenterField.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkboxCenterField.Name = "checkboxCenterField";
            this.checkboxCenterField.Size = new System.Drawing.Size(232, 42);
            this.checkboxCenterField.TabIndex = 18;
            this.checkboxCenterField.Text = "Center Field";
            this.checkboxCenterField.UseVisualStyleBackColor = false;
            this.checkboxCenterField.CheckedChanged += new System.EventHandler(this.checkboxCenterField_CheckedChanged);
            // 
            // checkBoxTerceraBase
            // 
            this.checkBoxTerceraBase.AutoSize = true;
            this.checkBoxTerceraBase.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxTerceraBase.Location = new System.Drawing.Point(344, 509);
            this.checkBoxTerceraBase.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxTerceraBase.Name = "checkBoxTerceraBase";
            this.checkBoxTerceraBase.Size = new System.Drawing.Size(252, 42);
            this.checkBoxTerceraBase.TabIndex = 22;
            this.checkBoxTerceraBase.Text = "Tercera Base";
            this.checkBoxTerceraBase.UseVisualStyleBackColor = false;
            this.checkBoxTerceraBase.CheckedChanged += new System.EventHandler(this.checkBoxTerceraBase_CheckedChanged);
            // 
            // checkBoxShortStop
            // 
            this.checkBoxShortStop.AutoSize = true;
            this.checkBoxShortStop.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxShortStop.Location = new System.Drawing.Point(439, 352);
            this.checkBoxShortStop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxShortStop.Name = "checkBoxShortStop";
            this.checkBoxShortStop.Size = new System.Drawing.Size(200, 42);
            this.checkBoxShortStop.TabIndex = 20;
            this.checkBoxShortStop.Text = "ShortStop";
            this.checkBoxShortStop.UseMnemonic = false;
            this.checkBoxShortStop.UseVisualStyleBackColor = false;
            this.checkBoxShortStop.CheckedChanged += new System.EventHandler(this.checkBoxShortStop_CheckedChanged);
            // 
            // checkBoxSecondBase
            // 
            this.checkBoxSecondBase.AutoSize = true;
            this.checkBoxSecondBase.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxSecondBase.Location = new System.Drawing.Point(955, 352);
            this.checkBoxSecondBase.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxSecondBase.Name = "checkBoxSecondBase";
            this.checkBoxSecondBase.Size = new System.Drawing.Size(269, 42);
            this.checkBoxSecondBase.TabIndex = 21;
            this.checkBoxSecondBase.Text = "Segunda Base";
            this.checkBoxSecondBase.UseVisualStyleBackColor = false;
            // 
            // CheckBoxPrimeraBase
            // 
            this.CheckBoxPrimeraBase.AutoSize = true;
            this.CheckBoxPrimeraBase.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CheckBoxPrimeraBase.Location = new System.Drawing.Point(995, 509);
            this.CheckBoxPrimeraBase.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CheckBoxPrimeraBase.Name = "CheckBoxPrimeraBase";
            this.CheckBoxPrimeraBase.Size = new System.Drawing.Size(253, 42);
            this.CheckBoxPrimeraBase.TabIndex = 24;
            this.CheckBoxPrimeraBase.Text = "Primera Base";
            this.CheckBoxPrimeraBase.UseVisualStyleBackColor = false;
            // 
            // checkBoxPitcher
            // 
            this.checkBoxPitcher.AutoSize = true;
            this.checkBoxPitcher.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxPitcher.Location = new System.Drawing.Point(716, 561);
            this.checkBoxPitcher.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxPitcher.Name = "checkBoxPitcher";
            this.checkBoxPitcher.Size = new System.Drawing.Size(157, 42);
            this.checkBoxPitcher.TabIndex = 23;
            this.checkBoxPitcher.Text = "Pitcher";
            this.checkBoxPitcher.UseVisualStyleBackColor = false;
            this.checkBoxPitcher.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBoxRigthField
            // 
            this.checkBoxRigthField.AutoSize = true;
            this.checkBoxRigthField.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxRigthField.Location = new System.Drawing.Point(1101, 165);
            this.checkBoxRigthField.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxRigthField.Name = "checkBoxRigthField";
            this.checkBoxRigthField.Size = new System.Drawing.Size(210, 42);
            this.checkBoxRigthField.TabIndex = 19;
            this.checkBoxRigthField.Text = "Right Field";
            this.checkBoxRigthField.UseVisualStyleBackColor = false;
            // 
            // checkBoxLeftField
            // 
            this.checkBoxLeftField.AutoSize = true;
            this.checkBoxLeftField.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxLeftField.Location = new System.Drawing.Point(331, 165);
            this.checkBoxLeftField.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxLeftField.Name = "checkBoxLeftField";
            this.checkBoxLeftField.Size = new System.Drawing.Size(188, 42);
            this.checkBoxLeftField.TabIndex = 17;
            this.checkBoxLeftField.Text = "Left Field";
            this.checkBoxLeftField.UseVisualStyleBackColor = false;
            // 
            // checkBoxCatcher
            // 
            this.checkBoxCatcher.AutoSize = true;
            this.checkBoxCatcher.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxCatcher.Location = new System.Drawing.Point(716, 855);
            this.checkBoxCatcher.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxCatcher.Name = "checkBoxCatcher";
            this.checkBoxCatcher.Size = new System.Drawing.Size(170, 42);
            this.checkBoxCatcher.TabIndex = 25;
            this.checkBoxCatcher.Text = "Catcher";
            this.checkBoxCatcher.UseVisualStyleBackColor = false;
            this.checkBoxCatcher.CheckedChanged += new System.EventHandler(this.checkBoxCatcher_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(275, 1195);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(339, 95);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBateador);
            this.groupBox2.Controls.Add(this.checkBoxBateadorDesignado);
            this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Location = new System.Drawing.Point(64, 1049);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(517, 212);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Especificacion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // checkBoxBateador
            // 
            this.checkBoxBateador.AutoSize = true;
            this.checkBoxBateador.Location = new System.Drawing.Point(40, 45);
            this.checkBoxBateador.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxBateador.Name = "checkBoxBateador";
            this.checkBoxBateador.Size = new System.Drawing.Size(187, 42);
            this.checkBoxBateador.TabIndex = 26;
            this.checkBoxBateador.Text = "Bateador";
            this.checkBoxBateador.UseVisualStyleBackColor = false;
            // 
            // checkBoxBateadorDesignado
            // 
            this.checkBoxBateadorDesignado.AutoSize = true;
            this.checkBoxBateadorDesignado.Location = new System.Drawing.Point(40, 105);
            this.checkBoxBateadorDesignado.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxBateadorDesignado.Name = "checkBoxBateadorDesignado";
            this.checkBoxBateadorDesignado.Size = new System.Drawing.Size(352, 42);
            this.checkBoxBateadorDesignado.TabIndex = 27;
            this.checkBoxBateadorDesignado.Text = "Bateador Designado";
            this.checkBoxBateadorDesignado.UseVisualStyleBackColor = false;
            this.checkBoxBateadorDesignado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GBPosiciones
            // 
            this.GBPosiciones.Controls.Add(this.checkboxCenterField);
            this.GBPosiciones.Controls.Add(this.checkBoxCatcher);
            this.GBPosiciones.Controls.Add(this.checkBoxLeftField);
            this.GBPosiciones.Controls.Add(this.checkBoxRigthField);
            this.GBPosiciones.Controls.Add(this.checkBoxPitcher);
            this.GBPosiciones.Controls.Add(this.CheckBoxPrimeraBase);
            this.GBPosiciones.Controls.Add(this.checkBoxSecondBase);
            this.GBPosiciones.Controls.Add(this.checkBoxShortStop);
            this.GBPosiciones.Controls.Add(this.checkBoxTerceraBase);
            this.GBPosiciones.Controls.Add(this.groupBox2);
            this.GBPosiciones.Controls.Add(this.pictureBox1);
            this.GBPosiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPosiciones.ForeColor = System.Drawing.Color.AliceBlue;
            this.GBPosiciones.Location = new System.Drawing.Point(984, 29);
            this.GBPosiciones.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GBPosiciones.Name = "GBPosiciones";
            this.GBPosiciones.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GBPosiciones.Size = new System.Drawing.Size(1605, 1359);
            this.GBPosiciones.TabIndex = 16;
            this.GBPosiciones.TabStop = false;
            this.GBPosiciones.Text = "Posiciones";
            this.GBPosiciones.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(19, 1195);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(240, 95);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(629, 1195);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(339, 95);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // RegistoProspecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(2677, 1416);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBPosiciones);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "RegistoProspecto";
            this.Text = "Resgistro de Prospecto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GBPosiciones.ResumeLayout(false);
            this.GBPosiciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbDocumentoID;
        private System.Windows.Forms.Label LbApellido;
        private System.Windows.Forms.Label Lbnombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumentoID;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label LbEstatura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkboxCenterField;
        private System.Windows.Forms.CheckBox checkBoxTerceraBase;
        private System.Windows.Forms.CheckBox checkBoxShortStop;
        private System.Windows.Forms.CheckBox checkBoxSecondBase;
        private System.Windows.Forms.CheckBox CheckBoxPrimeraBase;
        private System.Windows.Forms.CheckBox checkBoxPitcher;
        private System.Windows.Forms.CheckBox checkBoxRigthField;
        private System.Windows.Forms.CheckBox checkBoxLeftField;
        private System.Windows.Forms.CheckBox checkBoxCatcher;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GBPosiciones;
        private System.Windows.Forms.CheckBox checkBoxBateadorDesignado;
        private System.Windows.Forms.CheckBox checkBoxBateador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox CbxEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEdad;
    }
}

