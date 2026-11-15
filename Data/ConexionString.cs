using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Data
{
    public class ConexionString
    {
        public static string ObtenerConexion()
        {
            return ConfigurationManager.ConnectionStrings["practicabbdd1"].ConnectionString;

        }
    }
}
