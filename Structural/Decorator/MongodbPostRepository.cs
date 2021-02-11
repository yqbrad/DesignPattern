using System;

namespace Decorator
{
    public class MongodbPostRepository : IPostRepository
    {
        public void Add(string post) => Console.WriteLine($"Add int mongo db: {post}");
    }
}