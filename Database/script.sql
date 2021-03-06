USE [master]
GO

USE [HeroSaga]
GO
/****** Object:  StoredProcedure [dbo].[Delete_BattleLog]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_BattleLog]
	-- Add the parameters for the stored procedure here
	@BattleLogID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.BattleLog
	SET IsActive = 0
	WHERE BattleLogID = @BattleLogID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_Hero]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Hero]
	-- Add the parameters for the stored procedure here
	@HeroID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.Hero
	SET IsActive = 0
	WHERE HeroID = @HeroID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_HeroStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_HeroStat]
	-- Add the parameters for the stored procedure here
	@HeroStatID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.HeroStat
	SET IsActive = 0
	WHERE HeroStatID = @HeroStatID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_HeroType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_HeroType]
	-- Add the parameters for the stored procedure here
	@HeroTypeID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.HeroType
	SET IsActive = 0
	WHERE HeroTypeID = @HeroTypeID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_Monster]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Monster]
	-- Add the parameters for the stored procedure here
	@MonsterID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.Monster
	SET IsActive = 0
	WHERE MonsterID = @MonsterID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_MonsterStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_MonsterStat]
	-- Add the parameters for the stored procedure here
	@MonsterStatID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.MonsterStat
	SET IsActive = 0
	WHERE MonsterStatID = @MonsterStatID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_MonsterType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_MonsterType]
	-- Add the parameters for the stored procedure here
	@MonsterTypeID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.MonsterType
	SET IsActive = 0
	WHERE MonsterTypeID = @MonsterTypeID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_Origin]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Origin]
	-- Add the parameters for the stored procedure here
	@OriginID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.Origin
	SET IsActive = 0
	WHERE OriginID = @OriginID
END


GO
/****** Object:  StoredProcedure [dbo].[Delete_Stat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Stat]
	-- Add the parameters for the stored procedure here
	@StatID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroSaga.dbo.Stat
	SET IsActive = 0
	WHERE StatID = @StatID
END


GO
/****** Object:  StoredProcedure [dbo].[Get_BattleLogByHeroID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rachel
-- Create date: 12/5/2015
-- Description:	Returns Heros Battles
-- =============================================
CREATE PROCEDURE [dbo].[Get_BattleLogByHeroID] 
	-- Add the parameters for the stored procedure here
	@heroid int 
	  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT        Monster.MonsterName, Monster.XPWorth, Hero.HeroName, BattleLog.VictoryStatus, BattleLog.BattleDate, Hero.HeroID, Monster.MonsterID, BattleLog.BattleLogID
FROM            BattleLog INNER JOIN
                         Hero ON BattleLog.HeroID = Hero.HeroID INNER JOIN
                         Monster ON BattleLog.MonsterID = Monster.MonsterID
WHERE        (BattleLog.HeroID = @heroid) AND (BattleLog.IsActive = 1) AND (Monster.IsActive = 1) AND (Hero.IsActive = 1)
END

GO
/****** Object:  StoredProcedure [dbo].[Get_BattleLogByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_BattleLogByID]
	-- Add the parameters for the stored procedure here
	@BattleLogID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.BattleLog bl WITH(NOLOCK)
	JOIN HeroSaga.dbo.Hero h WITH(NOLOCK)
	ON bl.HeroID = h.HeroID
	WHERE BattleLogID = @BattleLogID AND bl.IsActive = 1 AND h.IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_HeroByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_HeroByID]
	-- Add the parameters for the stored procedure here
	@HeroID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.Hero h WITH(NOLOCK)
	JOIN HeroSaga.dbo.HeroType ht WITH(NOLOCK)
	ON h.HeroTypeID  = ht.HeroTypeID
	JOIN HeroSaga.dbo.Origin o WITH(NOLOCK)
	ON h.OriginID = o.OriginID
	WHERE HeroID = @HeroID AND h.IsActive = 1
	AND ht.IsActive = 1
	AND o.IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_HeroStatByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_HeroStatByID]
	-- Add the parameters for the stored procedure here
	@HeroStatID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.HeroStat WITH(NOLOCK)
	WHERE HeroStatID = @HeroStatID AND IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_HeroStatsByHeroId]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rachel
-- Create date: 12/5/2015
-- Description:	Returns HeroStats By HeroId
-- =============================================
CREATE PROCEDURE [dbo].[Get_HeroStatsByHeroId] 
	-- Add the parameters for the stored procedure here
	@HeroID int
	  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT        HeroStat.HeroStatID, Stat.StatID, HeroStat.CurrentValue, Stat.StatName, HeroStat.HeroID
FROM            HeroStat INNER JOIN
                         Stat ON HeroStat.StatID = Stat.StatID
WHERE        (HeroStat.IsActive = 1) AND (Stat.IsActive = 1) AND (HeroStat.HeroID = @HeroID)
END

GO
/****** Object:  StoredProcedure [dbo].[Get_HeroTypeByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_HeroTypeByID]
	-- Add the parameters for the stored procedure here
	@HeroTypeID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.HeroType WITH(NOLOCK)
	WHERE HeroTypeID = @HeroTypeID AND IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_MonsterByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_MonsterByID]
	-- Add the parameters for the stored procedure here
	@MonsterID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.Monster m WITH(NOLOCK)
	JOIN HeroSaga.dbo.MonsterType mt WITH(NOLOCK)
	ON m.MonsterTypeID = mt.MonsterTypeID
	WHERE MonsterID = @MonsterID AND m.IsActive = 1
	AND mt.IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_MonsterStatByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_MonsterStatByID]
	-- Add the parameters for the stored procedure here
	@MonsterStatID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.MonsterStat WITH(NOLOCK)
	WHERE MonsterStatID = @MonsterStatID AND IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_MonsterTypeByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_MonsterTypeByID]
	-- Add the parameters for the stored procedure here
	@MonsterTypeID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.MonsterType WITH(NOLOCK)
	WHERE MonsterTypeID = @MonsterTypeID AND IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_OriginByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_OriginByID]
	-- Add the parameters for the stored procedure here
	@OriginID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.Origin WITH(NOLOCK)
	WHERE OriginID = @OriginID AND IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_StatByID]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_StatByID]
	-- Add the parameters for the stored procedure here
	@StatID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM HeroSaga.dbo.Stat WITH(NOLOCK)
	WHERE StatID = @StatID AND IsActive = 1
END


GO
/****** Object:  StoredProcedure [dbo].[Save_BattleLog]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_BattleLog]
	-- Add the parameters for the stored procedure here
	@BattleDate DATE,
	@MonsterID INT,
	@HeroID INT,
	@VictoryStatus BIT,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO BattleLog
	VALUES (@BattleDate, @MonsterID, @HeroID, @VictoryStatus, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_Hero]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_Hero]
	-- Add the parameters for the stored procedure here
	@HeroTypeID INT,
	@Name VARCHAR,
	@Level INT,
	@CurrentXP INT,
	@Gender VARCHAR,
	@OriginID INT,
	@IsActive BIT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Hero
	VALUES (@HeroTypeID, @Name, @Level, @CurrentXP, @Gender, @OriginID, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_HeroStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_HeroStat]
	-- Add the parameters for the stored procedure here
	@HeroID INT,
	@StatID INT,
	@CurrentValue DECIMAL(5,3),
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO HeroStat
	VALUES (@HeroID, @StatID, @CurrentValue, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_HeroType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_HeroType]
	-- Add the parameters for the stored procedure here
	@Name VARCHAR,
	@Description VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO HeroType
	VALUES (@Name, @Description, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_Monster]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_Monster]
	-- Add the parameters for the stored procedure here
	@MonsterTypeID INT,
	@Name VARCHAR,
	@Level INT,
	@XPWorth INT,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Monster
	VALUES (@MonsterTypeID, @Name, @Level, @XPWorth, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_MonsterStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_MonsterStat]
	-- Add the parameters for the stored procedure here
	@MonsterID INT,
	@StatID INT,
	@CurrentValue DECIMAL(5,3),
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO MonsterStat
	VALUES (@MonsterID, @StatID, @CurrentValue, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_MonsterType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_MonsterType]
	-- Add the parameters for the stored procedure here
	@Name VARCHAR,
	@Description VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO MonsterType
	VALUES (@Name, @Description, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_Origin]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_Origin]
	-- Add the parameters for the stored procedure here
	@Name VARCHAR,
	@Description VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Origin
	VALUES (@Name, @Description, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Save_Stat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Save_Stat]
	-- Add the parameters for the stored procedure here
	@Name VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Stat
	VALUES (@Name, @IsActive)
	SELECT SCOPE_IDENTITY() AS NewID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_BattleLog]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_BattleLog]
	-- Add the parameters for the stored procedure here
	@BattleLogID INT,
	@BattleDate DATE,
	@MonsterID INT,
	@HeroID INT,
	@VictoryStatus BIT,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE BattleLog SET BattleDate = @BattleDate, MonsterID = @MonsterID, HeroID = @HeroID,
	VictoryStatus = @VictoryStatus, IsActive = @IsActive
	where BattleLogID = @BattleLogID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_Hero]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Hero]
	-- Add the parameters for the stored procedure here
	@HeroID INT,
	@HeroTypeID INT,
	@Name VARCHAR,
	@Level INT,
	@CurrentXP INT,
	@Gender VARCHAR,
	@OriginID INT,
	@IsActive BIT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Hero set HeroTypeID = @HeroTypeID, HeroName = @Name, [Level] = @Level,
	CurrentXP = @CurrentXP, Gender = @Gender, OriginID = @OriginID, IsActive = @IsActive
	where HeroID = @HeroID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_HeroStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_HeroStat]
	-- Add the parameters for the stored procedure here
	@HeroStatID INT,
	@HeroID INT,
	@StatID INT,
	@CurrentValue DECIMAL(5,3),
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroStat SET HeroID = @HeroID, StatID = @StatID, CurrentValue = @CurrentValue,
    IsActive = @IsActive
	where HeroStatID = @HeroStatID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_HeroType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_HeroType]
	-- Add the parameters for the stored procedure here
	@HeroTypeID INT,
	@Name VARCHAR,
	@Description VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HeroType SET HeroTypeName = @Name, [HeroTypeDescription] = @Description,
    IsActive = @IsActive
	where HeroTypeID = @HeroTypeID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_Monster]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Monster]
	-- Add the parameters for the stored procedure here
	@MonsterID INT,
	@MonsterTypeID INT,
	@Name VARCHAR,
	@Level INT,
	@XPWorth INT,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Monster SET MonsterTypeID = @MonsterTypeID, MonsterName = @Name, [Level] = @Level,
    XPWorth = @XPWorth, IsActive = @IsActive
	where MonsterID = @MonsterID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_MonsterStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_MonsterStat]
	-- Add the parameters for the stored procedure here
	@MonsterStatID INT,
	@MonsterID INT,
	@StatID INT,
	@CurrentValue DECIMAL(5,3),
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 UPDATE MonsterStat SET MonsterID = @MonsterID, StatID = @StatID, 
    CurrentValue = @CurrentValue, IsActive = @IsActive
	where MonsterStatID = @MonsterStatID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_MonsterType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_MonsterType]
	-- Add the parameters for the stored procedure here
	@MonsterTypeID INT,
	@Name VARCHAR,
	@Description VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE MonsterType SET MonsterTypeName = @Name, [MonsterTypeDescription] = @Description,
    IsActive = @IsActive
	where MonsterTypeID = @MonsterTypeID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_Origin]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Origin]
	-- Add the parameters for the stored procedure here
	@OriginID INT,
	@Name VARCHAR,
	@Description VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Origin SET OriginName = @Name, [OriginDescription] = @Description, 
    IsActive = @IsActive
	where OriginID = @OriginID
END


GO
/****** Object:  StoredProcedure [dbo].[Update_Stat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Stat]
	-- Add the parameters for the stored procedure here
	@StatID INT,
	@Name VARCHAR,
	@IsActive INT = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Stat SET StatName = @Name, 
    IsActive = @IsActive
	where StatID = @StatID
END


GO
/****** Object:  Table [dbo].[BattleLog]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BattleLog](
	[BattleLogID] [int] IDENTITY(1,1) NOT NULL,
	[BattleDate] [date] NULL,
	[MonsterID] [int] NULL,
	[HeroID] [int] NULL,
	[VictoryStatus] [bit] NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[BattleLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hero]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hero](
	[HeroID] [int] IDENTITY(1,1) NOT NULL,
	[HeroTypeID] [int] NULL,
	[HeroName] [varchar](50) NULL,
	[Level] [int] NULL,
	[CurrentXP] [int] NULL,
	[Gender] [varchar](15) NULL,
	[OriginID] [int] NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[HeroID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HeroStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeroStat](
	[HeroStatID] [int] IDENTITY(1,1) NOT NULL,
	[HeroID] [int] NULL,
	[StatID] [int] NULL,
	[CurrentValue] [decimal](5, 3) NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[HeroStatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HeroType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HeroType](
	[HeroTypeID] [int] IDENTITY(1,1) NOT NULL,
	[HeroTypeName] [varchar](50) NULL,
	[HeroTypeDescription] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[HeroTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Monster]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Monster](
	[MonsterID] [int] IDENTITY(1,1) NOT NULL,
	[MonsterTypeID] [int] NULL,
	[MonsterName] [varchar](50) NULL,
	[Level] [int] NULL,
	[XPWorth] [int] NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[MonsterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonsterStat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonsterStat](
	[MonsterStatID] [int] IDENTITY(1,1) NOT NULL,
	[MonsterID] [int] NULL,
	[StatID] [int] NULL,
	[CurrentValue] [decimal](5, 3) NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MonsterStatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonsterType]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonsterType](
	[MonsterTypeID] [int] IDENTITY(1,1) NOT NULL,
	[MonsterTypeName] [varchar](50) NULL,
	[MonsterTypeDescription] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[MonsterTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Origin]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Origin](
	[OriginID] [int] IDENTITY(1,1) NOT NULL,
	[OriginName] [varchar](50) NULL,
	[OriginDescription] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[OriginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stat]    Script Date: 12/6/2015 10:09:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stat](
	[StatID] [int] IDENTITY(1,1) NOT NULL,
	[StatName] [varchar](50) NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[StatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[MonsterStat] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[BattleLog]  WITH CHECK ADD FOREIGN KEY([HeroID])
REFERENCES [dbo].[Hero] ([HeroID])
GO
ALTER TABLE [dbo].[BattleLog]  WITH CHECK ADD FOREIGN KEY([MonsterID])
REFERENCES [dbo].[Monster] ([MonsterID])
GO
ALTER TABLE [dbo].[Hero]  WITH CHECK ADD FOREIGN KEY([HeroTypeID])
REFERENCES [dbo].[HeroType] ([HeroTypeID])
GO
ALTER TABLE [dbo].[Hero]  WITH CHECK ADD FOREIGN KEY([OriginID])
REFERENCES [dbo].[Origin] ([OriginID])
GO
ALTER TABLE [dbo].[HeroStat]  WITH CHECK ADD FOREIGN KEY([HeroID])
REFERENCES [dbo].[Hero] ([HeroID])
GO
ALTER TABLE [dbo].[HeroStat]  WITH CHECK ADD FOREIGN KEY([StatID])
REFERENCES [dbo].[Stat] ([StatID])
GO
ALTER TABLE [dbo].[Monster]  WITH CHECK ADD FOREIGN KEY([MonsterTypeID])
REFERENCES [dbo].[MonsterType] ([MonsterTypeID])
GO
ALTER TABLE [dbo].[MonsterStat]  WITH CHECK ADD FOREIGN KEY([MonsterID])
REFERENCES [dbo].[Monster] ([MonsterID])
GO
ALTER TABLE [dbo].[MonsterStat]  WITH CHECK ADD FOREIGN KEY([StatID])
REFERENCES [dbo].[Stat] ([StatID])
GO
USE [master]
GO
ALTER DATABASE [HeroSaga] SET  READ_WRITE 
GO
