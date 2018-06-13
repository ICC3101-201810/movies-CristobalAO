namespace Movies
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
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.panelBievenida = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCriticas = new System.Windows.Forms.Button();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.btnEstudios = new System.Windows.Forms.Button();
            this.btnProductores = new System.Windows.Forms.Button();
            this.btnDirectores = new System.Windows.Forms.Button();
            this.btnActores = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.dgvBotones = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelVer = new System.Windows.Forms.Panel();
            this.lbBotones = new System.Windows.Forms.ListBox();
            this.panelCriticas = new System.Windows.Forms.Panel();
            this.pbCriticar = new System.Windows.Forms.PictureBox();
            this.cbPeliculas = new System.Windows.Forms.ComboBox();
            this.dgvCriticas = new System.Windows.Forms.DataGridView();
            this.btnVolverCriticas = new System.Windows.Forms.Button();
            this.panelBievenida.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBotones)).BeginInit();
            this.panelVer.SuspendLayout();
            this.panelCriticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCriticar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticas)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMensaje
            // 
            this.timerMensaje.Enabled = true;
            this.timerMensaje.Interval = 5000;
            this.timerMensaje.Tick += new System.EventHandler(this.timerMensaje_Tick);
            // 
            // panelBievenida
            // 
            this.panelBievenida.Controls.Add(this.label1);
            this.panelBievenida.Location = new System.Drawing.Point(12, 12);
            this.panelBievenida.Name = "panelBievenida";
            this.panelBievenida.Size = new System.Drawing.Size(200, 100);
            this.panelBievenida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.button2);
            this.panelBusqueda.Controls.Add(this.btnCriticas);
            this.panelBusqueda.Controls.Add(this.lbResultados);
            this.panelBusqueda.Controls.Add(this.lbBusqueda);
            this.panelBusqueda.Controls.Add(this.tbBusqueda);
            this.panelBusqueda.Controls.Add(this.btnEstudios);
            this.panelBusqueda.Controls.Add(this.btnProductores);
            this.panelBusqueda.Controls.Add(this.btnDirectores);
            this.panelBusqueda.Controls.Add(this.btnActores);
            this.panelBusqueda.Controls.Add(this.btnPeliculas);
            this.panelBusqueda.Location = new System.Drawing.Point(218, 12);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(604, 172);
            this.panelBusqueda.TabIndex = 1;
            this.panelBusqueda.Click += new System.EventHandler(this.panelBusqueda_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(555, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "S                 A                 L                 I                 R ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCriticas
            // 
            this.btnCriticas.Location = new System.Drawing.Point(506, 93);
            this.btnCriticas.Name = "btnCriticas";
            this.btnCriticas.Size = new System.Drawing.Size(75, 23);
            this.btnCriticas.TabIndex = 10;
            this.btnCriticas.Text = "Criticas";
            this.btnCriticas.UseVisualStyleBackColor = true;
            this.btnCriticas.Click += new System.EventHandler(this.btnCriticas_Click);
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(26, 36);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(555, 56);
            this.lbResultados.TabIndex = 7;
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(23, 47);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lbBusqueda.TabIndex = 6;
            this.lbBusqueda.Text = "label2";
            this.lbBusqueda.Click += new System.EventHandler(this.lbBusqueda_Click);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(26, 17);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(555, 20);
            this.tbBusqueda.TabIndex = 5;
            this.tbBusqueda.Text = "🔎 Busqueda...";
            this.tbBusqueda.Click += new System.EventHandler(this.tbBusqueda_Click);
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // btnEstudios
            // 
            this.btnEstudios.Location = new System.Drawing.Point(412, 93);
            this.btnEstudios.Name = "btnEstudios";
            this.btnEstudios.Size = new System.Drawing.Size(75, 23);
            this.btnEstudios.TabIndex = 4;
            this.btnEstudios.Text = "Estudios";
            this.btnEstudios.UseVisualStyleBackColor = true;
            this.btnEstudios.Click += new System.EventHandler(this.btnEstudios_Click_1);
            // 
            // btnProductores
            // 
            this.btnProductores.Location = new System.Drawing.Point(318, 93);
            this.btnProductores.Name = "btnProductores";
            this.btnProductores.Size = new System.Drawing.Size(75, 23);
            this.btnProductores.TabIndex = 3;
            this.btnProductores.Text = "Productores";
            this.btnProductores.UseVisualStyleBackColor = true;
            this.btnProductores.Click += new System.EventHandler(this.btnProductores_Click_1);
            // 
            // btnDirectores
            // 
            this.btnDirectores.Location = new System.Drawing.Point(220, 93);
            this.btnDirectores.Name = "btnDirectores";
            this.btnDirectores.Size = new System.Drawing.Size(75, 23);
            this.btnDirectores.TabIndex = 2;
            this.btnDirectores.Text = "Directores";
            this.btnDirectores.UseVisualStyleBackColor = true;
            this.btnDirectores.Click += new System.EventHandler(this.btnDirectores_Click_1);
            // 
            // btnActores
            // 
            this.btnActores.Location = new System.Drawing.Point(124, 93);
            this.btnActores.Name = "btnActores";
            this.btnActores.Size = new System.Drawing.Size(75, 23);
            this.btnActores.TabIndex = 1;
            this.btnActores.Text = "Actores";
            this.btnActores.UseVisualStyleBackColor = true;
            this.btnActores.Click += new System.EventHandler(this.btnActores_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Location = new System.Drawing.Point(26, 93);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(75, 23);
            this.btnPeliculas.TabIndex = 0;
            this.btnPeliculas.Text = "Peliculas";
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // dgvBotones
            // 
            this.dgvBotones.AllowUserToAddRows = false;
            this.dgvBotones.AllowUserToDeleteRows = false;
            this.dgvBotones.AllowUserToResizeRows = false;
            this.dgvBotones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBotones.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvBotones.Location = new System.Drawing.Point(26, 244);
            this.dgvBotones.MultiSelect = false;
            this.dgvBotones.Name = "dgvBotones";
            this.dgvBotones.ReadOnly = true;
            this.dgvBotones.Size = new System.Drawing.Size(667, 62);
            this.dgvBotones.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(26, 323);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(667, 33);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "V                 O                 L                 V                 E        " +
    "         R";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelVer
            // 
            this.panelVer.Controls.Add(this.lbBotones);
            this.panelVer.Controls.Add(this.btnVolver);
            this.panelVer.Controls.Add(this.dgvBotones);
            this.panelVer.Location = new System.Drawing.Point(12, 190);
            this.panelVer.Name = "panelVer";
            this.panelVer.Size = new System.Drawing.Size(714, 380);
            this.panelVer.TabIndex = 1;
            // 
            // lbBotones
            // 
            this.lbBotones.FormattingEnabled = true;
            this.lbBotones.Location = new System.Drawing.Point(26, 22);
            this.lbBotones.Name = "lbBotones";
            this.lbBotones.Size = new System.Drawing.Size(667, 199);
            this.lbBotones.TabIndex = 9;
            this.lbBotones.SelectedIndexChanged += new System.EventHandler(this.lbBotones_SelectedIndexChanged);
            // 
            // panelCriticas
            // 
            this.panelCriticas.Controls.Add(this.pbCriticar);
            this.panelCriticas.Controls.Add(this.cbPeliculas);
            this.panelCriticas.Controls.Add(this.dgvCriticas);
            this.panelCriticas.Controls.Add(this.btnVolverCriticas);
            this.panelCriticas.Location = new System.Drawing.Point(732, 190);
            this.panelCriticas.Name = "panelCriticas";
            this.panelCriticas.Size = new System.Drawing.Size(428, 380);
            this.panelCriticas.TabIndex = 1;
            // 
            // pbCriticar
            // 
            this.pbCriticar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCriticar.Image = ((System.Drawing.Image)(resources.GetObject("pbCriticar.Image")));
            this.pbCriticar.Location = new System.Drawing.Point(356, 22);
            this.pbCriticar.Name = "pbCriticar";
            this.pbCriticar.Size = new System.Drawing.Size(62, 55);
            this.pbCriticar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCriticar.TabIndex = 12;
            this.pbCriticar.TabStop = false;
            // 
            // cbPeliculas
            // 
            this.cbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeliculas.FormattingEnabled = true;
            this.cbPeliculas.Location = new System.Drawing.Point(7, 22);
            this.cbPeliculas.Name = "cbPeliculas";
            this.cbPeliculas.Size = new System.Drawing.Size(343, 21);
            this.cbPeliculas.TabIndex = 11;
            this.cbPeliculas.SelectedIndexChanged += new System.EventHandler(this.cbPeliculas_SelectedIndexChanged);
            // 
            // dgvCriticas
            // 
            this.dgvCriticas.AllowUserToAddRows = false;
            this.dgvCriticas.AllowUserToDeleteRows = false;
            this.dgvCriticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriticas.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvCriticas.Location = new System.Drawing.Point(7, 83);
            this.dgvCriticas.MultiSelect = false;
            this.dgvCriticas.Name = "dgvCriticas";
            this.dgvCriticas.ReadOnly = true;
            this.dgvCriticas.Size = new System.Drawing.Size(411, 250);
            this.dgvCriticas.TabIndex = 10;
            // 
            // btnVolverCriticas
            // 
            this.btnVolverCriticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCriticas.Location = new System.Drawing.Point(7, 339);
            this.btnVolverCriticas.Name = "btnVolverCriticas";
            this.btnVolverCriticas.Size = new System.Drawing.Size(411, 33);
            this.btnVolverCriticas.TabIndex = 10;
            this.btnVolverCriticas.Text = "V         O         L         V         E         R";
            this.btnVolverCriticas.UseVisualStyleBackColor = true;
            this.btnVolverCriticas.Click += new System.EventHandler(this.btnVolverCriticas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1227, 626);
            this.Controls.Add(this.panelCriticas);
            this.Controls.Add(this.panelVer);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelBievenida);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing_1);
            this.panelBievenida.ResumeLayout(false);
            this.panelBievenida.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBotones)).EndInit();
            this.panelVer.ResumeLayout(false);
            this.panelCriticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCriticar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.Panel panelBievenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Button btnEstudios;
        private System.Windows.Forms.Button btnProductores;
        private System.Windows.Forms.Button btnDirectores;
        private System.Windows.Forms.Button btnActores;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.DataGridView dgvBotones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelVer;
        private System.Windows.Forms.ListBox lbBotones;
        private System.Windows.Forms.Button btnCriticas;
        private System.Windows.Forms.Panel panelCriticas;
        private System.Windows.Forms.PictureBox pbCriticar;
        private System.Windows.Forms.ComboBox cbPeliculas;
        private System.Windows.Forms.DataGridView dgvCriticas;
        private System.Windows.Forms.Button btnVolverCriticas;
        private System.Windows.Forms.Button button2;
    }
}

