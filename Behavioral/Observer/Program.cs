using System;

namespace Observer
{
    public class Program
    {
        // Define a one-to-many dependency between objects so that when one object changes state, all
        // its dependents are notified and updated automatically.
        public static void Main(string[] _)
        {
            var mohammad = new JobSeeker("Mohammad");
            var ali = new JobSeeker("Ali");

            var developer = new JobPosting();

            developer.Subscribe(mohammad);
            developer.Subscribe(ali);

            developer.AddJob(new JobPost(".Net Developer"));
            developer.AddJob(new JobPost("Java Developer"));

            Console.ReadKey();
        }
    }
}