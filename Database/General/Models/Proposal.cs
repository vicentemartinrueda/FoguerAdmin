﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.General.Models
{
    public partial class Proposal
    {
        public Proposal()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public int CreatorId { get; set; }

        public User Creator { get; set; }

        public ICollection<ProposalComment> Comments { get; set; }

        public ICollection<ProposalOption> Options { get; set; }

        #endregion
    }
}