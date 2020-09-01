using System;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Context;
using Database.General.Models;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository
{
    public class ProposalRepository : IProposalRepository
    {
        private readonly FoguerAppDbContext _context;

        public ProposalRepository(FoguerAppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Proposal> GetAll()
        {
            return _context.Proposal
                .Include(p => p.Comments)
                .Include(p => p.Options)
                .AsNoTracking();
        }

        public Task<Proposal> GetOne(int id)
        {
            return _context.Proposal
                .Where(p => p.Id == id)
                .Include(p => p.Comments)
                .Include(p => p.Options)
                .AsNoTracking().FirstOrDefaultAsync();
        }

        public IQueryable<ProposalComment> GetComentarios(int id)
        {
            return _context.ProposalComment
                .Where(pc => pc.ProposalId == id)
                .AsNoTracking();
        }

        public IQueryable<ProposalOption> GetOpciones(int id)
        {
            return _context.ProposalOption
                .Where(pc => pc.ProposalId == id)
                .AsNoTracking();
        }

        public void Create(Proposal entrada)
        {
            _context.Proposal.Add(entrada);
            _context.SaveChanges();
        }

        public Task<Proposal> Update(Proposal proposal, Proposal dto)
        {
            proposal.Title = dto.Title;
            proposal.Subtitle = dto.Subtitle;
            proposal.Text = dto.Text;
            _context.Update(proposal);
            _context.SaveChanges();

            return _context.Proposal.Where(p => p.Id == proposal.Id).AsNoTracking().FirstOrDefaultAsync(); ;
        }

        public void Delete(Proposal propuesta)
        {
            _context.Remove(propuesta);
            _context.SaveChanges();
        }
    }
}
