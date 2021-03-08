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
        //creación de listas que tendrán los datos del programa
        List<clsAlquiler> lstAlquileres = new List<clsAlquiler>();
        List<clsCliente> lstClientes = new List<clsCliente>();
        List<clsVehiculo> lstVehiculos = new List<clsVehiculo>();
        List<clsVehiculo> lstVehiculosDisponibles = new List<clsVehiculo>();
        List<clsIntermedia> lstIntermedia = new List<clsIntermedia>();

        public Form1()
        {
            InitializeComponent();
        }

        private void clienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al frmCliente para agregar uno nuevo
            // se actualizan los datos del frm principal, se hace una instancia
            // del formulario, se asigna lstClientes a la lstClientes de ese form
            // y se llama en forma showDialog para que el usuario no haga nada con 
            // los otros formularios ni las funciones de estos.
            actualizar();
            frmClientes cliente = new frmClientes();
            cliente.lstClientes = this.lstClientes;
            cliente.Actualizar();
            cliente.ShowDialog();
        }
        private void LoadData() {
            //Función que carga los datos de los archivos de texto a las listas del programa
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
            foreach (var al in lstAlquileres) {
                string nombreTemp = "";
                foreach (var c in lstClientes) {
                    if (al.Nit.Equals(c.Nit)) {
                        nombreTemp = c.Nombre;
                        break;
                    }
                }
                clsIntermedia interTemp = new clsIntermedia();
                interTemp.Placa = al.Placa;
                interTemp.Nombre = nombreTemp;
                interTemp.FechaDevolucion = al.FechaDevolucion;
                interTemp.KmRecorridos = al.KmRecorridos;
                interTemp.Total_A_Pagar = al.Total_A_Pagar;
                lstIntermedia.Add(interTemp);
            }
        }
        public void actualizar()
        {
            //función en la que se llena la lista de los vehículos disponibles
            //actualmente para mostrarlos y también muestra en dtgVehículosAlquier
            //todos los autos que han sido alquilados, estando sus alquileres activos
            //o inactivos.
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
            this.dtgVehiculosAlquiler.DataSource = this.lstIntermedia;
            this.dtgVehiculosAlquiler.Refresh();
            cmbPlaca.Items.Clear();
            //Llenado del cmbPlaca con todas las placas registradas en la lista
            //de alquileres, estén estos activos o devueltos.
            for (int x = 0; x < lstAlquileres.Count; x++)
            {
                Boolean founded = false;
                for (int y = 0; y < x; y++)
                    if (lstAlquileres[x].Placa.Equals(lstAlquileres[y].Placa))
                        founded = true;
                if (founded == false) cmbPlaca.Items.Add(lstAlquileres[x].Placa);
            }
            //Mostrar en un label el alquiler con mayor kilometraje
            int mayorKm = -1;
            foreach (var inter in lstIntermedia) {
                if (inter.KmRecorridos > mayorKm) {
                    mayorKm = inter.KmRecorridos;
                    lblMayorKm.Text = "El mayor kilometraje registrado en un alquiler es de: " + mayorKm + "\nEl cliente fue: " + inter.Nombre + "\nEl auto fue el de la placa: " +inter.Placa;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //cargar datos en el formulario principal
            LoadData();
            actualizar();
        }

        private void rbNit_CheckedChanged(object sender, EventArgs e){}
        private void rbNombre_CheckedChanged(object sender, EventArgs e){}


        private void AlquilerFiltrado(List<clsIntermedia> lstAlquileresTemp)
        {
            //Función que muestra los autos dependiendo de lo
            //que fue seleccionado en el combobox, es decir
            //en base a la placa y al nit del cliente
            int nitTemp = 0; string nombreTemp = "";
            foreach (var c in lstClientes)
            {
                if (c.Nit.Equals(Convert.ToInt32(cmbNIT.SelectedItem)))
                {
                    nitTemp = c.Nit;
                    nombreTemp = c.Nombre;
                    break;
                }
            }
            foreach (var a in lstAlquileres)
                if (a.Placa.Equals(cmbPlaca.SelectedItem.ToString()) && a.Nit.Equals(nitTemp)) {
                    clsIntermedia interTemp = new clsIntermedia();
                    interTemp.Placa = a.Placa;
                    interTemp.Nombre = nombreTemp;
                    interTemp.FechaDevolucion = a.FechaDevolucion;
                    interTemp.KmRecorridos = a.KmRecorridos;
                    interTemp.Total_A_Pagar = a.Total_A_Pagar;
                    lstAlquileresTemp.Add(interTemp);
                } 
            dtgVehiculosAlquiler.DataSource = null;
            dtgVehiculosAlquiler.DataSource = lstAlquileresTemp;
            dtgVehiculosAlquiler.Refresh();
        }
        private void rbPlaca_CheckedChanged(object sender, EventArgs e){}

        private void btnReestablecer_Click(object sender, EventArgs e)
        {//función fantasma...no eliminar, se pierde la interfaz gráfica
        }
        
        private void btnReestablecer_Click_1(object sender, EventArgs e)
        {
            //reestablece los valores predeterminados 
            //a los campos relacionados con la busqueda
            //filtrada de alquileres.
            cmbPlaca.SelectedIndex = -1;
            cmbNIT.Items.Clear();
            this.dtgVehiculosAlquiler.DataSource = null;
            this.dtgVehiculosAlquiler.DataSource = lstIntermedia;
            this.dtgVehiculosAlquiler.Refresh();
            btnBuscar.Enabled = false;
            btnReestablecer.Enabled = false;
            cmbPlaca.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //se crea una lista de alquileres temporal 
            //y le llama a la función AlquilerFiltrado
            //para organizar el dtg con los datos filtrados.
            List<clsIntermedia> lstAlquileresTemp = new List<clsIntermedia>();
            AlquilerFiltrado(lstAlquileresTemp);
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Actualiza todos los datos del programa
            LoadData();
            this.actualizar();
        }

        private void cmbPlaca_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void agregarAutomóvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al frmAuto para agregar uno nuevo
            // se actualizan los datos del frm principal, se hace una instancia
            // del formulario, se asignan las listas del frm principal al de este form
            // y se llama en forma showDialog para que el usuario no haga nada con 
            // los otros formularios ni las funciones de estos.
            actualizar();
            frmAutos Auto = new frmAutos();
            Auto.lstVehiculos = this.lstVehiculos;
            Auto.Actualizar();
            Auto.ShowDialog();
        }

        private void agregarAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al frmAlquiler para agregar uno nuevo
            // se actualizan los datos del frm principal, se hace una instancia
            // del formulario, se asignan las listas del frm principal al de este form
            // y se llama en forma showDialog para que el usuario no haga nada con 
            // los otros formularios ni las funciones de estos.
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
            //Al cambiar la placa en el cmb carga todos los nit's relacionados con esta
            List<int> nits = new List<int>();
            if (cmbPlaca.SelectedIndex > -1) { 
                for (int x = 0; x < lstAlquileres.Count; x++)
                    if (lstAlquileres[x].Placa.Equals(cmbPlaca.SelectedItem.ToString())) {
                        if (cmbNIT.Items.Count == 0)
                        {
                            cmbNIT.Items.Add(lstAlquileres[x].Nit);
                            nits.Add(lstAlquileres[x].Nit);
                        }
                        else
                            for (int y = 0; y < nits.Count; y++)
                                if (nits[y] != lstAlquileres[x].Nit)
                                {
                                    cmbNIT.Items.Add(lstAlquileres[x].Nit);
                                    nits.Add(lstAlquileres[x].Nit);
                                }
                    }
                cmbNIT.SelectedIndex = 0;
                btnBuscar.Enabled = true;
                btnReestablecer.Enabled = true;
                cmbPlaca.Enabled = false;
            }
        }

        private void devolverUnAutomóvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al frmDevoluciones para hacer una nueva
            // se actualizan los datos del frm principal, se hace una instancia
            // del formulario, se asignan las listas del frm principal al de este form
            // y se llama en forma showDialog para que el usuario no haga nada con 
            // los otros formularios ni las funciones de estos.
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
