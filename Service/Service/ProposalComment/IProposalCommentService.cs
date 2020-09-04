using Service.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IProposalCommentService
    {
        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        DtoProposalComment Create(DtoProposalComment dto);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<DtoProposalComment> Update(DtoProposalComment dto, int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<bool> Delete(int id);
    }
}
