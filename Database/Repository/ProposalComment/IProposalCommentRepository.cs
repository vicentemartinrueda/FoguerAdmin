using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Models;

namespace Database.Repository.Interfaces
{
    public interface IProposalCommentRepository
    {
        Task<ProposalComment> GetOne(int id);

        void Create(ProposalComment comentario);

        Task<ProposalComment> Update(ProposalComment comentario, ProposalComment dto);

        void Delete(ProposalComment comentario);
    }
}
