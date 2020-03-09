using Database.General.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTO
{
    public class DtoUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nif { get; set; }

        public bool Activated { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public DtoRole Role { get; set; }

        public List<DtoPost> Posts { get; set; }

        #endregion
    }
}
