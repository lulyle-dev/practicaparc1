using Identity;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ReservaData
    {
        new TipoSalaData tiposalaData = new TipoSalaData();
        public void AgregarReserva(Reserva reserva)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionString.ObtenerConexion()))
                {
                    conexion.Open();
                    string sql = "INSERT INTO RESERVA (TIPO_SALA, DNI, IMPORTE, FECHA_REGISTRO, FECHA_RESERVA) VALUES (@tipo_sala ,@dni, @importe, @fechaRegistro, @fechaReserva)";
                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@dni", reserva.Dni);
                        command.Parameters.AddWithValue("@importe", reserva.Importe);
                        command.Parameters.AddWithValue("@tipo_sala", reserva.TipoSala.IdTipoSala);
                        command.Parameters.AddWithValue("@fechaRegistro", reserva.FechaRegistro);
                        command.Parameters.AddWithValue("@fechaReserva", reserva.FechaReserva);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                throw;

            }
        }

        public List<Reserva> ObtenerTodasReservas()
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionString.ObtenerConexion()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM RESERVA";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {

                        using (SqlDataReader read = command.ExecuteReader())
                            
                        {
                            while (read.Read())
                            {
                                int idTipoSala = Convert.ToInt32(read["TIPO_SALA"]);
                                TipoSala tiposala = tiposalaData.ObtenerTipoPorId(idTipoSala);
                                Reserva reserva = ReservaMapper.MapearCamposReserva(read, tiposala);
                                reservas.Add(reserva);
                            }
                        }
                    }
                }
                return reservas;
            }

            catch (Exception ex)
            {
                throw;
            }


        }

        public void modificarReserva(int idReserva, int nuevoimporte, DateTime nuevaFechaReserva)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(ConexionString.ObtenerConexion()))
                {
                    conn.Open();
                    string sql = "UPDATE RESERVA SET IMPORTE = @importe, FECHA_RESERVA = @fechaReserva WHERE NUMERO_RESERVA = @numeroReserva";
                    using (SqlCommand comm = new SqlCommand(sql, conn))
                    {
                        comm.Parameters.AddWithValue("@importe", nuevoimporte);
                        comm.Parameters.AddWithValue("@fechaReserva", nuevaFechaReserva);
                        comm.Parameters.AddWithValue("@numeroReserva", idReserva);
                        comm.ExecuteNonQuery();
                    }
                }
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
                using(SqlConnection conn = new SqlConnection(ConexionString.ObtenerConexion()))
                {
                    conn.Open();
                    string sql = "DELETE FROM RESERVA WHERE NUMERO_RESERVA = @numeroReserva";
                    using(SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@numeroReserva", idreserva);
                        command.ExecuteNonQuery();
                    }    
                }    

            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public Reserva ObtenerReservaPorID(int idReserva)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionString.ObtenerConexion()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM RESERVA WHERE NUMERO_RESERVA = @idReserva";
                    using(SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("idReserva", idReserva);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                int idSala = Convert.ToInt32(reader["TIPO_SALA"]);
                                TipoSala tiposala = tiposalaData.ObtenerTipoPorId(idSala);

                                Reserva reserva= ReservaMapper.MapearCamposReserva(reader, tiposala);
                                return reserva;
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
