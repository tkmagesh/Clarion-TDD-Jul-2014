using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreetingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            var greeter = new Greeter(new TimeService());
            Console.WriteLine(greeter.Greet(name));
            Console.ReadLine();
        }
    }

    public class Greeter
    {
        private readonly ITimeService _timeService;

        public Greeter(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string Greet(string name)
        {
            if (_timeService.GetTime().Hour < 12)
            {
                return string.Format("Good Morning {0}!", name);
            }
            else
            {
                return string.Format("Good Afternoon {0}!", name);
            }
        }
    }

    public interface ITimeService
    {
        DateTime GetTime();
    }

    public class TimeService : ITimeService
    {
        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}
