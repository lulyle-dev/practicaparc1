using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity
{
    public class TipoSala
    {
        private int idTipoSala;
        private string descripcion;

        public int IdTipoSala
        {
            get => idTipoSala; set => idTipoSala = value;
        }

        public string Descripcion
            {
            get => descripcion; set => descripcion = value;
        }

        public override string ToString() => Descripcion;
    }
}
