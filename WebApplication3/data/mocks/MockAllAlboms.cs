using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.data.interfaces;


namespace WebApplication3.data.mocks
{
    public class allAlboms : iAllAlboms
    {
        
        
        
        
        

        IEnumerable<albom> iAllAlboms.Alboms { get {

                return GetAlboms();



            }
            set {
                GetAlboms();
            } 
        }

        public static List<albom> GetAlboms()
        {

            List<albom> AllAlboms = new List<albom>();



            string connectionString = "server=(localdb)\\MSSQLLocalDB;user=sa; password=000000; database = music ";

            string sqlExpression = "SELECT * FROM Alboms";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                       albom.setAlbom(Convert.ToInt32(reader.GetValue(0)), Convert.ToInt32(reader.GetValue(2)), Convert.ToInt32(reader.GetValue(3)), Convert.ToString(reader.GetValue(4)), Convert.ToString(reader.GetValue(5)), Convert.ToString(reader.GetValue(6)), Convert.ToString(reader.GetValue(7)), Convert.ToString(reader.GetValue(8)));
                       AllAlboms.Add(albom.GetAlbom());
                    }
                }
            }



            return AllAlboms;
        }



    }
}
