namespace Actividad2_DAW_Tema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            List<Cliente> clientes = new List<Cliente>();



      
            clientes.Add(new Cliente() { nombre = "Iván", telefono = 651589920, direccion = "Aviles", saldoBancario=5416 });
            clientes.Add(new Cliente() { nombre = "Teja", telefono = 675219920, direccion = "Sevilla", saldoBancario = 5451 });
            clientes.Add(new Cliente() { nombre = "Andrés", telefono = 1321353, direccion = "Teruel", saldoBancario = 7654 });
            clientes.Add(new Cliente() { nombre = "Dani", telefono = 45645645, direccion = "Tokyo", saldoBancario = -3143 });
            clientes.Add(new Cliente() { nombre = "Joel", telefono = 13232150, direccion = "Seoul", saldoBancario = -4524 });



        
            clientes.Sort((x, y) => y.saldoBancario.CompareTo(x.saldoBancario));



        
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
            }




           foreach (Cliente cliente in clientes) if (cliente.saldoBancario < 0)
                {
                    Console.WriteLine(cliente.nombre+" es un moroso");
                }



           var moroso =
                from cliente in clientes
                where (cliente.saldoBancario < 0)
                select cliente;




           foreach (Cliente cliente in moroso)
                {
                Console.WriteLine(cliente.nombre + " también es un moroso utilizando LinQ");
            }
        }
    }
}
