IF EXISTS(SELECT * FROM sys.objects WHERE name = 'SECU_ORG_SEL' AND type = 'P')
    BEGIN
        DROP PROCEDURE [dbo].[SECU_ORG_SEL]
    END
GO
CREATE PROCEDURE [dbo].[SECU_ORG_SEL]
    @Type			INT					    -- 사용 타입
,	@UpdateID		INT     = 0	            -- 접근 ID
,   @Result			INT     = 1     OUTPUT	-- 결과 값
,   @Message		NVARCHAR(100)	OUTPUT	-- 결과 메시지
AS
BEGIN
    SET NOCOUNT ON;
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
    /*
     *  모든 SELECT 정보는 OrgEntity와 맞춰야 한다.
     */
    
    IF (@Type = 1) -- 모든 조직 정보 가져오기
    BEGIN
        SELECT OrgID       AS 'OrgID',
               OrgName     AS 'OrgName',
               ParentOrgID AS 'ParentOrgID',
               LocationID  AS 'LocationID',
               OrgCode     AS 'OrgCode'
        FROM Org
    END
    
END