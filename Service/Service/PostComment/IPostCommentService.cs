using Service.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IPostCommentService
    {
        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        DtoPostComment Create(DtoPostComment dto);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<DtoPostComment> Update(DtoPostComment dto, int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<bool> Delete(int id);
    }
}
