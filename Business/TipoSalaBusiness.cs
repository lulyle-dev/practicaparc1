using Data;
using Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TipoSalaBusiness
    {
        TipoSalaData tiposaladata = new TipoSalaData();
        public List<TipoSala> ObtenerTipoSala()
        {
            try
            {
                return tiposaladata.ObtenerTodosLosTipos();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
