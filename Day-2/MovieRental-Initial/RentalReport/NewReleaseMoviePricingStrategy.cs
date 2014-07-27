namespace RentalReport
{
    public class NewReleaseMoviePricingStrategy : IMoviePricingStrategy
    {
        public double CalculatePriceFor(int daysRented)
        {
            return daysRented * 3;
        }

        public int GetFrequentRentalPoints(int daysRented)
        {
            return daysRented > 1 ? 2 : 1;
        }
    }
}