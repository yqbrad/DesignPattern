using System;

namespace Decorator
{
    class Program
    {
        //Attach additional responsibilieties to an object dynamically.
        //Decorators provide a flexible alternative to subclassing for extending functionality.
        static void Main(string[] _)
        {
            var service = new PostService(new SqlPostRepository());
            service.CreatePost("Sql Post");

            var service2 = new PostService(new MongodbPostRepository());
            service2.CreatePost("Mongo Post");

            Console.ReadLine();
        }
    }
}