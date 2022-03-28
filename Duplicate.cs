using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_U21
{
    class Duplicate
    {
        public Movie Movie { get; set; }
        public string FirstPersonMovies { get; set; }
        public string SecondPersonMovies { get; set; }

        public Duplicate(Movie movie, string firstPersonMovies, string secondPersonMovies)
        {
            this.Movie = movie;
            this.FirstPersonMovies = firstPersonMovies;
            this.SecondPersonMovies = secondPersonMovies;
        }
    }
}
