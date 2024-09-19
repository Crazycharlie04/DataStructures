namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie deadpool3;
            deadpool3.title = "Deadpool & wolverine";
            deadpool3.releaseYear = 2024;
            deadpool3.price = 19.99;
            deadpool3.rating = MovieRating._15;

            Console.WriteLine(deadpool3.title + "(" + deadpool3.releaseYear + ") Rated " + deadpool3.rating);

            Console.ReadKey();
            Console.WriteLine("\n\n");
            //console.clear();

            List<TVShow> shows = new List<TVShow>();
            shows.Add(new TVShow("The Lord of The Rings: The Rings of Power," ,2022, 0, MovieRating._15));
            shows.Add(new TVShow("The Boys,", 2019, 7.99, MovieRating._18 ));
            shows.Add(new TVShow("Ben and Holly's little kingdom,", 2009, 12.45, MovieRating._U));

            for (
                int i = 0; i < shows.Count; i++) { Console.WriteLine(shows[i].ToString());
            }
            Console.ReadKey();
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