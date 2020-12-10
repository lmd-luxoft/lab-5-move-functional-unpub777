namespace MovieRental.PriceCalcStrategy
{
    public class RegularRental : Rental
    {
        public RegularRental(Movie movie, int days) : base(movie, days)
        {

        }

        public override double Price
        {
            get
            {
                var amount = 2;
                if (Days > 2)
                    amount += (Days - 2) * 15;

                return amount;
            }
        }
    }
}
