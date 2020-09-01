using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Models;

namespace Database.Repository.Interfaces
{
    public interface IPostRepository
    {
        IQueryable<Post> GetAll();

        Task<Post> GetOne(int id);

        IQueryable<PostComment> GetComentarios(int id);

        void Create(Post anuncio);

        Task<Post> Update(Post anuncio, Post dto);

        void Delete(Post anuncio);
    }
}
