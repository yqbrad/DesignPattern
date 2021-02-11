using System;

namespace Decorator
{
    public class SqlPostRepository : IPostRepository
    {
        public void Add(string post) => Console.WriteLine($"Add int sql: {post}");
    }
}