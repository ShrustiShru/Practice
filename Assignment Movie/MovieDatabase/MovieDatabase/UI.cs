using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleConsoleApp;

namespace MovieDatabase
{
    class UI //<Main Coding part
    {

        public void AddingMovie()
        {
            string movName = Utilities.Prompt("Enter the Movie Name");
            string date = Utilities.Prompt("Enter the date in mm/dd/yyyy form");
            var movDate = DateTime.Parse(date);
            string movLanguage = Utilities.Prompt("Enter the language of the movie");
            double movMoney = Utilities.GetNumber("Enter the collection ");
            string duration = Utilities.Prompt("Enter the duration of the Movie");
            var movDuration = TimeSpan.Parse(duration);
            int dirId = Utilities.GetNumber("Enter the Id of the Director");

            Movie mov = new Movie
            {
                MovieName = movName,
                MovieDate = movDate,
                MovieCollection = movMoney,
                MovieLanguage = movLanguage,
                MovieDuration = movDuration,
                DirectorId = dirId
            };

            Repo obj = new Repo();
            obj.AddMovie(mov);
        }

        public void AddingActor()
        {
            string actName = Utilities.Prompt("Enter the Actor Name");
            int actAge = Utilities.GetNumber("Enter the Age of the Actor");

            Actor act = new Actor//
            {
                ActorName=actName,
                ActorAge=actAge
            };

            Repo actor = new Repo();
            actor.AddActor(act);
        }
        
        public void AddingDirector()
        {
            string dirName = Utilities.Prompt("Enter the Director Name");

            Director dir = new Director {
            DirectorName = dirName
            };

            Repo director = new Repo();
            director.AddDirector(dir);
        }

        public void AddingLink()
        {
            //    int actId = Utilities.GetNumber("Enter the Actor Id");
            //    int movId = Utilities.GetNumber("Enter the Movie Id");

            Link link = new Link();
           
            Movie mov = new Movie();
            Actor act = new Actor();

            mov.MovieId = link.MovieId;
            act.ActorId = link.ActorId;
            Console.WriteLine(link.ActorId);
            Console.WriteLine(link.MovieId); 
            //Repo linkrepo = new Repo();
            //linkrepo.AddLink(link);
        }


        public void UpdatingMovie()
        {
            int movId = Utilities.GetNumber("Enter the Movie Id to update");
            string movName = Utilities.Prompt("Enter the Movie Name");
            string date = Utilities.Prompt("Enter the date in mm/dd/yyyy form");
            var movDate = DateTime.Parse(date);
            double movMoney = Utilities.GetNumber("Enter the collection ");
            string movLanguage = Utilities.Prompt("Enter the language of the movie");
            string duration = Utilities.Prompt("Enter the duration of the Movie");
            var movDuration = TimeSpan.Parse(duration);
            int dirId = Utilities.GetNumber("Enter the Id of the Director");
            
            Movie mov = new Movie
            {
                MovieId = movId,
                MovieName = movName,
                MovieDate = movDate,
                MovieCollection = movMoney,
                MovieLanguage = movLanguage,
                MovieDuration = movDuration,
                DirectorId = dirId
            };

            Repo updmov = new Repo();
            updmov.UpdateMovie(mov);
        }

        public void UpdatingActor()
        {
            int actId = Utilities.GetNumber("Enter the Actor Id");
            string actName = Utilities.Prompt("Enter the Actor Name");
            int actAge = Utilities.GetNumber("Enter the Age of the Actor");

            Actor act = new Actor
            {
                ActorId = actId,
                ActorName = actName,
                ActorAge = actAge
            };

            Repo updact = new Repo();
            updact.UpdateActor(act);
        }

        public void UpdatingDirector()
        {
            int dirId = Utilities.GetNumber("Enter the Director Id");
            string dirName = Utilities.Prompt("Enter the Director Name");

            Director dir = new Director
            {
                DirectorId = dirId,
                DirectorName = dirName
            };

            Repo upddir = new Repo();
            upddir.UpdateDirector(dir);
        }


        public void DeletingMovie()
        {
            int movId=Utilities.GetNumber("Enter the Movie Id to be deleted");
            
            Repo delmov = new Repo();
            delmov.DeleteMovie(movId); //in delete function u only have to pass the id no need to create the object for it
        }

        public void DeletingActor()
        {
            int actId = Utilities.GetNumber("Enter the Actor Id to be deleted");

            Repo delact = new Repo();
            delact.DeleteActor(actId);
        }

        public void DeletingDirector()
        {
            int dirId = Utilities.GetNumber("Enter the Director Id to be deleted");

            Repo deldir = new Repo();
            deldir.DeleteDirector(dirId);
        }
    }
}

