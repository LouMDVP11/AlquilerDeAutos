using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos
{
    public class clsVehiculo
    {
        string placa, marca, modelo, color;
        double precioPorKm;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioPorKm { get => precioPorKm; set => precioPorKm = value; }
    }
}
