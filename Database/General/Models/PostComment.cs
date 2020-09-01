using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.General.Models
{
    public partial class PostComment
    {
        public PostComment()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public int CreatorId { get; set; }

        public User Creator { get; set; }

        public int? PostId { get; set; }

        public Post Post { get; set; }

        #endregion
    }
}
