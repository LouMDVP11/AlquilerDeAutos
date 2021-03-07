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
    public partial class Form1 : Form
    {
        List<clsAlquiler> lstAlquileres = new List<clsAlquiler>();
        List<clsCliente> lstClientes = new List<clsCliente>();
        List<clsVehiculo> lstVehiculos = new List<clsVehiculo>();
        List<clsVehiculo> lstVehiculosDisponibles = new List<clsVehiculo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void clienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes cliente = new frmClientes();
            cliente.lstClientes = this.lstClientes;
            cliente.Actualizar();
            cliente.ShowDialog();
        }
        private void LoadData() {
            FileStream stream = new FileStream("Clientes.txt", FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream("Vehiculos.txt", FileMode.Open, FileAccess.Read);
            FileStream stream3 = new FileStream("Alquileres.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            StreamReader reader2 = new StreamReader(stream2);
            StreamReader reader3 = new StreamReader(stream3);
            lstAlquileres.Clear();
            lstClientes.Clear();
            lstVehiculos.Clear();
            while (reader.Peek() > -1)
            {
                clsCliente clienteTemp = new clsCliente();
                clienteTemp.Nit = Convert.ToInt32(reader.ReadLine());
                clienteTemp.Nombre = reader.ReadLine();
                clienteTemp.Direccion = reader.ReadLine();
                lstClientes.Add(clienteTemp);
            }
            reader.Close();
            while (reader2.Peek() > -1)
            {
                clsVehiculo vehiculoTemp = new clsVehiculo();
                vehiculoTemp.Placa = reader2.ReadLine();
                vehiculoTemp.Marca = reader2.ReadLine();
                vehiculoTemp.Modelo = reader2.ReadLine();
                vehiculoTemp.Color = reader2.ReadLine();
                vehiculoTemp.PrecioPorKm = Convert.ToDouble(reader2.ReadLine());
                lstVehiculos.Add(vehiculoTemp);
            }
            reader2.Close();
            while (reader3.Peek() > -1)
            {
                clsAlquiler AlquilerTemp = new clsAlquiler();
                AlquilerTemp.Nit = Convert.ToInt32(reader3.ReadLine());
                AlquilerTemp.Placa = reader3.ReadLine();
                AlquilerTemp.FechaAlquiler = Convert.ToDateTime(reader3.ReadLine());
                AlquilerTemp.FechaDevolucion = Convert.ToDateTime(reader3.ReadLine());
                AlquilerTemp.KmRecorridos = Convert.ToInt32(reader3.ReadLine());
                lstAlquileres.Add(AlquilerTemp);
            }
            reader3.Close();
        }
        public void actualizar()
        {
            foreach (var v in lstVehiculos) {
                Boolean founded = false;
                foreach (var a in lstAlquileres)
                    if (v.Placa.Equals(a.Placa) && a.KmRecorridos==0) founded = true;
                if (founded == false) lstVehiculosDisponibles.Add(v);
            }
            this.dtgVehiculosDisponibles.DataSource = null;
            this.dtgVehiculosDisponibles.DataSource = this.lstVehiculosDisponibles;
            this.dtgVehiculosDisponibles.Refresh();
            this.dtgVehiculosAlquiler.DataSource = null;
            this.dtgVehiculosAlquiler.DataSource = this.lstAlquileres;
            this.dtgVehiculosAlquiler.Refresh();
            cmbPlaca.Items.Clear();
            for (int x = 0; x < lstAlquileres.Count; x++)
            {
                Boolean founded = false;
                for (int y = 0; y < x; y++)
                    if (lstAlquileres[x].Placa.Equals(lstAlquileres[y].Placa))
                        founded = true;
                if (founded == false) cmbPlaca.Items.Add(lstAlquileres[x].Placa);
            }
            cmbPlaca.DisplayMember = "Placa";
            cmbPlaca.ValueMember = "Placa";
            cmbPlaca.DataSource = null;
            cmbPlaca.DataSource = lstAlquileres;
            cmbPlaca.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            actualizar();
        }

        private void rbNit_CheckedChanged(object sender, EventArgs e){}
        private void rbNombre_CheckedChanged(object sender, EventArgs e){}

        
        private void AlquilerFiltrado(List<clsAlquiler> lstAlquileresTemp)
        {
            foreach (var a in lstAlquileres)
                if (a.Placa.Equals(cmbPlaca.SelectedValue)) lstAlquileresTemp.Add(a);
            dtgVehiculosAlquiler.DataSource = null;
            dtgVehiculosAlquiler.DataSource = lstAlquileresTemp;
            dtgVehiculosAlquiler.Refresh();
        }
        private void rbPlaca_CheckedChanged(object sender, EventArgs e){}

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            cmbPlaca.SelectedIndex = -1;
            this.dtgVehiculosAlquiler.DataSource = null;
            this.dtgVehiculosAlquiler.DataSource = lstAlquileres;
            this.dtgVehiculosAlquiler.Refresh();
            btnBuscar.Enabled = false;
            btnReestablecer.Enabled = false;
        }

        private void btnReestablecer_Click_1(object sender, EventArgs e)
        {
            cmbPlaca.SelectedIndex = -1;
            this.dtgVehiculosAlquiler.DataSource = null;
            this.dtgVehiculosAlquiler.DataSource = lstVehiculos;
            this.dtgVehiculosAlquiler.Refresh();
            btnBuscar.Enabled = false;
            btnReestablecer.Enabled = false;
            txtTotal.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<clsAlquiler> lstAlquileresTemp = new List<clsAlquiler>();
            AlquilerFiltrado(lstAlquileresTemp);
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
            this.actualizar();
        }

        private void cmbPlaca_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < lstAlquileres.Count; x++)
                for (int y = 0; y < x; y++)
                    if (lstAlquileres[x].Placa.Equals(lstAlquileres[y].Placa))
                        if (!lstAlquileres[x].Nit.Equals(lstAlquileres[y].Nit))
                            cmbNIT.Items.Add(lstAlquileres[x].Nit);
            btnBuscar.Enabled = true;
            btnReestablecer.Enabled = true;
        }

        private void agregarAutomóvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutos Auto = new frmAutos();
            Auto.lstVehiculos = this.lstVehiculos;
            Auto.Actualizar();
            Auto.ShowDialog();
        }
    }
}
