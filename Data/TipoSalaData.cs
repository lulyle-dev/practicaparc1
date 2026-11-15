using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Identity;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Mapper;

namespace Data
{
    public class TipoSalaData
    {
        public List<TipoSala> ObtenerTodosLosTipos()
        {
            List<TipoSala> tiposala = new List<TipoSala>();
            try
            {
                using (SqlConnection sqlconection = new SqlConnection(ConexionString.ObtenerConexion()))
                {
                    sqlconection.Open();
                    string query = "SELECT * FROM TIPO_SALA";
                    using (SqlCommand command = new SqlCommand(query, sqlconection))
                    {
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                TipoSala Tiposala = TipoSalaMapper.MapearCamposTipoSala(read);

                                tiposala.Add(Tiposala);
                            }
                        }
                    }
                }
                return tiposala;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TipoSala ObtenerTipoPorId(int idTipoSala)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionString.ObtenerConexion()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM TIPO_SALA WHERE ID_TIPO_SALA = @idTipoSala";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@idTipoSala", idTipoSala); 
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                return TipoSalaMapper.MapearCamposTipoSala(reader);

                            }
                        }
                    }
                }
                return null;

            }
            catch(Exception ex)
            {
                throw;
            }
        }

    }
}
