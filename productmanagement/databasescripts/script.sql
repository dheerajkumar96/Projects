USE [dheeraj]
GO
/****** Object:  Table [dbo].[logindata]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logindata](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_logindata] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productmaster]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productmaster](
	[Sr_No] [int] NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[RAM_Size] [nvarchar](50) NOT NULL,
	[Amount] [int] NOT NULL,
	[Flipkart_Assured] [nvarchar](50) NOT NULL,
	[Colour] [nvarchar](50) NOT NULL,
	[SIM_Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Product Master0af8c7e] PRIMARY KEY CLUSTERED 
(
	[Sr_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usersdata]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usersdata](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_usersdata] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_checklogin]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_checklogin]
	@UserName nvarchar(50),@Password nvarchar(50),@st nvarchar(4000) OUTPUT
AS
BEGIN
	IF EXISTS(SELECT * FROM usersdata WHERE UserName = @UserName AND password = @Password)
    set @st='login success'
ELSE
   set @st='please check your details'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detailsbyname]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_detailsbyname] 
	@Product_Name nvarchar(50)
AS
BEGIN
	select * from productmaster where Product_Name LIKE '%'+@Product_Name+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_filter]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_filter] 
	@Product_Name nvarchar(50)=null,@RAM_Size nvarchar(50)=null,@Colour nvarchar(50)=null
AS
BEGIN
	select * from productmaster where (@Product_Name IS NULL OR Product_Name LIKE '%'+@Product_Name+'%') AND (@RAM_Size IS NULL OR RAM_Size LIKE'%'+@RAM_Size+'%') AND (@Colour IS NULL OR Colour LIKE '%'+@Colour+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getdata]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_getdata] 
	
AS
BEGIN
	select * from productmaster
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getselectedphone]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_getselectedphone] 
	-- Add the parameters for the stored procedure here
	@Sr_No int
AS
BEGIN
	
	select * from productmaster where Sr_No=@Sr_No
   
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertuser]    Script Date: 9/15/2019 9:57:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insertuser]
	@FirstName nvarchar(50) ,@LastName nvarchar(50) ,@UserName nvarchar(50) ,@Password nvarchar(50) ,@st nvarchar(4000) OUTPUT
AS
BEGIN
	insert into usersdata values(@FirstName,@LastName,@UserName,@Password)
	if(@@ROWCOUNT > 0)
	set @st='Registered Successfully'
	else if(@UserName=(select UserName from usersdata where UserName=@UserName))
	set @st='username not available'
	
	

END

GO
