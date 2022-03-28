using System;
using System.Collections.Generic;


namespace L2_U21
{
    class Person
    {
        public string NameSurname { get; set;}
        public DateTime  Birthday { get; set; }
        public string City { get; set; }
        public List<Movie> Movies { get; set; }


        public Person(string nameSurname, DateTime birthday, string city, List<Movie> movies)
        {
            this.NameSurname = nameSurname;
            this.Birthday = birthday;
            this.City = city;
            this.Movies = movies;
        }
    }
}
