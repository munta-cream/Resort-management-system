﻿CREATE TABLE [dbo].[tblUser]
(
    [Uid] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Pass] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NULL, 
    [Mobile] VARCHAR(15) NOT NULL, 
    [Email] VARCHAR(50) NULL UNIQUE
)
GO

INSERT INTO tblUser VALUES ('admin', '123', 'DIA', '01818618123', 'admin@gmail.com')
GO

CREATE TABLE [dbo].[tblFood]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(50) NULL, 
    [Price] MONEY NOT NULL
)
GO

CREATE TABLE [dbo].[tblRestaurant]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Table_Size] VARCHAR(50) NOT NULL, 
    [Charge] MONEY NOT NULL
)
GO

CREATE TABLE [dbo].[tblRide]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [Time] INT NULL, 
    [Charge] MONEY NULL
)
GO

CREATE TABLE [dbo].[tblResort]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Type] VARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [Charge] MONEY NULL
)
GO

CREATE TABLE [dbo].[tblGuide]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Details] VARCHAR(50) NULL, 
    [Charge] MONEY NULL
)
GO

CREATE TABLE [dbo].[tblReview]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Uid] INT NULL, 
    [Remarks] VARCHAR(150) NULL, 
    [isPublic] BIT NULL, 
    [reviewDate] NCHAR(10) NULL
)
GO