using System.Collections.Generic;
using System.Threading.Tasks;
using OrgDAL.Entities;

namespace OrgDAL.Mappers
{
    public interface IOrgMapper
    {
        /// <summary>
        /// 모든 조직 정보를 가져옴
        /// </summary>
        /// <returns></returns>
        Task<List<OrgEntity>> GetAllOrg();
    }
}