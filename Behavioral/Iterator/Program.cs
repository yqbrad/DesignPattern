using System;
using System.Linq;

namespace Iterator
{
    class Program
    {
        //Provide a way to access the elements of an aggregate object swquentially 
        //without exposing its underlying representation.
        static void Main(string[] _)
        {
            var stations = new StationList();
            stations.AddStation(new RadioStation(11));
            stations.AddStation(new RadioStation(34));

            var ferequency11 = stations.First(s => s.GetFrequency() == 11);
            Console.WriteLine(ferequency11.GetFrequency());

            Console.ReadKey();
        }
    }
}
