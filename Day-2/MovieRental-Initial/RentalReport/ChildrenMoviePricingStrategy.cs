namespace RentalReport
{
    public class ChildrenMoviePricingStrategy : IMoviePricingStrategy
    {
        public double CalculatePriceFor(int daysRented)
        {
            return 1.5 + (daysRented > 3 ? (daysRented - 3)*1.5 : 0);
        }

        public int GetFrequentRentalPoints(int daysRented)
        {
            return 1;
        }
    }
}