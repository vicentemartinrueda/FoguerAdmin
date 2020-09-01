using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.General.Models
{
    public partial class SharedFile
    {
        public SharedFile()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Uri { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public int CreatorId { get; set; }

        public User Creator { get; set; }

        #endregion
    }
}
