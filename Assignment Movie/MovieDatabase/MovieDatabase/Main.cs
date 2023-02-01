using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleConsoleApp;

namespace MovieDatabase
{
    class Output
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            Repo repo = new Repo();
            repo.LoadData();
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Press 1 ----------> Add Movie\n" +
                    "Press 2 ----------> Add Actor\n" +
                    "Press 3 ----------> Add Director\n" +
                    "Press 4 ----------> Add Link\n" +
                    "Press 5 ----------> Update Movie\n" +
                    "Press 6 ----------> Update Actor\n" +
                    "Press 7 ----------> Update Director\n"+
                    "Press 8 ----------> Delete Movie\n"+
                    "Press 9 ----------> Delete Actor\n"+
                    "Press 10 ----------> Delete Director\n" +
                    "Press 11 ----------> Display Movie\n" +
                    "Press 12 ----------> Display Actor\n" +
                    "Press 13 ----------> Display Director");
                int choice = Utilities.GetNumber("Enter the choice");
                switch (choice)
                {
                    case 1:
                        ui.AddingMovie();
                        break;
                    case 2:
                        ui.AddingActor();
                        break;
                    case 3:
                        ui.AddingDirector();
                        break;
                    case 4:
                        ui.AddingLink();
                        break;
                    case 5:
                        ui.UpdatingMovie();
                        break;
                    case 6:
                        ui.UpdatingActor();
                        break;
                    case 7:
                        ui.UpdatingDirector();
                        break;
                    case 8:
                        ui.DeletingMovie();
                        break;
                    case 9:
                        ui.DeletingActor();
                        break;
                    case 10:
                        ui.DeletingDirector();
                        break;
                    case 11:
                        repo.GetAllMovies();
                        break;
                    case 12:
                        repo.GetAllActors();
                        break;
                    case 13:
                        repo.GetAllDirectors();
                        break;
                    default:
                        throw new Exception("Invalid Input");
                }
            }
        }
    }
}
