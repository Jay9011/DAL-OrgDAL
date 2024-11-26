namespace OrgDAL.Entities
{
    /// <summary>
    /// 조직 정보 엔티티 (DB와 직접 연결되는 부분)
    /// </summary>
    public class OrgEntity
    {
        /// <summary>
        /// 조직 ID
        /// </summary>
        public int OrgID { get; set; }
        /// <summary>
        /// 조직명
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 상위 조직 ID
        /// </summary>
        public int ParentOrgID { get; set; }
        /// <summary>
        /// 조직에 지정된 위치 ID
        /// </summary>
        public int LocationID { get; set; }
        /// <summary>
        /// 조직 코드
        /// </summary>
        public string OrgCode { get; set; }
    }
}