using RegistrationArea.Repository.Entiess;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RegistrationArea.Repository
{
    public class SignRepository
    {
        public List<HoroscopeSign> GetSigns()
        {
            List<HoroscopeSign> horoscpeSigns = new List<HoroscopeSign>();

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FunFestivalDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "select Id, SignName from HoroscopeSign";

            sqlCommand.Connection = sqlConnection;

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                HoroscopeSign horoscpeSign = new HoroscopeSign();

                horoscpeSign.Id = reader.GetInt32(0);

                horoscpeSign.SignName = reader.GetString(1);

                horoscpeSigns.Add(horoscpeSign);
            }


            sqlConnection.Close();


            return horoscpeSigns;
        }
        public bool InsertSingn(HoroscopeSign horoscopeSignNew)
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FunFestivalDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "insert into HoroscopeSign(SignName) values('" + horoscopeSignNew.SignName + "') ";

            sqlCommand.Connection = sqlConnection;

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return rowsAffected > 0;
        }
        public bool Update(HoroscopeSign horoscopeSign)
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FunFestivalDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "update HoroscopeSign set SignName = '" + horoscopeSign.SignName + "' where Id = " + horoscopeSign.Id + " ";

            sqlCommand.Connection = sqlConnection;

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();


            return rowsAffected > 0;
        }
        public bool Delete(HoroscopeSign horoscopeSign)
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FunFestivalDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "delete from HoroscopeSign where Id = "+horoscopeSign.Id+" ";

            sqlCommand.Connection = sqlConnection;

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();


            return rowsAffected > 0;
        }

       
    }




}

