using System;

namespace Observer
{
    public class JobSeeker: IObserver<JobPost>
    {
        public string Name { get; set; }

        public JobSeeker(string name) => Name = name;

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(JobPost value)
            => Console.WriteLine($"Hey {Name}, you have new job post with {value.Title} title.");
    }
}
