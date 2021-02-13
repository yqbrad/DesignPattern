using System;
using System.Collections.Generic;

namespace Observer
{
    public class UnSubscriber: IDisposable
    {
        private readonly List<IObserver<JobPost>> _observers;
        private readonly IObserver<JobPost> _observer;

        public UnSubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (!_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}