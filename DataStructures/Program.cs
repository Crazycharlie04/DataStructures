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