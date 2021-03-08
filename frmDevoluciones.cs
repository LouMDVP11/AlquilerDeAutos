using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerDeAutos
{
    public partial class frmDevoluciones : Form
    {
        public List<clsAlquiler> lstAlquileres = new List<clsAlquiler>();
        public List<clsAlquiler> lstAlquileresActivos = new List<clsAlquiler>();
        public List<clsVehiculo> lstVehiculos = new List<clsVehiculo>();
        public frmDevoluciones()
        {
            InitializeComponent();
        }
        public void Actualizar()
        {
            this.dtgDevoluciones.DataSource = null;
            this.dtgDevoluciones.DataSource = this.lstAlquileresActivos;
            this.dtgDevoluciones.Refresh();
            cmbPlaca.DisplayMember = "Placa";
            cmbPlaca.ValueMember = "Placa";
            cmbPlaca.DataSource = null;
            cmbPlaca.DataSource = lstAlquileresActivos;
            cmbPlaca.Refresh();
            cmbNIT.DisplayMember = "Nit";
            cmbNIT.ValueMember = "Nit";
            cmbNIT.DataSource = null;
            cmbNIT.DataSource = lstAlquileresActivos;
            cmbNIT.Refresh();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void btnDevolución_Click(object sender, EventArgs e)
        {
            if (cmbPlaca.SelectedIndex > -1)
            {
                double precio = 0;
                for (int x = 0; x < lstVehiculos.Count; x++)
                    if (lstVehiculos[x].Placa.Equals(cmbPlaca.SelectedValue.ToString()))
                        precio = lstVehiculos[x].PrecioPorKm;
                FileStream stream = new FileStream("Alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                foreach (var al in lstAlquileres)
                {
                    clsAlquiler alquilerTemp = new clsAlquiler();
                    if (al.Placa.Equals(cmbPlaca.SelectedValue.ToString()) && al.FechaDevolucion.Equals(" "))
                    {
                        alquilerTemp.Nit = al.Nit;
                        alquilerTemp.Placa = al.Placa;
                        alquilerTemp.FechaAlquiler = al.FechaAlquiler;
                        alquilerTemp.FechaDevolucion = dtpDevolucion.Value.ToString();
                        alquilerTemp.KmRecorridos = Convert.ToInt32(nudKm.Value);
                        alquilerTemp.Total_A_Pagar = alquilerTemp.KmRecorridos * precio;
                    }
                    else {
                        alquilerTemp.Nit = al.Nit;
                        alquilerTemp.Placa = al.Placa;
                        alquilerTemp.FechaAlquiler = al.FechaAlquiler;
                        alquilerTemp.FechaDevolucion =al.FechaDevolucion;
                        alquilerTemp.KmRecorridos = al.KmRecorridos;
                        alquilerTemp.Total_A_Pagar = al.Total_A_Pagar;
                    }
                    writer.WriteLine(alquilerTemp.Nit);
                    writer.WriteLine(alquilerTemp.Placa);
                    writer.WriteLine(alquilerTemp.FechaAlquiler);
                    writer.WriteLine(alquilerTemp.FechaDevolucion);
                    writer.WriteLine(alquilerTemp.KmRecorridos);
                    writer.WriteLine(alquilerTemp.Total_A_Pagar);
                }
                    writer.Close();
                MessageBox.Show("Devolucion realizada exitosamente.\n Presione actualizar en el formulario general para visualizar los cambios.");
                this.Close();
            }
            else MessageBox.Show("Debe seleccionar datos de todos los campos.");
        }
        Boolean Inicio = false;
        private void cmbNIT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNIT.Items.Count > 0 && Inicio == true)
            {
                cmbPlaca.SelectedIndex = cmbNIT.SelectedIndex;
            }
            Inicio = true;
        }

        private void cmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlaca.Items.Count > 0)
                cmbNIT.SelectedIndex = cmbNIT.SelectedIndex;
        }
    }
}
