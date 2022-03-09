using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones2022
{
    public class Personas
    {
        public List<Persona> ListPersonas { set; get; }
        public Personas()
        {
            ListPersonas = new List<Persona>();
        }
        public void AgregarPersona(Persona persona)
        {
            ListPersonas.Add(persona);
        }
        public List<Persona> PersonasEdadPar()
        {
            List<Persona> aux = new List<Persona>();
            foreach(Persona persona in ListPersonas)
            {
                if (persona.Edad%2==0)
                {
                    aux.Add(persona);
                }
            }
            return aux;
        }

    }

}
