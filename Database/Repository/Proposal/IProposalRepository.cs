using System.Linq;
using System.Threading.Tasks;
using Database.General.Models;

namespace Database.Repository.Interfaces
{
    public interface IProposalRepository
    {
        IQueryable<Proposal> GetAll();

        Task<Proposal> GetOne(int id);

        IQueryable<ProposalComment> GetComentarios(int id);

        IQueryable<ProposalOption> GetOpciones(int id);

        void Create(Proposal propuesta);

        Task<Proposal> Update(Proposal propuesta, Proposal dto);

        void Delete(Proposal propuesta);

        void DeleteVote(OptionUser vote);

        void CreateVote(OptionUser vote);

    }
}
