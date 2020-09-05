using Service.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IProposalService
    {
        /// <summary>
        /// Get this instance Proposals
        /// </summary>
        /// <returns></returns>
        Task<List<DtoProposal>> GetAll();

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<DtoProposal> GetOne(int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoProposalComment>> GetComentarios(int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoProposalOptionVoters>> GetOpciones(int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        DtoProposal Create(DtoProposal dto);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<DtoProposal> Update(DtoProposal dto, int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<bool> Delete(int id);

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<DtoOptionUser> Vote(DtoOptionUser dto, int id);
    }
}
