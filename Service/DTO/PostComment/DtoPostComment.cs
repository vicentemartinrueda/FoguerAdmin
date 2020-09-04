﻿using System;

namespace Service.DTO
{
    public class DtoPostComment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int CreatorId { get; set; }

        public int? PostId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }

        #region Relationships

        #endregion
    }
}
