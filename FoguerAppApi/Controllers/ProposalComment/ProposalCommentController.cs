using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Service;

namespace FoguerAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalCommentController : ControllerBase
    {
        private readonly IProposalCommentService _comentarioPropuestaService;

        public ProposalCommentController(IProposalCommentService comentarioAnuncioService)
        {
            _comentarioPropuestaService = comentarioAnuncioService ?? throw new ArgumentNullException(nameof(comentarioAnuncioService));
        }

        /// <summary>
        /// Obtenemos las opciones
        /// </summary>
        /// <returns></returns>
        // GET: api/PostComment
        [HttpPost]
        public ActionResult<DtoProposalComment> Create(DtoProposalComment dto)
        {
            DtoProposalComment comentario = _comentarioPropuestaService.Create(dto);
            return Ok(comentario);
        }

        /// <summary>
        /// Obtenemos el Anuncio
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpPut("{id}")]
        public async Task<ActionResult<DtoProposalComment>> UpdateComentario(int id, DtoProposalComment dto)
        {
            DtoProposalComment anuncio = await _comentarioPropuestaService.Update(dto, id);
            return Ok(anuncio);
        }

        /// <summary>
        /// Obtenemos el anuncio
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpDelete("{id}")]
        public async Task<ActionResult<DtoProposalComment>> DeleteComentario(int id)
        {
            await _comentarioPropuestaService.Delete(id);
            return Ok();
        }
    }
}