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
        Double total_A_Pagar;
        public int Nit { get => nit; set => nit = value; }
        public int KmRecorridos { get => kmRecorridos; set => kmRecorridos = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public double Total_A_Pagar { get => total_A_Pagar; set => total_A_Pagar = value; }
    }
}
