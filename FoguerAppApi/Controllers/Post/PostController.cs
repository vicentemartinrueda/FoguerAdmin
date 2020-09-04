using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Service;

namespace FoguerAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _anuncioService;

        public PostController(IPostService anuncioService)
        {
            _anuncioService = anuncioService ?? throw new ArgumentNullException(nameof(anuncioService));
        }

        /// <summary>
        /// Obtenemos todos los Anuncios con sus comentarios
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpGet]
        public async Task<ActionResult<List<DtoPost>>> GetAnuncios()
        {
            List<DtoPost> anuncio = await _anuncioService.GetAll();
            return anuncio;
        }

        /// <summary>
        /// Obtenemos todos los Anuncios disponibles
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpGet("{id}")]
        public async Task<ActionResult<DtoPost>> GetAnuncio(int id)
        {
            DtoPost anuncio = await _anuncioService.GetOne(id);
            anuncio.Comments.Sort((x, y) => DateTime.Compare(y.CreationDate, x.CreationDate));
            return anuncio;
        }

        /// <summary>
        /// Obtenemos los comentarios
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpGet("{id}/Comments")]
        public async Task<ActionResult<List<DtoPostComment>>> GetComentarios(int id)
        {
            List<DtoPostComment> anuncio = await _anuncioService.GetComentarios(id);
            return anuncio;
        }

        /// <summary>
        /// Obtenemos las opciones
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpPost]
        public ActionResult<DtoPost> Create(DtoPost dto)
        {
            DtoPost anuncio = _anuncioService.Create(dto);
            return Ok(anuncio);
        }

        /// <summary>
        /// Obtenemos el Anuncio
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpPut("{id}")]
        public async Task<ActionResult<DtoPost>> Updateanuncio(int id, DtoPost dto)
        {
            DtoPost anuncio = await _anuncioService.Update(dto, id);
            return Ok(anuncio);
        }

        /// <summary>
        /// Obtenemos el anuncio
        /// </summary>
        /// <returns></returns>
        // GET: api/Post
        [HttpDelete("{id}")]
        public async Task<ActionResult<DtoPost>> DeleteAnuncio(int id)
        {
            await _anuncioService.Delete(id);
            return Ok();
        }
    }
}