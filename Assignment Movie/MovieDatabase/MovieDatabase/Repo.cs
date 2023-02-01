using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    interface IFunction
    {
        void AddMovie(Movie movie);
        void AddActor(Actor actor);
        void AddDirector(Director director);
        void AddLink(Link link);
        void UpdateMovie(Movie movie);
        void UpdateActor(Actor actor);
        void UpdateDirector(Director director);
        void DeleteMovie(int id);
        void DeleteActor(int id);
        void DeleteDirector(int id);
        void DeleteLink(int movid, int actid);
        List<Movie> GetAllMovies();
        List<Director> GetAllDirectors();
        List<Actor> GetAllActors();
    }

    class Repo : IFunction
    {
        //static string connectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        const string STRCONNECTION = "Data Source = 192.168.171.36; Initial Catalog = 3307; Integrated Security = True";
        const string ADDMOVIE = "AddMovie";
        const string ADDACTOR = "INSERT into Actor(ActorName,ActorAge) VALUES(@actName,@actAge)";
        const string ADDDIRECTOR = "INSERT into Director(DirectorName) VALUES(@dirName)";
        const string ADDLINK = "INSERT into Link(MovieId,ActorId) VALUES(@movId,@actId)";
        const string UPDATEMOVIE = "UPDATE Movie SET MovieName=@movName,MovieDate=@movDate,MovieCollection=@movMoney,MovieLanguage=@movLanguage,MovieDuration=@movDuration,DirectorId=@dirId WHERE  MovieId=@movId";
        const string UPDATEACTOR = "UPDATE Actor SET ActorName=@actName,ActorAge=@actAge WHERE ActorId=@actId";
        const string UPDATEDIRECTOR = "UPDATE Director SET DirectorName=@dirName WHERE DirectorId=@dirId";
        const string DELETEMOVIE = "DELETE from Movie where MovieId=@movId";
        const string DELETEACTOR = "DELETE from Actor where ActorId=@actId";
        const string DELETEDIRECTOR = "DELETE from Director where DirectorId=@dirId";


        public void AddMovie(Movie movie)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(ADDMOVIE, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@movName", movie.MovieName);
            cmd.Parameters.AddWithValue("@movDate", movie.MovieDate);
            cmd.Parameters.AddWithValue("@movMoney", movie.MovieCollection);
            cmd.Parameters.AddWithValue("@movLanguage", movie.MovieLanguage);
            cmd.Parameters.AddWithValue("@movDuration", movie.MovieDuration);
            cmd.Parameters.AddWithValue("@dirId", movie.DirectorId);

            try
            {
                con.Open();
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void AddActor(Actor actor)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(ADDACTOR, con);
            
            cmd.Parameters.AddWithValue("@actName", actor.ActorName);
            cmd.Parameters.AddWithValue("@actAge", actor.ActorAge);

            try
            {
                con.Open();
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void AddDirector(Director director)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(ADDDIRECTOR, con);
            
            cmd.Parameters.AddWithValue("@dirName", director.DirectorName);

            try
            {
                con.Open();
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void AddLink(Link link)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(ADDLINK, con);

            cmd.Parameters.AddWithValue("@movId", link.MovieId);
            cmd.Parameters.AddWithValue("@actId", link.ActorId);

            try
            {
                con.Open();
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void UpdateMovie(Movie movie)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(UPDATEMOVIE, con);
            
            cmd.Parameters.AddWithValue("@movId", movie.MovieId);
            cmd.Parameters.AddWithValue("@movName", movie.MovieName);
            cmd.Parameters.AddWithValue("@movDate", movie.MovieDate);
            cmd.Parameters.AddWithValue("@movMoney", movie.MovieCollection);
            cmd.Parameters.AddWithValue("@movLanguage", movie.MovieLanguage);
            cmd.Parameters.AddWithValue("@movDuration", movie.MovieDuration);
            cmd.Parameters.AddWithValue("@dirId", movie.DirectorId);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void UpdateActor(Actor actor)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(UPDATEACTOR, con);

            cmd.Parameters.AddWithValue("@actId", actor.ActorId);
            cmd.Parameters.AddWithValue("@actName", actor.ActorName);
            cmd.Parameters.AddWithValue("@actAge", actor.ActorAge);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void UpdateDirector(Director director)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(UPDATEDIRECTOR, con);

            cmd.Parameters.AddWithValue("@dirId", director.DirectorId);
            cmd.Parameters.AddWithValue("@dirName", director.DirectorName);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DeleteMovie(int id)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(DELETEMOVIE, con);

            cmd.Parameters.AddWithValue("@movId", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DeleteActor(int id)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(DELETEACTOR, con);

            cmd.Parameters.AddWithValue("@actId", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DeleteDirector(int id)
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(DELETEDIRECTOR, con);

            cmd.Parameters.AddWithValue("@dirId", id);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DeleteLink(int movid, int actid)
        {
            throw new NotImplementedException();
        }

        static string connectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        static string GETELEMENTS = "SELECT* FROM Movie; SELECT* FROM Actor; SELECT* FROM Director; SELECT* FROM Link";
        static DataSet dataset = new DataSet();
        static SqlDataAdapter ada = null;

        public void LoadData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(GETELEMENTS, con);
            ada = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            ada.Fill(dataset);
            dataset.Tables[0].TableName = "Movielist";
            dataset.Tables[1].TableName = "Actorlist";
            dataset.Tables[1].TableName = "Directorlist";
            dataset.Tables[1].TableName = "Linklist";
        }


        public List<Movie> GetAllMovies()
        {
            List<Movie> list = new List<Movie>();
            foreach (DataRow item in dataset.Tables[0].Rows)
            {
                Movie mov = new Movie();

                mov.MovieId = (int)item[0];
                mov.MovieName = (string)item[1];
                mov.MovieDate = (DateTime)item[2];
                mov.MovieCollection = (Convert.ToDouble(item[3]));
                mov.MovieLanguage = (string)item[4];
                mov.MovieDuration = (TimeSpan)item[5];
                mov.DirectorId = (Convert.ToInt32(item[6]));

                list.Add(mov);//pass the elements of movie to list through objects
                Console.WriteLine(mov);
            }
            return list;
        }


        public List<Actor> GetAllActors()
        {
            List<Actor> list = new List<Actor>();
            foreach (DataRow item in dataset.Tables[1].Rows)
            {
                Actor act = new Actor();
                act.ActorId = (int)item[0];
                act.ActorName = (string)item[1];
                act.ActorAge = (int)item[2];

                list.Add(act);//pass the elements of actor to list through objects
                Console.WriteLine(act);
            }
            return list;
        }


        public List<Director> GetAllDirectors()
        {
            List<Director> list = new List<Director>();
            foreach (DataRow item in dataset.Tables[2].Rows)
            {
                Director dir = new Director();
                dir.DirectorId= (int)item[0];
                dir.DirectorName = (string)item[1];

                list.Add(dir);//pass the elements of actor to list through objects
                Console.WriteLine(dir);
            }
            return list;
        }


        
    }
}
