using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos
{
    class clsAlquiler
    {
        int nit, kmRecorridos;
        string placa;
        DateTime fechaAlquiler, fechaDevolucion;

        public int Nit { get => nit; set => nit = value; }
        public int KmRecorridos { get => kmRecorridos; set => kmRecorridos = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
    }
}
