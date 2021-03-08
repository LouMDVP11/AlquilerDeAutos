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
            actualizar();
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
                AlquilerTemp.FechaAlquiler = reader3.ReadLine();
                AlquilerTemp.FechaDevolucion = reader3.ReadLine();
                AlquilerTemp.KmRecorridos = Convert.ToInt32(reader3.ReadLine());
                AlquilerTemp.Total_A_Pagar = Convert.ToInt32(reader3.ReadLine());
                lstAlquileres.Add(AlquilerTemp);
            }
            reader3.Close();
        }
        public void actualizar()
        {
            lstVehiculosDisponibles.Clear();
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
                if (a.Placa.Equals(cmbPlaca.SelectedItem.ToString()) && a.Nit.Equals(Convert.ToInt32(cmbNIT.SelectedItem))) lstAlquileresTemp.Add(a);
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
            cmbNIT.Items.Clear();
            this.dtgVehiculosAlquiler.DataSource = null;
            this.dtgVehiculosAlquiler.DataSource = lstAlquileres;
            this.dtgVehiculosAlquiler.Refresh();
            btnBuscar.Enabled = false;
            btnReestablecer.Enabled = false;
            txtTotal.Clear();
            cmbPlaca.Enabled = true;
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
        }

        private void agregarAutomóvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizar();
            frmAutos Auto = new frmAutos();
            Auto.lstVehiculos = this.lstVehiculos;
            Auto.Actualizar();
            Auto.ShowDialog();
        }

        private void agregarAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizar();
            frmAlquileres alquiler = new frmAlquileres();
            alquiler.lstClientes = this.lstClientes;
            alquiler.lstAlquileres = this.lstAlquileres;
            alquiler.lstVehiculos = this.lstVehiculos;
            alquiler.lstVehiculosDisponibles = this.lstVehiculosDisponibles;
            alquiler.Actualizar();
            alquiler.ShowDialog();
        }
        
        private void cmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlaca.SelectedIndex > -1) { 
                for (int x = 0; x < lstAlquileres.Count; x++)
                    if (lstAlquileres[x].Placa.Equals(cmbPlaca.SelectedItem.ToString())) { 
                        for(int y = 0; y< lstAlquileres.Count; y++)
                            if(lstAlquileres[y].Nit != lstAlquileres[x].Nit && x==y)
                                cmbNIT.Items.Add(lstAlquileres[x].Nit);
                        if (cmbNIT.Items.Count==0 || x==0) cmbNIT.Items.Add(lstAlquileres[x].Nit);
                    }
                cmbNIT.SelectedIndex = 0;
                btnBuscar.Enabled = true;
                btnReestablecer.Enabled = true;
                cmbPlaca.Enabled = false;
            }
        }

        private void devolverUnAutomóvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizar();
            List<clsAlquiler> lstAlquileresFiltrada = new List<clsAlquiler>();
            foreach (var al in lstAlquileres) {
                if (al.FechaDevolucion == " ") lstAlquileresFiltrada.Add(al);
            }
            frmDevoluciones devolucion = new frmDevoluciones();
            devolucion.lstAlquileresActivos = lstAlquileresFiltrada;
            devolucion.lstAlquileres = this.lstAlquileres;
            devolucion.lstVehiculos = this.lstVehiculos;
            devolucion.Actualizar();
            devolucion.ShowDialog();
        }
    }
}
