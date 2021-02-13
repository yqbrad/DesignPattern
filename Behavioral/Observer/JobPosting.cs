using System;
using System.Collections.Generic;

namespace Observer
{
    public class JobPosting: IObservable<JobPost>
    {
        private readonly List<IObserver<JobPost>> _observers;
        private readonly List<JobPost> _jobPosts;

        public JobPosting()
        {
            _observers = new List<IObserver<JobPost>>();
            _jobPosts = new List<JobPost>();
        }

        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new UnSubscriber(_observers, observer);
        }

        public void AddJob(JobPost jobPost)
        {
            _jobPosts.Add(jobPost);
            Notify(jobPost);
        }

        public void Notify(JobPost jobPost)
        {
            foreach (var observer in _observers)
                observer.OnNext(jobPost);
        }
    }
}
