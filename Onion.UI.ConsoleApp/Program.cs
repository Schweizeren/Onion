using Onion.Core.Entity;
using System;
using System.Collections.Generic;

namespace Menu
{
    class Program
    {
         int id = 1;
         List<Movie> movies = new List<Movie>();

         void Main(string[] args)
        {


            String[] menuItems = {"List all movies",
                                  "Create movie",
                                  "Delete movie",
                                  "Edit movie",
                                  "Exit" };

            var selection = ShowMenu(menuItems);

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        ListMovies();
                        break;
                    case 2:
                        AddMovie();
                        break;
                    case 3:
                        DeleteMovie();
                        break;
                    case 4:
                        EditMovie();
                        break;
                    default:
                        break;
                }
                Console.Clear();
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("Bye bye!");


        }

        private  void EditMovie()
        {
            var Movie = FindMovieByID();

            Console.WriteLine("title: ");
            Movie.title = Console.ReadLine();

            Console.WriteLine("Release_year: ");
            Movie.release_year = Convert.ToInt32(Console.ReadLine());
        }

        private  void DeleteMovie()
        {
            ListMovies();
            var movieFound = FindMovieByID();
            Console.WriteLine("Insert movie id to delete");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a valid id");
            }

            foreach (var Movie in movies)
            {
                if (Movie.id == id)
                {
                    movieFound = Movie;
                }
            }

            if (movieFound != null)
            {
                Console.WriteLine("Are you sure you want to delete the movie? (Y/N)");
                if (Console.ReadLine() == "N")
                {
                    Console.Clear();

                }
                else if (Console.ReadLine() == "Y")
                {
                    movies.Remove(movieFound);
                }

            }
        }

        private  void AddMovie()
        {

            Console.WriteLine("Title: ");
            var title = Console.ReadLine();

            Console.WriteLine("Release_year: ");
            var release_year = Convert.ToInt32(Console.ReadLine());

            movies.Add(new Movie() { id = id++, title = title, release_year = release_year });

        }

        private  Movie FindMovieByID()
        {
            Console.WriteLine("Insert movie id");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a valid id");
            }

            foreach (var Movie in movies)
            {
                if (Movie.id == id)
                {
                    return Movie;
                }
            }

            return null;
        }

        private  void ListMovies()
        {
            Console.WriteLine("List of movies:");
            foreach (var Movie in movies)
            {
                Console.WriteLine($" id: {Movie.id} Name: {Movie.title}; Release_year {Movie.release_year};");
            }
            Console.WriteLine("\n");
        }

        private  int ShowMenu(string[] menuItems)
        {
            Console.Clear();
            Console.WriteLine("Select what you want to do:\n ");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($" {(i + 1)} : {menuItems[i]}");
            }

            Console.WriteLine("Enter a number between 1-6");

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 6)
            {
                Console.WriteLine("You need to select a number between 1-6");
            }


            return selection;


        }
    }
}
