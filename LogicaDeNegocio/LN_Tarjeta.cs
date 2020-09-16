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
    public class LN_Tarjeta
    {
        private D_Tarjeta objetoD_Tarjeta = new D_Tarjeta();

        public DataTable MostrarTarjetass()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD_Tarjeta.Mostrar();
            return tabla;
        }
        public void InsetarTarjetass(E_Tarjeta tarjeta)
        {
            objetoD_Tarjeta.Insertar(tarjeta);
        }

        public void EditarTarjetass(E_Tarjeta tarjeta)
        {
            objetoD_Tarjeta.Editar(tarjeta);
        }

        public void EliminarTarjetass(string numeroTarjetass)
        {
            objetoD_Tarjeta.Eliminar(Convert.ToInt32(numeroTarjetass));
        }

        public void CargarSaldoTarjetass(E_Tarjeta tarjeta)
        {
            objetoD_Tarjeta.CargarSaldo_PagarPasaje(tarjeta);
        }
        public void PagarPasajeTarjetass(E_Tarjeta tarjeta)
        {
            objetoD_Tarjeta.CargarSaldo_PagarPasaje(tarjeta);
        }

        public bool ExisteNroTarjeta(int NumeroTarjeta) 
        {
            bool existe = false;
            existe = objetoD_Tarjeta.ExisteNroTarjeta(NumeroTarjeta);
            return existe;
        }

        public bool ExisteNroDocumento(int numeroDocumento)
        {
            bool existe = false;
            existe = objetoD_Tarjeta.ExisteNroDocumento(numeroDocumento);
            return existe;
        }
    }    
}
