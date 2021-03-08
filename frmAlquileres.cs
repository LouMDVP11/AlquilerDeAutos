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
    public partial class frmAlquileres : Form
    {
        public List<clsCliente> lstClientes = new List<clsCliente>();
        public List<clsAlquiler> lstAlquileres = new List<clsAlquiler>();
        public List<clsVehiculo> lstVehiculos = new List<clsVehiculo>();
        public List<clsVehiculo> lstVehiculosDisponibles = new List<clsVehiculo>();
        public frmAlquileres()
        {
            InitializeComponent();
        }
        public void Actualizar()
        {
            this.dtgAlquileres.DataSource = null;
            this.dtgAlquileres.DataSource = this.lstAlquileres;
            this.dtgAlquileres.Refresh();
            cmbPlaca.DisplayMember = "Placa";
            cmbPlaca.ValueMember = "Placa";
            cmbPlaca.DataSource = null;
            cmbPlaca.DataSource = lstVehiculosDisponibles;
            cmbPlaca.Refresh();
            cmbNIT.DisplayMember = "Nit";
            cmbNIT.ValueMember = "Nit";
            cmbNIT.DataSource = null;
            cmbNIT.DataSource = lstClientes;
            cmbNIT.Refresh();
            cmbNombre.DisplayMember = "Nombre";
            cmbNombre.ValueMember = "Nombre";
            cmbNombre.DataSource = null;
            cmbNombre.DataSource = lstClientes;
            cmbNombre.Refresh();
        }
        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            clsAlquiler nuevoAlquiler = new clsAlquiler();
            nuevoAlquiler.Nit = Convert.ToInt32(cmbNIT.SelectedValue);
            nuevoAlquiler.Placa = cmbPlaca.SelectedValue.ToString();
            nuevoAlquiler.FechaAlquiler = dtpAlquiler.Value.ToString();
            nuevoAlquiler.FechaDevolucion = " ";
            nuevoAlquiler.KmRecorridos = 0;
            nuevoAlquiler.Total_A_Pagar = 0;
            writer.WriteLine(nuevoAlquiler.Nit);
            writer.WriteLine(nuevoAlquiler.Placa);
            writer.WriteLine(nuevoAlquiler.FechaAlquiler);
            writer.WriteLine(nuevoAlquiler.FechaDevolucion);
            writer.WriteLine(nuevoAlquiler.KmRecorridos);
            writer.WriteLine(nuevoAlquiler.Total_A_Pagar);
            writer.Close();
            this.lstAlquileres.Add(nuevoAlquiler);
            MessageBox.Show("Alquiler agregado exitosamente.\n Presione actualizar en el formulario general para visualizar los cambios.");
            this.Close();
        }
        Boolean Inicio = false;
        private void cmbNIT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNIT.Items.Count > 0 && Inicio == true) { 
                cmbNombre.SelectedIndex = cmbNIT.SelectedIndex;
            } 
            Inicio = true;
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombre.Items.Count > 0)
                cmbNIT.SelectedIndex = cmbNombre.SelectedIndex;
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {

        }
    }
}
