using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Identity;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public class ReservaMapper
    {
        public static Reserva MapearCamposReserva(SqlDataReader sqlreader, TipoSala tiposala)

        {
            Reserva reserva = new Reserva();
            reserva.Dni = Convert.ToString(sqlreader["DNI"]);
            reserva.NumeroReserva = Convert.ToInt32(sqlreader["NUMERO_RESERVA"]);

            reserva.TipoSala = tiposala;

            reserva.Importe = Convert.ToInt32(sqlreader["IMPORTE"]);
            reserva.FechaRegistro = Convert.ToDateTime(sqlreader["FECHA_REGISTRO"]);
            reserva.FechaReserva = Convert.ToDateTime(sqlreader["FECHA_RESERVA"]);

            return reserva;
        }
    }
}
