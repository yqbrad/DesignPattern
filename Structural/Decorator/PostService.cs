namespace Decorator
{
    public class PostService
    {
        public IPostRepository PostRepository { get; set; }
        public PostService(IPostRepository postRepository) => PostRepository = postRepository;

        public void CreatePost(string post)
        {
            System.Console.WriteLine($"Service Create Post: {post}");
            PostRepository.Add(post);
        }
    }
}