namespace AlquilerDeAutos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutomóvilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverUnAutomóvilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgVehiculosDisponibles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgVehiculosAlquiler = new System.Windows.Forms.DataGridView();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.cmbNIT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMayorKm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculosAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionesToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionesToolStripMenuItem
            // 
            this.gestionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteNuevoToolStripMenuItem,
            this.agregarAutomóvilToolStripMenuItem,
            this.agregarAlquilerToolStripMenuItem,
            this.devolverUnAutomóvilToolStripMenuItem});
            this.gestionesToolStripMenuItem.Name = "gestionesToolStripMenuItem";
            this.gestionesToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.gestionesToolStripMenuItem.Text = "📝 Gestiones";
            // 
            // clienteNuevoToolStripMenuItem
            // 
            this.clienteNuevoToolStripMenuItem.Name = "clienteNuevoToolStripMenuItem";
            this.clienteNuevoToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.clienteNuevoToolStripMenuItem.Text = "Agregar Cliente";
            this.clienteNuevoToolStripMenuItem.Click += new System.EventHandler(this.clienteNuevoToolStripMenuItem_Click);
            // 
            // agregarAutomóvilToolStripMenuItem
            // 
            this.agregarAutomóvilToolStripMenuItem.Name = "agregarAutomóvilToolStripMenuItem";
            this.agregarAutomóvilToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.agregarAutomóvilToolStripMenuItem.Text = "Agregar automóvil";
            this.agregarAutomóvilToolStripMenuItem.Click += new System.EventHandler(this.agregarAutomóvilToolStripMenuItem_Click);
            // 
            // agregarAlquilerToolStripMenuItem
            // 
            this.agregarAlquilerToolStripMenuItem.Name = "agregarAlquilerToolStripMenuItem";
            this.agregarAlquilerToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.agregarAlquilerToolStripMenuItem.Text = "Agregar alquiler";
            this.agregarAlquilerToolStripMenuItem.Click += new System.EventHandler(this.agregarAlquilerToolStripMenuItem_Click);
            // 
            // devolverUnAutomóvilToolStripMenuItem
            // 
            this.devolverUnAutomóvilToolStripMenuItem.Name = "devolverUnAutomóvilToolStripMenuItem";
            this.devolverUnAutomóvilToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.devolverUnAutomóvilToolStripMenuItem.Text = "Devolver un automóvil";
            this.devolverUnAutomóvilToolStripMenuItem.Click += new System.EventHandler(this.devolverUnAutomóvilToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.actualizarToolStripMenuItem.Text = "↻ Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // dtgVehiculosDisponibles
            // 
            this.dtgVehiculosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculosDisponibles.Location = new System.Drawing.Point(12, 64);
            this.dtgVehiculosDisponibles.Name = "dtgVehiculosDisponibles";
            this.dtgVehiculosDisponibles.RowHeadersWidth = 51;
            this.dtgVehiculosDisponibles.RowTemplate.Height = 24;
            this.dtgVehiculosDisponibles.Size = new System.Drawing.Size(773, 122);
            this.dtgVehiculosDisponibles.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehículos disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehículos en alquiler";
            // 
            // dtgVehiculosAlquiler
            // 
            this.dtgVehiculosAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculosAlquiler.Location = new System.Drawing.Point(12, 268);
            this.dtgVehiculosAlquiler.Name = "dtgVehiculosAlquiler";
            this.dtgVehiculosAlquiler.RowHeadersWidth = 51;
            this.dtgVehiculosAlquiler.RowTemplate.Height = 24;
            this.dtgVehiculosAlquiler.Size = new System.Drawing.Size(773, 122);
            this.dtgVehiculosAlquiler.TabIndex = 6;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(12, 211);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 17);
            this.lblCampo.TabIndex = 11;
            this.lblCampo.Text = "Placa";
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Location = new System.Drawing.Point(75, 208);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(128, 24);
            this.cmbPlaca.TabIndex = 12;
            this.cmbPlaca.SelectedIndexChanged += new System.EventHandler(this.cmbPlaca_SelectedIndexChanged);
            this.cmbPlaca.SelectedValueChanged += new System.EventHandler(this.cmbPlaca_SelectedValueChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(439, 204);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 30);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Enabled = false;
            this.btnReestablecer.Location = new System.Drawing.Point(546, 204);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(113, 30);
            this.btnReestablecer.TabIndex = 14;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click_1);
            // 
            // cmbNIT
            // 
            this.cmbNIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNIT.FormattingEnabled = true;
            this.cmbNIT.Location = new System.Drawing.Point(282, 208);
            this.cmbNIT.Name = "cmbNIT";
            this.cmbNIT.Size = new System.Drawing.Size(128, 24);
            this.cmbNIT.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "NIT";
            // 
            // lblMayorPago
            // 
            this.lblMayorKm.AutoSize = true;
            this.lblMayorKm.Location = new System.Drawing.Point(12, 393);
            this.lblMayorKm.Name = "lblMayorPago";
            this.lblMayorKm.Size = new System.Drawing.Size(0, 17);
            this.lblMayorKm.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.lblMayorKm);
            this.Controls.Add(this.cmbNIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbPlaca);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.dtgVehiculosAlquiler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgVehiculosDisponibles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Autos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculosAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAutomóvilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverUnAutomóvilToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgVehiculosDisponibles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgVehiculosAlquiler;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.ComboBox cmbNIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMayorKm;
    }
}

