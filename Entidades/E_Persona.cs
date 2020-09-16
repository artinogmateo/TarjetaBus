using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class E_Persona
    {
        public string nombresPersona { get; set; }
        public string apellidosPersona { get; set; }
        public string tipoDocumento { get; set; }
        public int documentoNumero { get; set; }
        public long CUIL { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edadPersona { get; set; }
    }
}
