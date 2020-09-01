using Service.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IPostService
    {
        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoPost>> GetAll();

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<DtoPost> GetOne(int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoPostComment>> GetComentarios(int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        DtoPost Create(DtoPost dto);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<DtoPost> Update(DtoPost dto, int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<bool> Delete(int id);
    }
}
