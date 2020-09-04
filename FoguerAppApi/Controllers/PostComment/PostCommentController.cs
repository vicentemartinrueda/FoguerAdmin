using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Service;

namespace FoguerAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCommentController : ControllerBase
    {
        private readonly IPostCommentService _comentarioAnuncioService;

        public PostCommentController(IPostCommentService comentarioAnuncioService)
        {
            _comentarioAnuncioService = comentarioAnuncioService ?? throw new ArgumentNullException(nameof(comentarioAnuncioService));
        }

        /// <summary>
        /// Obtenemos las opciones
        /// </summary>
        /// <returns></returns>
        // GET: api/PostComment
        [HttpPost]
        public ActionResult<DtoPostComment> Create(DtoPostComment dto)
        {
            DtoPostComment comentario = _comentarioAnuncioService.Create(dto);
            return Ok(comentario);
        }

        /// <summary>
        /// Obtenemos el Anuncio
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpPut("{id}")]
        public async Task<ActionResult<DtoPostComment>> UpdateComentario(int id, DtoPostComment dto)
        {
            DtoPostComment anuncio = await _comentarioAnuncioService.Update(dto, id);
            return Ok(anuncio);
        }

        /// <summary>
        /// Obtenemos el anuncio
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpDelete("{id}")]
        public async Task<ActionResult<DtoPostComment>> DeleteComentario(int id)
        {
            await _comentarioAnuncioService.Delete(id);
            return Ok();
        }
    }
}