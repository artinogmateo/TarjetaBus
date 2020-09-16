using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;


namespace LogicaDeNegocio
{
    public class LN_Persona
    {
        private D_Persona objetoD_Persona = new D_Persona();

        public DataTable MostrarPersonass()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD_Persona.Mostrar();
            return tabla;
        }

        public DataTable ExistenTarjetass()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD_Persona.ExisteTarjeta();
            return tabla;
        }

        public void InsetarPersonass(E_Persona persona)
        {
            objetoD_Persona.Insertar(persona);     
        }

        public void EditarPersonass(E_Persona persona)
        {
            objetoD_Persona.Editar(persona);
        }
        
        public void EliminarPersonass(int ndocumento)
        {
            objetoD_Persona.Eliminar(Convert.ToInt32(ndocumento));
        }

        public bool ExisteNroDocumento(int numeroDocumento)
        {
            bool existe = false;
            existe = objetoD_Persona.ExisteNroDocumento(numeroDocumento);
            return existe;
        }

        public bool ExisteTarjetaAsociada(int numeroDocumento)
        {
            bool existe = false;
            existe = objetoD_Persona.ExisteTarjetaAsociada(numeroDocumento);
            return existe;
        }
    }
}
