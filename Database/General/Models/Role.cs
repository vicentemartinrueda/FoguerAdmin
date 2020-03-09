﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.General.Models
{
    public partial class Role
    {
        public Role()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Priority { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public ICollection<User> Users { get; set; }

        #endregion
    }
}
