using Service.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IUserService
    {
        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        Task<List<DtoUser>> Get();
    }
}
