namespace RentalReport
{
    public interface IMoviePricingStrategy
    {
        double CalculatePriceFor(int daysRented);
        int GetFrequentRentalPoints(int daysRented);
    }
}