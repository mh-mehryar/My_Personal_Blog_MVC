using Blog_MVC.Models;

namespace Blog_MVC.Service
{
    public class PostService
    {
        List<Post> posts = new List<Post>()
            {
                new Post
                {
                    Title = "First Post",
                    Content = "Description of First Post",
                    RegisterDate = DateTime.Now,
                    Id = 1
                },
                new Post
                {
                    Title = "Second Post",
                    Content = "Description of Second Post",
                    RegisterDate = DateTime.Now,
                    Id = 2
                }
        };
        public List<Post> GetAll()
        {
            return posts;
        }
    }
}
