using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones2022
{
    public class Persona
    {
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public int Edad { set; get; }
     


        public Persona()
        {
        }

        public Persona(string nombres, string apellidos, int edad)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
        }


    }
}
