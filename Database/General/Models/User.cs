using System;
using System.Collections.Generic;

namespace Database.General.Models
{
    public partial class User
    {
        public User()
        {
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nif { get; set; }

        public bool Activated { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Role Role { get; set; }

        public List<Post> Posts { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }
    }
}
