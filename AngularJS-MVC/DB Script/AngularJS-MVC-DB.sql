USE [AngularJS-MVC-DB]
GO
/****** Object:  Table [dbo].[SiteMenu]    Script Date: 02-May-17 10:56:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteMenu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Url] [nvarchar](50) NULL,
	[ParentID] [int] NULL,
 CONSTRAINT [PK_SiteMenu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[SiteMenu] ON 

GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (1, N'Menu 1', N'#', 0)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (2, N'Menu 2', N'#', 0)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (3, N'Menu 3', N'#', 0)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (4, N'Menu 4', N'#', 0)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (5, N'Menu 5', N'#', 0)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (6, N'Sub-Menu 1-1', N'#', 1)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (7, N'Sub-Menu 1-2', N'#', 1)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (8, N'Sub-Menu 2-1', N'#', 2)
GO
INSERT [dbo].[SiteMenu] ([ID], [Name], [Url], [ParentID]) VALUES (9, N'Sub-Menu 2-1-1', N'#', 8)
GO
SET IDENTITY_INSERT [dbo].[SiteMenu] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetSiteMenu]    Script Date: 02-May-17 10:56:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[GetSiteMenu]
 
as
select * from SiteMenu

GO
