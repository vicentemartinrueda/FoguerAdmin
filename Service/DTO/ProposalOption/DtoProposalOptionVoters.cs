using System;
using System.Collections.Generic;

namespace Service.DTO
{
    public class DtoProposalOptionVoters
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public List<DtoOptionUser> Voters { get; set; }

        #endregion
    }
}
