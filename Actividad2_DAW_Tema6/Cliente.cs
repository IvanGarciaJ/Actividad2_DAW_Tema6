using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Actividad2_Tema2_Servidor
{
    internal class Cliente
    {
        public string nombre { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int saldoBancario { get; set; }

        public Cliente()
        {
        }
        public Cliente(string nombre, int telefono, string direccion, int saldoBancario)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.saldoBancario = saldoBancario;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nTeléfono: " + telefono + "\nDirección: " + direccion + "\nSaldo Bancario: " + saldoBancario + "\n \n";
        }


    }
}
