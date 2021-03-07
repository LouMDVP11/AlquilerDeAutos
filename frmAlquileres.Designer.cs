namespace AlquilerDeAutos
{
    partial class frmAlquileres
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNIT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpAlquiler = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.dtgAlquileres = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // cmbNIT
            // 
            this.cmbNIT.FormattingEnabled = true;
            this.cmbNIT.Location = new System.Drawing.Point(76, 61);
            this.cmbNIT.Name = "cmbNIT";
            this.cmbNIT.Size = new System.Drawing.Size(107, 24);
            this.cmbNIT.TabIndex = 1;
            this.cmbNIT.SelectedIndexChanged += new System.EventHandler(this.cmbNIT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(281, 61);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(228, 24);
            this.cmbNombre.TabIndex = 3;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Location = new System.Drawing.Point(98, 100);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(121, 24);
            this.cmbPlaca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Alquiler";
            // 
            // dtpAlquiler
            // 
            this.dtpAlquiler.Enabled = false;
            this.dtpAlquiler.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlquiler.Location = new System.Drawing.Point(381, 100);
            this.dtpAlquiler.Name = "dtpAlquiler";
            this.dtpAlquiler.Size = new System.Drawing.Size(128, 22);
            this.dtpAlquiler.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alquiler de un Vehículo";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(414, 137);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(95, 29);
            this.btnAlquilar.TabIndex = 9;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // dtgAlquileres
            // 
            this.dtgAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlquileres.Location = new System.Drawing.Point(27, 204);
            this.dtgAlquileres.Name = "dtgAlquileres";
            this.dtgAlquileres.RowHeadersWidth = 51;
            this.dtgAlquileres.RowTemplate.Height = 24;
            this.dtgAlquileres.Size = new System.Drawing.Size(497, 199);
            this.dtgAlquileres.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alquileres activos";
            // 
            // frmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgAlquileres);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpAlquiler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPlaca);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNIT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAlquileres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlquileres";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpAlquiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.DataGridView dtgAlquileres;
        private System.Windows.Forms.Label label6;
    }
}