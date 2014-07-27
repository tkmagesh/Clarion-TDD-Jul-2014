using System.Collections.Generic;
using System.Linq;

namespace RentalReport
{
    public class Customer
    {
        string _name;
        IList<Rental> _rentals = new List<Rental>();
        public Customer(string name)
        {
            _name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string Name
        {
            get { return _name; }
        }

        public string Statement()
        {
            var result = "Rental Record for " + Name + "\n";
            var totalAmount = GetTotalAmount();
            foreach(var rental in _rentals)
            {
                //show figures for this rental
                result += "\t" + rental.Movie.Title + "\t" + rental.CalculateAmount().ToString() + "\n";
            }
            //add footer lines
            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints() + " frequent renter points";

            return result;
        }

        public int GetTotalFrequentRenterPoints()
        {
            return _rentals.Sum(rental => rental.GetFrequentRentalPoints());
        }
        public double GetTotalAmount()
        {
            return _rentals.Sum(rental => rental.CalculateAmount());

        }
       
    }
}