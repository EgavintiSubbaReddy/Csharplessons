
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMvcApp.Models
{
    public class RepositoryDbMovie
    {
        public static List<Movie> GetMovieList()
       {
          List<Movie> movielist = new List<Movie>();
           using (SqlConnection cn = SqlHelper.CreateConnection())
           {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllmovie = "Select * from Movie";
                selectmoviecmd.CommandText = selectAllmovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Movie movie = new Movie
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetDecimal(7),
                        Collection = moviedr.GetInt32(8),
                        Review = (int)(float)moviedr.GetDouble(9),
                    };
                    movielist.Add(movie);
                }
                return movielist;
           }

        }
        public static Movie GetMovieById(int id)
        {
            Movie movieFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllMovie = "Select * from Movie Where Id=@id";
                selectmoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmoviecmd.CommandText = selectAllMovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Movie movie = new Movie
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetDecimal(7),
                        Collection = moviedr.GetDecimal(8),
                        Review = (int)moviedr.GetDecimal(9)
                    };
                }
            }
            return movieFound;
        }
        public static int AddNewMovie(Movie nmovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertmoviecmd = cn.CreateCommand();
                String insertnmovieQuery = "insert into Movie values(@Id,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection,@Review)";
                insertmoviecmd.Parameters.Add("@Id", SqlDbType.Int).Value = nmovie.Id;
                insertmoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = nmovie.Title;
                insertmoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = nmovie.Language;
                insertmoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = nmovie.Hero;
                insertmoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = nmovie.Director;
                insertmoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = nmovie.MusicDirector;
                insertmoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = nmovie.ReleaseDate;
                insertmoviecmd.Parameters.Add("@Cost", SqlDbType.Int).Value = nmovie.Cost;
                insertmoviecmd.Parameters.Add("@Collection", SqlDbType.Int).Value = nmovie.Collection;
                insertmoviecmd.Parameters.Add("@Review", SqlDbType.Float).Value = nmovie.Review;
                insertmoviecmd.CommandText = insertnmovieQuery;
                query_result = insertmoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int UpdateMovie(Movie modifiedmovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updatemoviecmd = cn.CreateCommand();
                String updatemovieQuery = "update set Movie Id=@Id,Title=@Title,Lanuage=@Language,Hero=@Hero,Director=@Director,MusicDirector=@MusicDirector,ReleaseDate=@ReleaseDate,Cost=@Cost,Collection=@Collection,Review=@Review)";
                updatemoviecmd.Parameters.Add("@Id", SqlDbType.Int).Value = modifiedmovie.Id;
                updatemoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = modifiedmovie.Title;
                updatemoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = modifiedmovie.Language;
                updatemoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = modifiedmovie.Hero;
                updatemoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = modifiedmovie.Director;
                updatemoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = modifiedmovie.MusicDirector;
                updatemoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = modifiedmovie.ReleaseDate;
                updatemoviecmd.Parameters.Add("@Cost", SqlDbType.Int).Value = modifiedmovie.Cost;
                updatemoviecmd.Parameters.Add("@Collection", SqlDbType.Int).Value = modifiedmovie.Collection;
                updatemoviecmd.Parameters.Add("@Review", SqlDbType.Float).Value = modifiedmovie.Review;
                updatemoviecmd.CommandText = updatemovieQuery;
                query_result = updatemoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteMovie(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deletemoviecmd = cn.CreateCommand();
                String deletemovieQuery = "Delete from Movie where eno=@id";
                deletemoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deletemoviecmd.CommandText = deletemovieQuery;
                query_result = deletemoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
