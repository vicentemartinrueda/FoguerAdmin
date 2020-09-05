using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Service;

namespace FoguerAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private readonly IProposalService _propuestaService;

        public ProposalController(IProposalService propuestaService)
        {
            _propuestaService = propuestaService ?? throw new ArgumentNullException(nameof(propuestaService));
        }

        /// <summary>
        /// Obtenemos todas las Propuestas disponibles
        /// </summary>
        /// <returns></returns>
        // GET: api/Proposal
        [HttpGet]
        public async Task<ActionResult<List<DtoProposal>>> GetPropuestas()
        {
            List<DtoProposal> propuestas = await _propuestaService.GetAll();
            propuestas.Sort((x, y) => DateTime.Compare(y.CreationDate, x.CreationDate));
            return propuestas;
        }

        /// <summary>
        /// Obtenemos la Propuesta
        /// </summary>
        /// <returns></returns>
        // GET: api/Proposal
        [HttpGet("{id}")]
        public async Task<ActionResult<DtoProposal>> GetPropuesta(int id)
        {
            DtoProposal propuesta = await _propuestaService.GetOne(id);
            propuesta.Comments.Sort((x, y) => DateTime.Compare(y.CreationDate, x.CreationDate));
            return propuesta;
        }

        /// <summary>
        /// Obtenemos los comentarios
        /// </summary>
        /// <returns></returns>
        // GET: api/Proposal
        [HttpGet("{id}/Comments")]
        public async Task<ActionResult<List<DtoProposalComment>>> GetComentarios(int id)
        {
            List<DtoProposalComment> propuesta = await _propuestaService.GetComentarios(id);
            return propuesta;
        }

        /// <summary>
        /// Obtenemos las opciones
        /// </summary>
        /// <returns></returns>
        // GET: api/Proposal
        [HttpGet("{id}/Options")]
        public async Task<ActionResult<List<DtoProposalComment>>> GetOpciones(int id)
        {
            List<DtoProposalComment> propuesta = await _propuestaService.GetComentarios(id);
            return propuesta;
        }

        /// <summary>
        /// Obtenemos las opciones
        /// </summary>
        /// <returns></returns>
        // GET: api/Proposal
        [HttpPost]
        public ActionResult<DtoProposal> Create(DtoProposal dto)
        {
            DtoProposal propuesta = _propuestaService.Create(dto);
            return Ok(propuesta);
        }

        /// <summary>
        /// Obtenemos la Propuesta
        /// </summary>
        /// <returns></returns>
        // GET: api/Proposal
        [HttpPut("{id}")]
        public async Task<ActionResult<DtoProposal>> UpdatePropuesta(int id, DtoProposal dto)
        {
            DtoProposal propuesta = await _propuestaService.Update(dto, id);
            return Ok(propuesta);
        }

        /// <summary>
        /// Obtenemos la Propuesta
        /// </summary>
        /// <returns></returns>
        // GET: api/Proposal
        [HttpDelete("{id}")]
        public async Task<ActionResult<DtoProposal>> DeletePropuesta(int id)
        {
            await _propuestaService.Delete(id);
            return Ok();
        }
    }
}