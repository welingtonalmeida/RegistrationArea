using RegistrationArea.Repository.Entiess;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RegistrationArea.Repository
{
    public class ClientRepository
    {
        public List<Client> GetSigns()
        {
            List<Client> Clients = new List<Client>();

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FunFestivalDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "select Id, ClientName, ClientCpf, ClientBirthDate, ClientCoutryOrigin from Client";

            sqlCommand.Connection = sqlConnection;

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client();

                client.Id = reader.GetInt32(0);

                client.ClientName = reader.GetString(1);

                client.ClientCpf = reader.GetString(2);

                client.ClientBirthDate = reader.GetString(3);

                client.ClientCoutryOrigin = reader.GetString(4);

                Clients.Add(client);
            }


            sqlConnection.Close();


            return Clients;
        }

    }
}
