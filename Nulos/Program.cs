using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro miCarro = new Carro();
            miCarro.Marca = "Tsuru";
            miCarro.kilometraje = "1000";
            Console.WriteLine("Marca: " + miCarro.Marca);
            Console.WriteLine("Kilometraje: " + miCarro.kilometraje);
            if(miCarro.DueñoCarro!=null)
            {
                Console.WriteLine("Dueño: " + miCarro.DueñoCarro.Nombre);
            }
            else
            {
                Console.WriteLine("No se encontró dueño");
            }
            Console.ReadLine();
        }
 
    }
}
