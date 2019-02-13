using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTime
{
    class Program
    {

        static void Main(string[] args)
        {

            var prefferedGenre = Console.ReadLine();
            var prefferedLenght = Console.ReadLine();

            Dictionary<string, string> movies = new Dictionary<string, string>();
            Dictionary<string, string> prefferedMovies = new Dictionary<string, string>();
           
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "POPCORN!")
                    break;

                var moviesInfo = input
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var movieName = moviesInfo[0];
                var movieGenre = moviesInfo[1];
                var movieLenght = moviesInfo[2];


                if (movies.ContainsKey(movieName) == false)
                {
                    movies.Add(movieName, movieLenght);

                    if (movieGenre == prefferedGenre)
                    {
                        prefferedMovies.Add(movieName, movieLenght);
                    }
                }
            }
         
            if (prefferedLenght == "Short")
            {
                foreach (var film in prefferedMovies.OrderBy(x => x.Value))
                {
                    Console.WriteLine(film.Key);
                    var inputLine = Console.ReadLine();

                    if (inputLine == "Yes")
                    {
                        Console.WriteLine($"We're watching {film.Key} - {film.Value}");
                        break;
                    }

                }
            }
            else if (prefferedLenght == "Long")
            {
                foreach (var film in prefferedMovies.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine(film.Key);

                    var inputLine = Console.ReadLine();

                    if (inputLine == "Yes")
                    {
                        Console.WriteLine($"We're watching {film.Key} - {film.Value}");
                        break;
                    }
                }
            }

            Queue<TimeSpan> queue = new Queue<TimeSpan>();
            foreach (var film in movies)
            {
                TimeSpan lenght = TimeSpan.Parse(film.Value);
                queue.Enqueue(lenght);
            }

            TimeSpan total = new TimeSpan(queue.Sum(t => t.Ticks));
            Console.WriteLine($"Total Playlist Duration: {total}");
        }
    }
}
