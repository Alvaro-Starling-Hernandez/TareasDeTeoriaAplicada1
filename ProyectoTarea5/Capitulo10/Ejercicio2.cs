using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea5.Capitulo10
{
    public class Ejercicio2
    {
        private int Id { get; set; }
        private string PrimerNombre { get; set; }
        private string SegundoNombre { get; set; }
        private string PrimerApellido { get; set; }
        private string SegundoApellido { get; set; }
        private byte Edad { get; set; }
        private string Grado { get; set; }
        private string Aula { get; set; }
        private string Seccion { get; set; }

        public Ejercicio2()
        {
            Id = 1;
            PrimerNombre = "Alvaro";
            SegundoNombre = "Starling";
            PrimerApellido = "Hernandez";
            SegundoApellido = "Luzon";
            Edad = 20;
            Grado = "Octavo Cuatrimestre";
            Aula = "Virtual";
            Seccion = "Seccion Unica";
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Id: " + Id.ToString() + "\nNombres y Apellidos: " + PrimerNombre.ToString() + " " + SegundoNombre.ToString() + " ";
            mensaje += PrimerApellido.ToString() + " " + SegundoApellido.ToString();
            mensaje += "\nEdad: " + Edad.ToString() + "\nGrado: " + Grado.ToString() + "\nAlula: " + Aula.ToString() + "\nSeccion: " + Seccion.ToString(); 
            return mensaje;
        }
    }
}
