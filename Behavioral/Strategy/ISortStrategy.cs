using System.Collections.Generic;

namespace Strategy
{
    public interface ISortStrategy
    {
        List<int> Sort(List<int> list);
    }
}