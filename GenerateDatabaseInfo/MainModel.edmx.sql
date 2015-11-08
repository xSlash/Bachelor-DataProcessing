
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/04/2015 15:18:43
-- Generated from EDMX file: C:\Users\mtkx\Desktop\Bachelor\Code\v10\GenerateDatabaseInfo\GenerateDatabaseInfo\MainModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Customer];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Main_Dim_UnitMain_Bridge_Customer_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Main_Bridge_Customer_UnitSet] DROP CONSTRAINT [FK_Main_Dim_UnitMain_Bridge_Customer_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Main_Dim_CustomerMain_Bridge_Customer_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Main_Bridge_Customer_UnitSet] DROP CONSTRAINT [FK_Main_Dim_CustomerMain_Bridge_Customer_Unit];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Main_Dim_UnitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Main_Dim_UnitSet];
GO
IF OBJECT_ID(N'[dbo].[Main_Dim_CustomerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Main_Dim_CustomerSet];
GO
IF OBJECT_ID(N'[dbo].[Main_Bridge_Customer_UnitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Main_Bridge_Customer_UnitSet];
GO
IF OBJECT_ID(N'[dbo].[Main_Fact_LogsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Main_Fact_LogsSet];
GO
IF OBJECT_ID(N'[dbo].[Main_UsersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Main_UsersSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Main_Dim_UnitSet'
CREATE TABLE [dbo].[Main_Dim_UnitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UnitID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Main_Dim_CustomerSet'
CREATE TABLE [dbo].[Main_Dim_CustomerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Customer_name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Main_Bridge_Customer_UnitSet'
CREATE TABLE [dbo].[Main_Bridge_Customer_UnitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Main_Dim_UnitId] int  NOT NULL,
    [Main_Dim_CustomerId] int  NOT NULL
);
GO

-- Creating table 'Main_Fact_LogsSet'
CREATE TABLE [dbo].[Main_Fact_LogsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UnitName] nvarchar(max)  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [EventName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Main_UsersSet'
CREATE TABLE [dbo].[Main_UsersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Customer] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Main_Dim_UnitSet'
ALTER TABLE [dbo].[Main_Dim_UnitSet]
ADD CONSTRAINT [PK_Main_Dim_UnitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Main_Dim_CustomerSet'
ALTER TABLE [dbo].[Main_Dim_CustomerSet]
ADD CONSTRAINT [PK_Main_Dim_CustomerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Main_Bridge_Customer_UnitSet'
ALTER TABLE [dbo].[Main_Bridge_Customer_UnitSet]
ADD CONSTRAINT [PK_Main_Bridge_Customer_UnitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Main_Fact_LogsSet'
ALTER TABLE [dbo].[Main_Fact_LogsSet]
ADD CONSTRAINT [PK_Main_Fact_LogsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Main_UsersSet'
ALTER TABLE [dbo].[Main_UsersSet]
ADD CONSTRAINT [PK_Main_UsersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Main_Dim_UnitId] in table 'Main_Bridge_Customer_UnitSet'
ALTER TABLE [dbo].[Main_Bridge_Customer_UnitSet]
ADD CONSTRAINT [FK_Main_Dim_UnitMain_Bridge_Customer_Unit]
    FOREIGN KEY ([Main_Dim_UnitId])
    REFERENCES [dbo].[Main_Dim_UnitSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Main_Dim_UnitMain_Bridge_Customer_Unit'
CREATE INDEX [IX_FK_Main_Dim_UnitMain_Bridge_Customer_Unit]
ON [dbo].[Main_Bridge_Customer_UnitSet]
    ([Main_Dim_UnitId]);
GO

-- Creating foreign key on [Main_Dim_CustomerId] in table 'Main_Bridge_Customer_UnitSet'
ALTER TABLE [dbo].[Main_Bridge_Customer_UnitSet]
ADD CONSTRAINT [FK_Main_Dim_CustomerMain_Bridge_Customer_Unit]
    FOREIGN KEY ([Main_Dim_CustomerId])
    REFERENCES [dbo].[Main_Dim_CustomerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Main_Dim_CustomerMain_Bridge_Customer_Unit'
CREATE INDEX [IX_FK_Main_Dim_CustomerMain_Bridge_Customer_Unit]
ON [dbo].[Main_Bridge_Customer_UnitSet]
    ([Main_Dim_CustomerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------