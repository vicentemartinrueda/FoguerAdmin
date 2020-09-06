using System;
using System.Collections.Generic;

namespace Service.DTO
{
    public class DtoPost
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Text { get; set; }

        public int Photo { get; set; }

        public int CreatorId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        public List<DtoPostComment> Comments { get; set; }

        #endregion
    }
}
