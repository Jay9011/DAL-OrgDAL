using CoreDAL.ORM;

namespace OrgDAL.ParamClasses.SECU_WEB
{
    public class SECU_ORG_SEL : SQLParam
    {
        public enum Types
        {
            /// <summary>
            /// 모든 조직 정보를 찾는다.
            /// </summary>
            GetAll = 1,
        }
        
        public Types Type { get; set; }
    }
}