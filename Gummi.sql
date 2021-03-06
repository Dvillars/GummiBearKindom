CREATE DATABASE [Gummi]
GO
USE [Gummi]
GO
/****** Object:  Table [dbo].[Gummies]    Script Date: 4/21/2017 4:31:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gummies](
	[GummiId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[cost] [int] NOT NULL,
	[Image] [varchar](255) NULL,
	[country] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Gummies] PRIMARY KEY CLUSTERED 
(
	[GummiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Gummies] ON 

INSERT [dbo].[Gummies] ([GummiId], [name], [cost], [Image], [country]) VALUES (3, N'The Classic Mix', 5, N'https://www.haribo.com/typo3temp/haribo/thumbnail/haribo-gold-bears-pack_0_0_180_355_9222.png', N'US')
INSERT [dbo].[Gummies] ([GummiId], [name], [cost], [Image], [country]) VALUES (4, N'Cola Chews', 5, N'http://ci.memecdn.com/9989778.jpg', N'Germany')
INSERT [dbo].[Gummies] ([GummiId], [name], [cost], [Image], [country]) VALUES (5, N'the Sour Hour', 5, N'https://s-media-cache-ak0.pinimg.com/736x/a1/03/57/a103577c80a2644baf01466bf3d4e7ad.jpg', N'China')
INSERT [dbo].[Gummies] ([GummiId], [name], [cost], [Image], [country]) VALUES (6, N'Cherry Flavor Bombs ', 5, N'https://www.haribo.com/typo3temp/haribo/thumbnail/Happy-Cherries_0_0_180_355_9422.png', N'Spain')
SET IDENTITY_INSERT [dbo].[Gummies] OFF
