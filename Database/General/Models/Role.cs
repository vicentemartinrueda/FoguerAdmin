using System;
using System.Collections.Generic;

namespace Database.General.Models
{
    public partial class Role
    {
        public Role()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Priority { get; set; }

        public List<Role> Users { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }
    }
}
