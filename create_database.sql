USE [service-example]
GO
/****** Object:  Table [dbo].[Engine]    Script Date: 09/05/2012 20:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Engine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Horsepower] [int] NOT NULL,
	[Cylinders] [int] NOT NULL,
 CONSTRAINT [PK_Engine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tire]    Script Date: 09/05/2012 20:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tire](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Size] [int] NOT NULL,
	[Weight] [int] NOT NULL,
 CONSTRAINT [PK_Tire] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchasedCar]    Script Date: 09/05/2012 20:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchasedCar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[EngineId] [int] NOT NULL,
	[TireId] [int] NOT NULL,
 CONSTRAINT [PK_PurchasedCar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_PurchasedCar_Engine]    Script Date: 09/05/2012 20:57:44 ******/
ALTER TABLE [dbo].[PurchasedCar]  WITH CHECK ADD  CONSTRAINT [FK_PurchasedCar_Engine] FOREIGN KEY([EngineId])
REFERENCES [dbo].[Engine] ([Id])
GO
ALTER TABLE [dbo].[PurchasedCar] CHECK CONSTRAINT [FK_PurchasedCar_Engine]
GO
/****** Object:  ForeignKey [FK_PurchasedCar_Tire]    Script Date: 09/05/2012 20:57:44 ******/
ALTER TABLE [dbo].[PurchasedCar]  WITH CHECK ADD  CONSTRAINT [FK_PurchasedCar_Tire] FOREIGN KEY([TireId])
REFERENCES [dbo].[Tire] ([Id])
GO
ALTER TABLE [dbo].[PurchasedCar] CHECK CONSTRAINT [FK_PurchasedCar_Tire]
GO
