using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace L2_U21
{
    class InOut
    {
        /// <summary>
        /// Reading data from file and putting it in List of class Movie
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Person ReadMovies(string fileName)
        {
            List<Movie> movies = new List<Movie>();
            string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);

            string nameSurname = lines[0];
            DateTime birthday = Convert.ToDateTime(lines[1]);
            string city = lines[2];
            List<string> temporary = new List<string>(lines);
            temporary.RemoveRange(0, 3);
            foreach (string line in temporary)
            {
                string[] values = line.Split(',');
                string name = values[0];
                int releaseDate = Convert.ToInt32(values[1]);
                string genre = values[2];
                string studio = values[3];
                string director = values[4];
                string actor = values[5];
                string actorSecondary = values[6];
                int income = Convert.ToInt32(values[7]);

                Movie movie = new Movie(name, releaseDate, genre, studio, director, actor,
                actorSecondary, income);
                movies.Add(movie);
            }
            Person Info = new Person(nameSurname, birthday, city, movies);
            return Info;
        }
        /// <summary>
        /// Printing out to console movies in which Tom Cruise or Nicole Kidman acted
        /// </summary>
        /// <param name="AllMovies"></param>
        public void PrintFilteredMovies(List<Movie> AllMovies)
        {
            string Dashes = new string('-', 50);
            Console.WriteLine(Dashes);
            Console.WriteLine("Movies with Tom Cruise or Nicole Kidman:");
            Console.WriteLine();
            Console.WriteLine("|{0,-25} | {1,-5}|", "Movie's name", "Release date");
            Console.WriteLine(Dashes);
            foreach (Movie movie in AllMovies)
            {
                Console.WriteLine("| {0,-24} | {1, 11} |", movie.Name, movie.ReleaseDate);
            }
            Console.WriteLine(Dashes);
        }
        /// <summary>
        /// Printing number of movies who were created by Warner Bros. studio to the console
        /// </summary>
        /// <param name="sum"></param>
        public void PrintSumOfMoviesByStudio(int sum)
        {
            Console.WriteLine("Warner Bros. released |{0}| movies", sum);
        }
        /// <summary>
        /// Printing set of all actors who acted in movies of the given list to the file
        /// </summary>
        /// <param name="Actors"></param>
        public void PrintActorsTofile(HashSet<string> Actors)
        {
            File.WriteAllLines("Actors.csv", Actors, Encoding.UTF8);
        }
            
        /// <summary>
        /// Printing movies that they want to recommend to each other
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="duplicates"></param>
        public void PrintReccomendMovies(string fileName, List<Movie> movies)
        {
            string[] lines = new string[movies.Count + 1];

            for(int i = 0; i < movies.Count; i++)
            {
                lines[i] = String.Format("{0};{1};{2};{3};{4};{5};{6};{7}", movies[i].Name, movies[i].ReleaseDate, movies[i].Genre,
                   movies[i].Studio, movies[i].Director, movies[i].Actor, movies[i].ActorSecondary,
                   movies[i].Income);
            }

            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }

        /// <summary>
        /// Printing movies that both saw
        /// </summary>
        /// <param name="fileName">current file name</param>
        /// <param name="duplicates"></param>
        public void PrintMoviesBothSaw(string fileName, List<Movie> movies)
        {
            string[] lines = new string[movies.Count + 1];

            for(int i = 0; i < movies.Count; i++)
            {
                lines[i] = String.Format("{0};{1};{2};{3};{4};{5};{6};{7}", movies[i].Name, movies[i].ReleaseDate, movies[i].Genre,
                      movies[i].Studio, movies[i].Director, movies[i].Actor, movies[i].ActorSecondary,
                      movies[i].Income);
            }

            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }

        /// <summary>
        /// Printing Data to txt
        /// </summary>
        /// <param name="fileName">current file name</param>
        /// <param name="person"></param>
        public void PrintDataToTxt(string fileName, Person person)
        {
            string Dashes = new string('-', 100);
            string[] lines = new string[person.Movies.Count + 10];

            lines[0] = person.NameSurname;
            lines[1] = person.Birthday.ToString("yyyy-MM-dd");
            lines[2] = person.City;
            lines[3] = Dashes;
            lines[5] = (String.Format("| {0,-20} | {1,5} | {2,-10} | {3,-25} | {4,-15} | {5, -15} | {6,-25} | {7,-10} |",
                    "Name:", "Date:", "Genre:", "Studio:", "Director:", "Actor:", "Actor:", "Income:"));
            lines[6] = Dashes;
            for(int i = 0; i < person.Movies.Count; i++)
            {
                lines[i+6] = String.Format("| {0,-20} | {1,-5} | {2,-10} | {3,-25} | {4,-16} | {5,-15} | {6,-25} | {7,10} |", 
                    person.Movies[i].Name, person.Movies[i].ReleaseDate, person.Movies[i].Genre, person.Movies[i].Studio, person.Movies[i].Director,
                    person.Movies[i].Actor, person.Movies[i].ActorSecondary, person.Movies[i].Income);

            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
    }
}
        
