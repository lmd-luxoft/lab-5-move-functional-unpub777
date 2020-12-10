namespace MovieRental.Rentals
{
    public class ChildRental : Rental
    {
        public ChildRental(Movie movie, int days) : base(movie, days)
        {
        }

        public override double Price
        {
            get
            {
                var amount = 15;
                if (Days > 3)
                    amount += (Days - 3) * 15;

                return amount;
            }
        }
    }
}
