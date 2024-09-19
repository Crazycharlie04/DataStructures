using System.Xml.Serialization;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            Console.ReadKey();



        }

        private static void ListMovies()
        {
            Movie deadpool3;
            deadpool3.title = "Deadpool & wolverine";
            deadpool3.releaseYear = 2024;
            deadpool3.price = 19.99;
            deadpool3.rating = MovieRating._15;

            Console.Clear();
            Console.WriteLine(deadpool3.title + "(" + deadpool3.releaseYear + ") Rated " + deadpool3.rating);

        }

        private static void Listshows() {
            List<TVShow> shows = new List<TVShow>();
            shows.Add(new TVShow("The Lord of The Rings: The Rings of Power,", 2022, 0, MovieRating._15));
            shows.Add(new TVShow("The Boys,", 2019, 7.99, MovieRating._18));
            shows.Add(new TVShow("Ben and Holly's little kingdom,", 2009, 12.45, MovieRating._U));

            Console.Clear();

            for (
                int i = 0; i < shows.Count; i++)
            {
                Console.WriteLine(shows[i].ToString());
            }
        }

        private static void MainMenu() 
        { while (true)
            {
                Console.Clear();
                Console.WriteLine("please choose from the following oprions: \n");
                Console.WriteLine("(1) list movies");
                Console.WriteLine("(2) list TVShows");
                Console.WriteLine("/n");
                Console.WriteLine("(0) Exit application");
                Console.WriteLine("/n");


                string userinput = Console.ReadLine();
                //has the user entered an integer value
                if(int.TryParse(userinput, out int IntergerInput))
                {
                    switch (IntergerInput)
                    {
                        case 0: Environment.Exit(0);
                                break;
                            
                        case 1:
                            ListMovies();
                            Console.ReadKey(); break;
                           
                        case 2:
                            Listshows();
                            Console.ReadKey();
                            break;
                    }
                }
            }
        
        }

        public enum MovieRating
        {
            _U, 
            _12A, 
            _12, 
            _15, 
            _18
        }
        public struct Movie 
        { public string title;
            public int releaseYear;
            public double price;
            public MovieRating rating;
        }
    }
}