namespace RentalReport
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        string _title;
        int _priceCode;

        private readonly IMoviePricingStrategy _pricingStrategy;

        public Movie(string title, IMoviePricingStrategy pricingStrategy)
        {
            _title = title;
            _pricingStrategy = pricingStrategy;
            
        }

        //this has to go
        public Movie(string title,int priceCode)
        {
            _title = title;
            _priceCode = priceCode;
            if (priceCode == 0) _pricingStrategy = new RegularMoviePricingStrategy();
            if (priceCode == 1) _pricingStrategy = new NewReleaseMoviePricingStrategy();
            if (priceCode == 2) _pricingStrategy = new ChildrenMoviePricingStrategy();
        }

        public int PriceCode
        {
            get { return _priceCode; }
            set { _priceCode = value;}
        }

        public string Title
        {
            get { return _title; }
        }

        public double GetAmount(int daysRented)
        {
            return _pricingStrategy.CalculatePriceFor(daysRented);
        }

        public int GetFrequentRentalPoints(int daysRented)
        {
            return _pricingStrategy.GetFrequentRentalPoints(daysRented);
            
        }
    }
}