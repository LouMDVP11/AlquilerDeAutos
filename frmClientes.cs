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
    public partial class frmClientes : Form
    {
        public List<clsCliente> lstClientes = new List<clsCliente>();
        public frmClientes()
        {
            InitializeComponent();
        }
        public void Actualizar()
        {
            this.dtgClientes.DataSource = null;
            this.dtgClientes.DataSource = this.lstClientes;
            this.dtgClientes.Refresh();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            { //permitir teclas de control como retroceso
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
        //Funciones vacías
        private void frmClientes_Load(object sender, EventArgs e){}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0 && txtNIT.Text.Trim().Length > 0 && txtDireccion.Text.Trim().Length > 0)
            {
                Boolean repetido = false;
                for (int x = 0; x < lstClientes.Count; x++)
                    if (lstClientes[x].Nit.Equals(Convert.ToInt32(txtNIT.Text)))
                    {
                        repetido = true; break;
                    }
                if (repetido == false)
                {
                    FileStream stream = new FileStream("Clientes.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    clsCliente nuevoEmpleado = new clsCliente();
                    nuevoEmpleado.Nit = Convert.ToInt32(txtNIT.Text);
                    nuevoEmpleado.Nombre = txtNombre.Text;
                    nuevoEmpleado.Direccion = txtDireccion.Text;
                    writer.WriteLine(nuevoEmpleado.Nit);
                    writer.WriteLine(nuevoEmpleado.Nombre);
                    writer.WriteLine(nuevoEmpleado.Direccion);
                    writer.Close();
                    this.lstClientes.Add(nuevoEmpleado);
                    MessageBox.Show("Cliente agregado exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El NIT de cliente ya ha sido registrado anteriormente.");
                    txtNIT.Clear();
                    txtNIT.Focus();
                }
            }
            else MessageBox.Show("Debe llenar todos los datos.");
        }
    }
}
