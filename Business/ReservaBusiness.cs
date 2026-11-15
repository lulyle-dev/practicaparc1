using Data;
using Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ReservaBusiness
    {
        ReservaData reservadata = new ReservaData();
        public List<Reserva> ObtenerReservas()
        {
            return reservadata.ObtenerTodasReservas();

        }

        public void AgregarReserva(Reserva reserva)
        {

            try
            {
                ValidarDni(reserva);
                ValidarFecha(reserva.FechaReserva);
                ValidarMonto(reserva.Importe);
                reservadata.AgregarReserva(reserva);

            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void modificarReserva(int idreserva, int nuevomonto, DateTime nuevafecha)
        {
            try
            {
                ValidarExistenciaID(idreserva);
                ValidarIDReserva(idreserva);
                ValidarFecha(nuevafecha);
                ValidarMonto(nuevomonto);
                reservadata.modificarReserva(idreserva, nuevomonto, nuevafecha);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void EliminarReserva(int idreserva)
        {
            try
            {
                ValidarExistenciaID(idreserva);
                ValidarIDReserva(idreserva);
                reservadata.EliminarReserva(idreserva);

            }
            catch(Exception ex)
            {
                throw;
            }
        }
         

        public void ValidarDni(Reserva reserva)
        {
            string dni = (reserva.Dni ?? string.Empty).Trim();
            if(string.IsNullOrEmpty(dni) || dni.Length<=5)
            {
                throw new Exception("el dni ingresado es invalido");
            }
        }
        public void ValidarFecha(DateTime fecha)
        {
            if(fecha.CompareTo(DateTime.Today)<0)
            {
                throw new Exception("la fecha no puede ser anterior al dia de hoy");
            }

        }

        public void ValidarMonto(int monto)
        {
            if(monto <=0)
            {
                throw new Exception("el monto no puede ser menor a 0$");
            }
        }
        public void ValidarExistenciaID(int idreserva)
        {
            Reserva reserva = reservadata.ObtenerReservaPorID(idreserva);
            if(reserva==null)
            {
                throw new Exception("el id ingresado no es valido");
            }
        }

        public void ValidarIDReserva(int idreserva)
        {
            if(idreserva<=0)
            {
                throw new Exception("el id no puede ser menor a 0");
            }
        }
    }

}
