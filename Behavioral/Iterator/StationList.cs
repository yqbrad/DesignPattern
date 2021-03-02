using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class StationList: IEnumerable<RadioStation>
    {
        private List<RadioStation> _stations = new();

        public void AddStation(RadioStation station) => _stations.Add(station);

        public void Remove(RadioStation station) => _stations.Remove(station);

        public IEnumerator<RadioStation> GetEnumerator() => _stations.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}