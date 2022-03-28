using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_U21
{
    class Movie
    {
        public string Name { get; set; }
        public int ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public string ActorSecondary { get; set; }
        public int Income { get; set; }
        
        public Movie(string name, int releaseDate, string genre, string studio, string director, string actor, string actorSecondary, int income)
        {
            this.Name = name;
            this.ReleaseDate = releaseDate;
            this.Genre = genre;
            this.Studio = studio;
            this.Director = director;
            this.Actor = actor;
            this.ActorSecondary = actorSecondary;
            this.Income = income;
        }

        public override bool Equals(object obj)
        {
            return ((Movie)obj).Name == Name;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
       
    }
}
