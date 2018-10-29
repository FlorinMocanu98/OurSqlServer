using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurSqlServer.Data
{
    abstract class Persona
    {
        private string Nome;
        private string Cognome;
        private string NTelefono;

        protected Persona(string n, string c, string nT)
        {
            Nome = n;
            Cognome = c;
            NTelefono = nT;
        }
        protected Persona()
        {
            Nome = "";
            Cognome = "";
            NTelefono = "0000000000";
        }
    }
}
