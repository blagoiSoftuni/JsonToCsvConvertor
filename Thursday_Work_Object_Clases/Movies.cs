using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_Work_Object_Clases
{
    internal class Movies
    {
        class Movie
        {
            public string Genre { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
        }

        class Program
        {
            static void Main()
            {

                int N = int.Parse(Console.ReadLine());

                List<Movie> movies = new List<Movie>();


                for (int i = 0; i < N; i++)
                {
                    string input = Console.ReadLine();
                    string[] parts = input.Split('|');

                    Movie movie = new Movie
                    {
                        Genre = parts[0],
                        Name = parts[1],
                        Duration = int.Parse(parts[2])
                    };

                    movies.Add(movie);
                }


                string genre = Console.ReadLine();


                IEnumerable<string> movieNames;
                if (genre.ToLower() == "all")
                {
                    movieNames = movies.Select(m => m.Name);
                }
                else
                {
                    movieNames = movies.Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                                       .Select(m => m.Name);
                }


                foreach (string name in movieNames)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}


