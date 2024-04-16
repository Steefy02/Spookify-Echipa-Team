using Service.Backend.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Documents;


namespace Service.Backend.Repository
{
    public class SongRepository
    {
        private readonly string _connectionString;

        public SongRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AddSong(Song song)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Songs (ID, Name, Album, Artist, Path) VALUES (@SongId, @Title, @Album, @Artist, @Path)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@SongId", song.SongId);
                    command.Parameters.AddWithValue("@Title", song.Name);
                    command.Parameters.AddWithValue("@Album", song.Album);
                    command.Parameters.AddWithValue("@Artist", song.Artist);
                    command.Parameters.AddWithValue("@Path", song.Path);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteSong(int songId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Songs WHERE ID = @SongId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@SongId", songId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateSong(Song givenSong, int songId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE Songs SET name = @Name, Album = @Album, Artist = @Artist, Path = @Path WHERE ID = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", givenSong.Name);
                    command.Parameters.AddWithValue("@Album", givenSong.Album);
                    command.Parameters.AddWithValue("@Artist", givenSong.Artist);
                    command.Parameters.AddWithValue("@Path", givenSong.Path);
                    command.Parameters.AddWithValue("@Id", songId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public Song GetSongById(int songId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT ID, Name, Album, Artist, Path FROM Songs WHERE ID = @SongId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@SongId", songId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int SongId = reader.GetInt32(0);
                            string Name = reader.GetString(1);
                            string Album = reader.GetString(2);
                            string Artist = reader.GetString(3);
                            string Path = reader.GetString(4);
                            return new Song(Path, Artist, SongId, Name, Album);
                        }
                    }
                }
            }
            return null;
        }

    public IEnumerable<Stats> GetSongs()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
                var songlist = new List<Song>();
                connection.Open();
                string sql = "SELECT * FROM Stats";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{
                    //    reader.Read();
                    //    var songId = reader.GetInt32(0); // Assuming SongId is the first column
                    //    var title = reader.GetString(1); // Assuming Title is the second column

                    //    string artist = reader.GetString(2); // Assuming Artist is the fourth column
                    //    var album = reader.GetString(3); // Assuming Album is the third column
                    //    string path = reader.GetString(4); // Assuming Path is the fifth column

                    //    Console.WriteLine(songId.ToString(), title, album, artist, path);

                    //}
                }
            }
        return null;
    }
}
}
