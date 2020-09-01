using Database.General.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTO
{
    public class DtoProposal
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Text { get; set; }

        public int CreatorId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public List<DtoProposalComment> Comments { get; set; }

        public List<DtoProposalOption> Options { get; set; }

        #endregion
    }
}
