using Microsoft.AspNetCore.SignalR;
using SommerhusLib.model;
using System.Data.SqlClient;

namespace SonnerhusApp.services
{
    public class SommerhusRepositoryServiceDB : ISommerhusRepositoryService
    {
        public Sommerhus Create(Sommerhus sommerhus)
        {
            String sqlInsert = "insert into Sommerhus OUTPUT INSERTED.Id Values(@Sted, @Pris, @Senge, @Reng, @Husdyr, @Vask, @Opvask, @Spa)";

            using (SqlConnection conn = new SqlConnection(Secret.GetConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@Sted", sommerhus.Sted.ToString());
                cmd.Parameters.AddWithValue("@Pris", sommerhus.PrisPrUge);
                cmd.Parameters.AddWithValue("@Senge", sommerhus.AntalSenge);
                cmd.Parameters.AddWithValue("@Reng", sommerhus.Rengøring);
                cmd.Parameters.AddWithValue("@Husdyr", sommerhus.Faciliteter.Husdyr);
                cmd.Parameters.AddWithValue("@Vask", sommerhus.Faciliteter.Vaskemaskine);
                cmd.Parameters.AddWithValue("@Opvask", sommerhus.Faciliteter.Opvaskemaskine);
                cmd.Parameters.AddWithValue("@Spa", sommerhus.Faciliteter.Spa);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    sommerhus.Id = reader.GetInt32(0);
                }
                else
                {
                    throw new ArgumentException("Kunne ikke oprette sommerhuset");
                }

            }
            
            return sommerhus;
        }

        public Sommerhus Delete(int id)
        {
            String sqlInsert = "delete from Sommerhus output deleted.* where Id = @Id";

            using (SqlConnection conn = new SqlConnection(Secret.GetConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return ReadSommerhus(reader);
                }
                else
                {
                    throw new ArgumentException("Kunne ikke slette sommerhuset");
                }
            }
        }

        public List<Sommerhus> GetAll()
        {
            String sqlInsert = "select * from Sommerhus";
            List<Sommerhus> list = new List<Sommerhus>();

            using (SqlConnection conn = new SqlConnection(Secret.GetConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(ReadSommerhus(reader));
                }
            }

            return list;
        }

        private Sommerhus ReadSommerhus(SqlDataReader reader)
        {
            Sommerhus sommerhus = new Sommerhus();

            sommerhus.Id = reader.GetInt32(0);
            sommerhus.Sted = Enum.Parse<StedType>(reader.GetString(1));
            sommerhus.PrisPrUge = reader.GetInt32(2);
            sommerhus.AntalSenge = reader.GetInt32(3);
            sommerhus.Rengøring = reader.GetBoolean(4);
            sommerhus.Faciliteter = new Faciliteter();
            sommerhus.Faciliteter.Husdyr = reader.GetBoolean(5);
            sommerhus.Faciliteter.Vaskemaskine = reader.GetBoolean(6);
            sommerhus.Faciliteter.Opvaskemaskine = reader.GetBoolean(7);
            sommerhus.Faciliteter.Spa = reader.GetBoolean(8);

            return sommerhus;
        }

        public Sommerhus GetById(int id)
        {
            String sqlInsert = "select * from Sommerhus where Id = @Id";
            List<Sommerhus> list = new List<Sommerhus>();

            using (SqlConnection conn = new SqlConnection(Secret.GetConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return ReadSommerhus(reader);
                }
            }

            throw new KeyNotFoundException();
        }

        public Sommerhus Update(int id, Sommerhus sommerhus)
        {
            String sqlInsert = "update Sommerhus " +
                "set Sted = @Sted, PrisPrUge = @Pris, AntalSenge = @Senge, Rengoering = @Reng, " +
                "Husdyr = @Husdyr, Vaskemaskine = @Vask, Opvaskemaskine = @Opvask, SPA = @Spa " +
                "where Id = @Id";

            using (SqlConnection conn = new SqlConnection(Secret.GetConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Sted", sommerhus.Sted.ToString());
                cmd.Parameters.AddWithValue("@Pris", sommerhus.PrisPrUge);
                cmd.Parameters.AddWithValue("@Senge", sommerhus.AntalSenge);
                cmd.Parameters.AddWithValue("@Reng", sommerhus.Rengøring);
                cmd.Parameters.AddWithValue("@Husdyr", sommerhus.Faciliteter.Husdyr);
                cmd.Parameters.AddWithValue("@Vask", sommerhus.Faciliteter.Vaskemaskine);
                cmd.Parameters.AddWithValue("@Opvask", sommerhus.Faciliteter.Opvaskemaskine);
                cmd.Parameters.AddWithValue("@Spa", sommerhus.Faciliteter.Spa);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    sommerhus.Id = id;
                }
                else
                {
                    throw new ArgumentException("Kunne ikke oprette sommerhuset");
                }

            }

            return sommerhus;
        }
    }
}
