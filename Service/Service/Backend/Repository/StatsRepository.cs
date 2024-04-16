using Service.Backend.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Service.Backend.Repository
{
    public class StatsRepository
    {
        private readonly string _connectionString;

        public StatsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AddStat(Stats stat)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Stats (StatsID, SongID, Streams) VALUES (@StatsId, @SongId, @Streams)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@StatsId", stat.StatsId);
                    command.Parameters.AddWithValue("@SongId", stat.SongID);
                    command.Parameters.AddWithValue("@Streams", stat.Counter);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteStat(int statsId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Stats WHERE StatsId = @StatsId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@StatsId", statsId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateStat(Stats givenStat, int statsId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE Stats SET StatsID=@StatsId, SongID=@SongId, Streams=@Streams WHERE StatsId = @StatsId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@StatsId", givenStat.StatsId);
                    command.Parameters.AddWithValue("@SongId", givenStat.SongID);
                    command.Parameters.AddWithValue("@Streams", givenStat.Counter);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public Stats GetStatById(int statsId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT StatsId, SongId, Stream FROM Stats WHERE StatsId = @StatsId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@StatsId", statsId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int StatsId = reader.GetInt32(0);
                            int SongID = reader.GetInt32(1);
                            int Counter = reader.GetInt32(2);
                            return new Stats(SongID, Counter, StatsId);
                        }
                    }
                }
            }
            return null;
        }
    }
}
