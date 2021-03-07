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
    public partial class frmAutos : Form
    {
        public List<clsVehiculo> lstVehiculos = new List<clsVehiculo>();
        public frmAutos()
        {
            InitializeComponent();
        }
        public void Actualizar()
        {
            this.dtgVehiculos.DataSource = null;
            this.dtgVehiculos.DataSource = this.lstVehiculos;
            this.dtgVehiculos.Refresh();
        }
        private void frmAutos_Load(object sender, EventArgs e){}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtColor.Text.Trim().Length > 0 && txtMarca.Text.Trim().Length > 0 
                && txtModelo.Text.Trim().Length > 0 && txtPlaca.Text.Trim().Length > 0 && txtPrecio.Text.Trim().Length > 0)
            {
                Boolean repetido = false;
                for (int x = 0; x < lstVehiculos.Count; x++)
                    if (lstVehiculos[x].Placa.Equals(txtPlaca.Text))
                    {
                        repetido = true; break;
                    }
                if (repetido == false)
                {
                    FileStream stream = new FileStream("Vehiculos.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    clsVehiculo nuevoVehiculo = new clsVehiculo();
                    nuevoVehiculo.Placa = txtPlaca.Text;
                    nuevoVehiculo.Marca = txtMarca.Text;
                    nuevoVehiculo.Modelo = txtModelo.Text;
                    nuevoVehiculo.Color = txtColor.Text;
                    nuevoVehiculo.PrecioPorKm = Convert.ToDouble(txtPrecio.Text);
                    writer.WriteLine(nuevoVehiculo.Placa);
                    writer.WriteLine(nuevoVehiculo.Marca);
                    writer.WriteLine(nuevoVehiculo.Modelo);
                    writer.WriteLine(nuevoVehiculo.Color);
                    writer.WriteLine(nuevoVehiculo.PrecioPorKm);
                    writer.Close();
                    this.lstVehiculos.Add(nuevoVehiculo);
                    MessageBox.Show("Vehiculo agregado exitosamente.");
                    txtPlaca.Clear();
                    txtModelo.Clear();
                    txtMarca.Clear();
                    txtColor.Clear();
                    txtPrecio.Clear();
                    txtPlaca.Focus();
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("La placa de vehículo ya ha sido registrada anteriormente.");
                    txtPlaca.Clear();
                    txtPlaca.Focus();
                }
            }
            else MessageBox.Show("Debe llenar todos los datos.");
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            int contPuntos = 0;
            string cadena = txtPrecio.Text;
            char letra;
            for (int x = 0; x < cadena.Length; x++)
            {
                letra = cadena[x];
                if (letra.Equals('.')) contPuntos++;
            }

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                //permitir teclas de control como retroceso
                e.Handled = false;
            else if (contPuntos == 0 && e.KeyChar == '.')
                //permitir un punto si no han ingresado uno anteriormente
                e.Handled = false;
            else
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
        }
    }
}
