using System;

namespace Database.General.Models
{
    public partial class Post
    {
        public Post()
        {
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Text { get; set; }

        public Role Creator { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }
    }
}
