using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using CoreDAL;
using CoreDAL.Classes;
using CoreDAL.Dapper;
using CoreDAL.Models;
using OrgDAL.Entities;
using OrgDAL.ParamClasses.SECU_WEB;

namespace OrgDAL.Mappers.Classes
{
    public class S1AccessOrgMapper: IOrgMapper
    {
        public async Task<List<OrgEntity>> GetAllOrg()
        {
            ICoreDAL dal = new S1AccessCoreDAL();

            try
            {
                // 프로시저 실행
                SQLResult result = await dal.ExecuteProcedureAsync("SECU_ORG_SEL", new SECU_ORG_SEL(){ Type = SECU_ORG_SEL.Types.GetAll });

                // 실패했거나 결과가 없으면 null 반환
                if (!result.IsSuccess || result.DataSet.Tables.Count == 0)
                {
                    return null;
                }
                
                // 결과를 객체로 변환
                if (result.DataSet.Tables[0].Rows.Count > 0)
                {
                    List<OrgEntity> orgs = new List<OrgEntity>();
                    foreach (DataRow row in result.DataSet.Tables[0].Rows)
                    {
                        OrgEntity org = row.ToObject<OrgEntity>();
                        orgs.Add(org);
                    }
                    
                    return orgs;
                }
            }
            catch (Exception e)
            {
                throw;
            }
            
            return null;
        }
    }
}