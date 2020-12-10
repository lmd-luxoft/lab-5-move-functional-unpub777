namespace MovieRental.PriceCalcStrategy
{
    public class NewReleaseRental : Rental
    {
        public NewReleaseRental(Movie movie, int days) : base(movie, days)
        {
        }

        public override int Bonus
        {
            get
            {
                if (Days > 1)
                {
                    return 2;
                }

                return base.Bonus;
            }
        }

        public override double Price => Days * 3;
    }
}
