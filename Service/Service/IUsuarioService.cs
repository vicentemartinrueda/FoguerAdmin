using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoUsuario>> Get();
    }
}
