namespace AlquilerDeAutos
{
    partial class frmDevoluciones
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
            this.label6 = new System.Windows.Forms.Label();
            this.dtgDevoluciones = new System.Windows.Forms.DataGridView();
            this.btnDevolución = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.cmbNIT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudKm = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Devoluciones realizadas";
            // 
            // dtgDevoluciones
            // 
            this.dtgDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevoluciones.Location = new System.Drawing.Point(28, 200);
            this.dtgDevoluciones.Name = "dtgDevoluciones";
            this.dtgDevoluciones.RowHeadersWidth = 51;
            this.dtgDevoluciones.RowTemplate.Height = 24;
            this.dtgDevoluciones.Size = new System.Drawing.Size(497, 199);
            this.dtgDevoluciones.TabIndex = 22;
            // 
            // btnDevolución
            // 
            this.btnDevolución.Location = new System.Drawing.Point(416, 139);
            this.btnDevolución.Name = "btnDevolución";
            this.btnDevolución.Size = new System.Drawing.Size(95, 29);
            this.btnDevolución.TabIndex = 21;
            this.btnDevolución.Text = "Devolver";
            this.btnDevolución.UseVisualStyleBackColor = true;
            this.btnDevolución.Click += new System.EventHandler(this.btnDevolución_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Devolución de un Vehículo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucion.Location = new System.Drawing.Point(398, 105);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(128, 22);
            this.dtpDevolucion.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha de Devolución\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Placa";
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Location = new System.Drawing.Point(254, 72);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(121, 24);
            this.cmbPlaca.TabIndex = 16;
            this.cmbPlaca.SelectedIndexChanged += new System.EventHandler(this.cmbPlaca_SelectedIndexChanged);
            // 
            // cmbNIT
            // 
            this.cmbNIT.FormattingEnabled = true;
            this.cmbNIT.Location = new System.Drawing.Point(74, 72);
            this.cmbNIT.Name = "cmbNIT";
            this.cmbNIT.Size = new System.Drawing.Size(107, 24);
            this.cmbNIT.TabIndex = 13;
            this.cmbNIT.SelectedIndexChanged += new System.EventHandler(this.cmbNIT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "NIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Km recorridos";
            // 
            // nudKm
            // 
            this.nudKm.Location = new System.Drawing.Point(127, 108);
            this.nudKm.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKm.Name = "nudKm";
            this.nudKm.Size = new System.Drawing.Size(114, 22);
            this.nudKm.TabIndex = 25;
            this.nudKm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.nudKm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgDevoluciones);
            this.Controls.Add(this.btnDevolución);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPlaca);
            this.Controls.Add(this.cmbNIT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgDevoluciones;
        private System.Windows.Forms.Button btnDevolución;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.ComboBox cmbNIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudKm;
    }
}