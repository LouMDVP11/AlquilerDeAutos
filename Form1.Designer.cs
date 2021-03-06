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
            this.label3 = new System.Windows.Forms.Label();
            this.rbNit = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbPlaca = new System.Windows.Forms.RadioButton();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.gestionesToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
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
            this.agregarAutomóvilToolStripMenuItem.Text = " Agregar automóvil";
            // 
            // agregarAlquilerToolStripMenuItem
            // 
            this.agregarAlquilerToolStripMenuItem.Name = "agregarAlquilerToolStripMenuItem";
            this.agregarAlquilerToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.agregarAlquilerToolStripMenuItem.Text = "Agregar alquiler";
            // 
            // devolverUnAutomóvilToolStripMenuItem
            // 
            this.devolverUnAutomóvilToolStripMenuItem.Name = "devolverUnAutomóvilToolStripMenuItem";
            this.devolverUnAutomóvilToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.devolverUnAutomóvilToolStripMenuItem.Text = "Devolver un automóvil";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.actualizarToolStripMenuItem.Text = "↻ Actualizar";
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
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehículos en alquiler";
            // 
            // dtgVehiculosAlquiler
            // 
            this.dtgVehiculosAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculosAlquiler.Location = new System.Drawing.Point(12, 286);
            this.dtgVehiculosAlquiler.Name = "dtgVehiculosAlquiler";
            this.dtgVehiculosAlquiler.RowHeadersWidth = 51;
            this.dtgVehiculosAlquiler.RowTemplate.Height = 24;
            this.dtgVehiculosAlquiler.Size = new System.Drawing.Size(773, 122);
            this.dtgVehiculosAlquiler.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar por: ";
            // 
            // rbNit
            // 
            this.rbNit.AutoSize = true;
            this.rbNit.Location = new System.Drawing.Point(103, 200);
            this.rbNit.Name = "rbNit";
            this.rbNit.Size = new System.Drawing.Size(51, 21);
            this.rbNit.TabIndex = 8;
            this.rbNit.TabStop = true;
            this.rbNit.Text = "NIT";
            this.rbNit.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(171, 200);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 9;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbPlaca
            // 
            this.rbPlaca.AutoSize = true;
            this.rbPlaca.Location = new System.Drawing.Point(266, 200);
            this.rbPlaca.Name = "rbPlaca";
            this.rbPlaca.Size = new System.Drawing.Size(64, 21);
            this.rbPlaca.TabIndex = 10;
            this.rbPlaca.TabStop = true;
            this.rbPlaca.Text = "Placa";
            this.rbPlaca.UseVisualStyleBackColor = true;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(40, 235);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(52, 17);
            this.lblCampo.TabIndex = 11;
            this.lblCampo.Text = "Campo";
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(103, 232);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(315, 24);
            this.cmbCampo.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(444, 232);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(551, 232);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(101, 23);
            this.btnReestablecer.TabIndex = 14;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.rbPlaca);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.rbNit);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNit;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbPlaca;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReestablecer;
    }
}

