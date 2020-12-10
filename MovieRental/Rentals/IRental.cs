﻿namespace MovieRental.Rentals
{
    public interface IRental
    {
        Movie Movie { get; }

        int Days { get; }

        int Bonus { get; }

        double Price { get; }
    }
}
