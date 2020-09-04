using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Models;

namespace Database.Repository.Interfaces
{
    public interface IPostCommentRepository
    {
        Task<PostComment> GetOne(int id);

        void Create(PostComment comentario);

        Task<PostComment> Update(PostComment comentario, PostComment dto);

        void Delete(PostComment comentario);
    }
}
