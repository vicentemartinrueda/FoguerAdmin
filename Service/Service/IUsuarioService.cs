using Service.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoUser>> Get();

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoRole>> Get1();
    }
}
