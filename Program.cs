using System;
using System.Collections.Generic;


namespace L2_U21
{
    class Program
    {
        static void Main(string[] args)
        {
            Person FirstPersonMovies = InOut.ReadMovies(@"FirstPersonMovies.txt");
            Person SecondPersonMovies = InOut.ReadMovies(@"SecondPersonMovies.txt");

            MoviesRegister register = new MoviesRegister(FirstPersonMovies.Movies, SecondPersonMovies.Movies); ;

            List<Movie> MoviesFilteredByActor = register.FilterByActor();
            int sumOfMoviesByStudio = register.CountByStudio();
            HashSet<string> AllActors = register.GetAllActors();
            List<Movie> firstRecommend = register.FindFirstPersonRecommend();
            List<Movie> secondRecommend = register.FindSecondPersonRecommend();
            List<Movie> bothSaw = register.FindSameMovies();

            InOut Printing = new InOut();
            Printing.PrintFilteredMovies(MoviesFilteredByActor);
            Printing.PrintSumOfMoviesByStudio(sumOfMoviesByStudio);
            Printing.PrintActorsTofile(AllActors);
            Printing.PrintReccomendMovies(@"Rekomendacija_First_Person.csv", firstRecommend);
            Printing.PrintReccomendMovies(@"Rekomendacija_Second_Person.csv", secondRecommend);
            Printing.PrintMoviesBothSaw(@"AbiejuFilmai.csv", bothSaw);
            Printing.PrintDataToTxt(@"DataFirst.txt", FirstPersonMovies);
            Printing.PrintDataToTxt(@"DataSecond.txt", SecondPersonMovies);

            Console.ReadLine();
        }
    }
}
