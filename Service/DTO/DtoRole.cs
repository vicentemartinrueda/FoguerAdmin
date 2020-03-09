using Database.General.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTO
{
    public class DtoRole
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Priority { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public List<DtoUser> Users { get; set; }

        #endregion
    }
}
