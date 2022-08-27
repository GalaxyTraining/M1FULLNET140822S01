USE [BDEmpresa]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 21/08/2022 10:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProdName] [varchar](100) NULL,
	[ProdType] [varchar](100) NULL,
	[Price] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [ProdName], [ProdType], [Price]) VALUES (1, N'oreo', N'galleta', CAST(2.30 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([Id], [ProdName], [ProdType], [Price]) VALUES (4, N'concordia', N'gaseosa', CAST(5.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
