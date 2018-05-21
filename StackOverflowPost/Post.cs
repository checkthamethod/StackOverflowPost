using System;

namespace StackOverflowPost
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private int _positiveVoteCount;
        private int _negativeVoteCount;
        private string _vote;
        private bool _isRunning = true;


        public void CreatePost()
        {
            Console.WriteLine("Title:");
            _title = Console.ReadLine();
            Console.WriteLine("Description:");
            _description = Console.ReadLine();
            _date = DateTime.Now;

        }

        public void ShowPost()
        {
            Console.WriteLine();
            Console.WriteLine("Title: {0}",_title);
            Console.WriteLine("Description: {0}",_description);
            Console.WriteLine(_date);
            Console.WriteLine();
        }

        public void Vote()
        {
            while (_isRunning)
            {
                Console.WriteLine("Do you like this post? y/n (To exit press e)");
                _vote = Console.ReadLine();
                switch (_vote.ToLower())
                {
                    case "y":
                        UpVote();
                        break;
                    case "n":
                        DownVote();
                        
                        break;
                    case "e":
                        Console.WriteLine();
                        Console.WriteLine("Upvotes: {0}, Downvotes: {1}", _positiveVoteCount, _negativeVoteCount);
                        Console.WriteLine("Exiting application...");
                        _isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Error try one of the inputs above");
                        break;
                }
            }
        }

        private void UpVote()
        {
            _positiveVoteCount++;
        }

        private void DownVote()
        {
            _negativeVoteCount++;
        }
    }
}