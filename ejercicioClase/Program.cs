using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Para cada uno de los atributos usted definirá el tipo de dato de acuerdo
            a lo que se solicita mostrar la información.
            Deberá mostrar 3 superhéroes con todos los atributos, 
            para cada superhéroe deberá crear un objeto ingresando los datos
            */

            SuperHeroe spiderman = new SuperHeroe();
            SuperHeroe batman = new SuperHeroe();
            SuperHeroe ironMan = new SuperHeroe();

            spiderman.Nombre = "Spiderman";
            spiderman.IdentidadSecreta = "Peter Parker";
            spiderman.Ciudad = "New York";
            spiderman.PuedeVolar = false;
            spiderman.Poder.Nombre = "Super fuerza";
            spiderman.Poder.Descripcion = "Puede levantar objetos muy pesados";
            spiderman.Poder.Nivel = 9;
            spiderman.Imprimir();

            Console.WriteLine();
           
            batman.Nombre = "Batman";
            batman.IdentidadSecreta = "Bruce Wayne";
            batman.Ciudad = "Gotham City";
            batman.PuedeVolar = false;
            batman.Poder.Nombre = "Super Fuerza";
            batman.Poder.Descripcion = "Puede levantar objetos muy pesados";
            batman.Poder.Nivel = 8;
            batman.Imprimir();

            Console.WriteLine();
     
            ironMan.Nombre = "IronMan";
            ironMan.IdentidadSecreta = "Tony Star";
            ironMan.Ciudad = "New York";
            ironMan.PuedeVolar = true;
            ironMan.Poder.Nombre = "Super Fuerza";
            ironMan.Poder.Descripcion = "Puede levantar objetos muy pesados";
            ironMan.Poder.Nivel = 10;
            ironMan.Imprimir();

            Console.ReadLine();

            

        }
    }
}
