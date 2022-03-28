using System.Collections.Generic;

namespace L2_U21
{
    class MoviesRegister
    {

        private List<Movie> allMovies = new List<Movie>();
        private List<Movie> FirstPerson = new List<Movie>();
        private List<Movie> SecondPerson = new List<Movie>();

        public MoviesRegister(List<Movie> First, List<Movie> Second)
        {
          foreach(Movie movie in First)
            {
                FirstPerson.Add(movie);
                allMovies.Add(movie);
            }

          foreach(Movie movie in Second)
            {
                SecondPerson.Add(movie);
                allMovies.Add(movie);
            }
        }

        public List<Movie> getallMovies()
        {
            return this.allMovies;
        }

        /// <summary>
        /// Filltering movies in which Tom Cruise or Nicole Kidman acted
        /// </summary>
        /// <param name="allmovies"></param>
        /// <returns>returns filtered actors</returns>
        public List<Movie> FilterByActor()
        {
            List<Movie> movies = new List<Movie>();  
             for (int i = 0; i < allMovies.Count; i++)
             {
                   if (allMovies[i].Actor == "Tom Cruise" || allMovies[i].ActorSecondary == "Tom Cruise" || allMovies[i].Actor == "Nicole Kidman" || allMovies[i].ActorSecondary == "Nicole Kidman")
                    {
                        movies.Add(allMovies[i]);
                    }
                    
              
            }
            return movies;
        }
        /// <summary>
        /// Counting movies made by Warner Bros. Studio
        /// </summary>
        /// <param name="allmovies"></param>
        /// <returns>returns a sum</returns>
        public int CountByStudio()
        {
            int sum = 0;
            for (int i = 0; i < allMovies.Count; i++)
            {
                if (allMovies[i].Studio == "Warner Bros.")
                {
                    sum++;
                }
            }
            return sum;
        }
        /// <summary>
        /// Filtering all actors and putting them in hashset(implements the Set Interface, duplicate values are not allowed)
        /// We dont get duplicates so we can know how many different actors acted in moves given in the list
        /// </summary>
        /// <param name="allmovies"></param>
        /// <returns>returns different actors</returns>
        public HashSet<string> GetAllActors()
        {
            HashSet<string> Actors = new HashSet<string>();

            for (int i = 0; i < allMovies.Count; i++)
            {
                Actors.Add(allMovies[i].Actor);
                Actors.Add(allMovies[i].ActorSecondary);
            }
            return Actors;
        }

        /// <summary>
        /// A Method which shows what movies First Person is recommending for Second Person to watch
        /// </summary>
        /// <returns>returns first person recommendations</returns>
        public List<Movie> FindFirstPersonRecommend()
        {
            List<Movie> FirstPersonRecommendation = new List<Movie>();

            foreach(Movie movie in FirstPerson)
            {
                if(!SecondPerson.Contains(movie))
                {
                    FirstPersonRecommendation.Add(movie);
                }
            }
            return FirstPersonRecommendation;
        }

        /// <summary>
        /// A Method which shows what movies Second Person is recommening for First Person to watch
        /// </summary>
        /// <returns>returns second person recommendations</returns>
        public List<Movie> FindSecondPersonRecommend()
        {
            List<Movie> SecondPersonRecommendation = new List<Movie>();

            foreach(Movie movie in SecondPerson)
            {
                if(!FirstPerson.Contains(movie))
                {
                    SecondPersonRecommendation.Add(movie);
                }
            }
            return SecondPersonRecommendation;
        }

        /// <summary>
        /// A method which shows what same movies they both watched
        /// </summary>
        /// <returns>returns what movies they both saw</returns>
        public List<Movie> FindSameMovies()
        {
            List<Movie> MoviesBothSaw = new List<Movie>();

            foreach(Movie movie in FirstPerson)
            {
                if (SecondPerson.Contains(movie))
                {
                    MoviesBothSaw.Add(movie);
                }
            }
            return MoviesBothSaw;
        }
      
    }
}
