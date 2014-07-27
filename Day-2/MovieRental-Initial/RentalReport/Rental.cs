namespace RentalReport
{
    public class Rental
    {
        Movie _movie;
        int _daysRented;

        public Rental(Movie movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }

        public int DaysRented
        {
            get
            {
                return _daysRented;
            }
        }

        public Movie Movie
        {
            get { return _movie; }
        }

        public double CalculateAmount()
        {
           return _movie.GetAmount(this.DaysRented);
        }

        public int GetFrequentRentalPoints()
        {
            return _movie.GetFrequentRentalPoints(this.DaysRented);
        }
    }
}