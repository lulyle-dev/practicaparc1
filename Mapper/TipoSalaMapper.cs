using Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TipoSalaMapper
    {
        public static TipoSala MapearCamposTipoSala(SqlDataReader sqlreader)

        {
            TipoSala tiposala = new TipoSala();
            tiposala.IdTipoSala = Convert.ToInt32(sqlreader["ID_TIPO_SALA"]);
            tiposala.Descripcion = Convert.ToString(sqlreader["DESCRIPCION"]);
            return tiposala;
        }
    }
}
