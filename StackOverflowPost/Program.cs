using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post();
            var isRunning = true;
           

            Console.WriteLine("Title:");
            var title = Console.ReadLine();
            Console.WriteLine("Description:");
            var description = Console.ReadLine();
            var date = DateTime.Now;

            newPost.CreatePost(title, description, date);

            Console.WriteLine();
            Console.WriteLine("Title: {0}", newPost.ShowTitle());
            Console.WriteLine("Description: {0}", newPost.ShowDescription());
            Console.WriteLine(newPost.ShowDateTime());
            Console.WriteLine();

            while (isRunning)
            {
                Console.WriteLine("Do you like this post? y/n (To exit press e)");
                var vote = Console.ReadLine();
                switch (vote.ToLower())
                {
                    case "y":
                        newPost.UpVote();
                        break;
                    case "n":
                        newPost.DownVote();
                        break;
                    case "e":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Error try one of the inputs above");
                        break;
                }
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Title: {0}", newPost.ShowTitle());
            Console.WriteLine("Description: {0}", newPost.ShowDescription());
            Console.WriteLine(newPost.ShowDateTime());
            Console.WriteLine("Upvotes: {0}, Downvotes: {1}", newPost.ShowUpVotes(), newPost.ShowDownVotes());
            Console.WriteLine("Exiting application...");



        }
    }
}
