using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity
{
    public class Reserva
    {
        private int numeroReserva;
        private string dni;
        private int importe;

        private DateTime fechaRegistro;
        private DateTime fechaReserva;


        private TipoSala tipoSala;


        public int NumeroReserva
        {
            get => numeroReserva; set => numeroReserva = value;
        }

        public string Dni
        {
            get => dni; set => dni = value;
        }

        public int Importe
        {
            get => importe; set => importe = value;
        }


        public DateTime FechaRegistro
        {
            get => fechaRegistro; set => fechaRegistro = value;
        }

        public DateTime FechaReserva
        {
            get => fechaReserva; set => fechaReserva = value;
        }

        public TipoSala TipoSala
        {
            get => tipoSala; set => tipoSala = value;
        }
    }
}
