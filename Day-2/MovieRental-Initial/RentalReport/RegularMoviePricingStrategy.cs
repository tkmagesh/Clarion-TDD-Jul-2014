namespace RentalReport
{
    public class RegularMoviePricingStrategy : IMoviePricingStrategy
    {
        public double CalculatePriceFor(int daysRented)
        {
            return 2 + (daysRented > 2 ? (daysRented - 2)*1.5 : 0);
        }

        public int GetFrequentRentalPoints(int daysRented)
        {
            return 1;
        }
    }
}