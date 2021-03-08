using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos
{
    class clsIntermedia
    {
        int kmRecorridos;
        string nombre;
        string placa;
        string fechaDevolucion;
        Double total_A_Pagar;
        
        public string Placa { get => placa; set => placa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public int KmRecorridos { get => kmRecorridos; set => kmRecorridos = value; }
        public double Total_A_Pagar { get => total_A_Pagar; set => total_A_Pagar = value; }
    }
}
