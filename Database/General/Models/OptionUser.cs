using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.General.Models
{
    public partial class OptionUser
    {
        public OptionUser()
        {
        }

        [Key]
        public int Id { get; set; }

        #region Relationships

        public int? UserId { get; set; }

        public User User { get; set; }

        public int? OptionId { get; set; }

        public ProposalOption Option { get; set; }

        #endregion
    }
}
