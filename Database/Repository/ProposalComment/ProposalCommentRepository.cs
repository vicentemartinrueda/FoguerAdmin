using System;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Context;
using Database.General.Models;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository
{
    public class ProposalCommentRepository : IProposalCommentRepository
    {
        private readonly FoguerAppDbContext _context;

        public ProposalCommentRepository(FoguerAppDbContext context)
        {
            _context = context;
        }

        public Task<ProposalComment> GetOne(int id)
        {
            return _context.ProposalComment.Where(p => p.Id == id)
                .AsNoTracking().FirstOrDefaultAsync(); ;
        }

        public void Create(ProposalComment entrada)
        {
            _context.ProposalComment.Add(entrada);
            _context.SaveChanges();
        }

        public Task<ProposalComment> Update(ProposalComment comentario, ProposalComment dto)
        {
            comentario.Text = dto.Text;
            comentario.UpdateDate = dto.UpdateDate;
            _context.Update(comentario);
            _context.SaveChanges();

            return _context.ProposalComment.Where(p => p.Id == comentario.Id).AsNoTracking().FirstOrDefaultAsync(); ;
        }

        public void Delete(ProposalComment comentario)
        {
            _context.Remove(comentario);
            _context.SaveChanges();
        }
    }
}
