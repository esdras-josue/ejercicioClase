using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase
{
    public class SuperHeroe
    {
       
        public string Nombre {  get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder Poder { get; set; }

        public SuperHeroe()
        {
            Poder = new SuperPoder();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede vodar:{(PuedeVolar ? " Si": "No")}");
            Console.WriteLine($"Super poder: {Poder.Nombre}");
            Console.WriteLine($"Descripcion: {Poder.Descripcion}");
            Console.WriteLine($"Nivel: {Poder.Nivel}"); 
        }
    }
}
