using System;

namespace StackOverflowPost
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private int PositiveVoteCount { get; set; }
        private int NegativeVoteCount { get; set; }

        public void CreatePost(string title, string description, DateTime date)
        {
           
            _title = title;
            _description = description;
            _date = date;

        }

        public string ShowTitle()
        {
            return _title;
        }

        public string ShowDescription()
        {
            return _description;
        }

        public DateTime ShowDateTime()
        {
            return _date;
        }

        public int ShowUpVotes()
        {
            return PositiveVoteCount;
        }

        public int ShowDownVotes()
        {
            return NegativeVoteCount;
        }

        public void UpVote()
        {
            PositiveVoteCount++;
        }

        public void DownVote()
        {
            NegativeVoteCount++;
        }
    }
}