using System.Collections.Generic;

namespace Strategy
{
    public class Sorter
    {
        private readonly ISortStrategy _sortStrategy;
        public Sorter(ISortStrategy sortStrategy) => _sortStrategy = sortStrategy;

        public List<int> Sort(List<int> list) => _sortStrategy.Sort(list);
    }
}