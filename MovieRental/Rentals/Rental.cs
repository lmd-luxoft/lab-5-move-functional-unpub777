namespace MovieRental.PriceCalcStrategy
{
    public abstract class Rental : IRental
    {
        public int Days { get; private set; }

        public Movie Movie { get; private set; }

        public Rental(Movie movie, int days)
        {
            Days = days;
            Movie = movie;
        }

        public virtual int Bonus => 1;

        public abstract double Price { get; }
    }
}
