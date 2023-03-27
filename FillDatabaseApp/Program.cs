// See https://aka.ms/new-console-template for more information


using SommerhusLib.MockData;
using SommerhusLib.model;
using System.Data.SqlClient;


string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

List<Sommerhus> huse = SommerhusMockData.GetSommerhuse();

SqlConnection conn = new SqlConnection(ConnectionString);
conn.Open();

String sqlInsert = "insert into Sommerhus Values(@Sted, @Pris, @Senge, @Reng, @Husdyr, @Vask, @Opvask, @Spa)";

foreach (Sommerhus hus in huse)
{
    SqlCommand cmd = new SqlCommand(sqlInsert, conn);

    cmd.Parameters.AddWithValue("@Sted", hus.Sted.ToString());
    cmd.Parameters.AddWithValue("@Pris", hus.PrisPrUge);
    cmd.Parameters.AddWithValue("@Senge", hus.AntalSenge);
    cmd.Parameters.AddWithValue("@Reng", hus.Rengøring);
    cmd.Parameters.AddWithValue("@Husdyr", hus.Faciliteter.Husdyr);
    cmd.Parameters.AddWithValue("@Vask", hus.Faciliteter.Vaskemaskine);
    cmd.Parameters.AddWithValue("@Opvask", hus.Faciliteter.Opvaskemaskine);
    cmd.Parameters.AddWithValue("@Spa", hus.Faciliteter.Spa);

    int rows = cmd.ExecuteNonQuery();
    Console.WriteLine(rows);

}
