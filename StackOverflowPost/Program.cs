using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post();
            newPost.CreatePost();
            newPost.ShowPost();
            newPost.Vote();
            
        }
    }
}
