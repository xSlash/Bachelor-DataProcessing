
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/02/2015 22:41:04
-- Generated from EDMX file: C:\Users\mtkx\Desktop\Bachelor\Code\v8\GenerateDatabaseInfo\GenerateDatabaseInfo\UnitModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RegionH];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Dim_UnitBridge_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_UnitSet] DROP CONSTRAINT [FK_Dim_UnitBridge_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_Unit_TypeBridge_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_UnitSet] DROP CONSTRAINT [FK_Dim_Unit_TypeBridge_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_LocationBridge_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_UnitSet] DROP CONSTRAINT [FK_Dim_LocationBridge_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_Unit_TypeBridge_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_EventSet] DROP CONSTRAINT [FK_Dim_Unit_TypeBridge_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_EventBridge_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_EventSet] DROP CONSTRAINT [FK_Dim_EventBridge_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_Bridge_UnitFact_Unit_Log]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fact_Unit_LogSet] DROP CONSTRAINT [FK_Bridge_UnitFact_Unit_Log];
GO
IF OBJECT_ID(N'[dbo].[FK_Bridge_EventFact_Unit_Log]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fact_Unit_LogSet] DROP CONSTRAINT [FK_Bridge_EventFact_Unit_Log];
GO
IF OBJECT_ID(N'[dbo].[FK_Bridge_UnitFact_Unit_Data]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fact_Unit_DataSet] DROP CONSTRAINT [FK_Bridge_UnitFact_Unit_Data];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Dim_UnitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_UnitSet];
GO
IF OBJECT_ID(N'[dbo].[Dim_Unit_TypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_Unit_TypeSet];
GO
IF OBJECT_ID(N'[dbo].[Dim_LocationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_LocationSet];
GO
IF OBJECT_ID(N'[dbo].[Bridge_UnitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bridge_UnitSet];
GO
IF OBJECT_ID(N'[dbo].[Dim_EventSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_EventSet];
GO
IF OBJECT_ID(N'[dbo].[Bridge_EventSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bridge_EventSet];
GO
IF OBJECT_ID(N'[dbo].[Fact_Unit_LogSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fact_Unit_LogSet];
GO
IF OBJECT_ID(N'[dbo].[Fact_Unit_DataSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fact_Unit_DataSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Dim_UnitSet'
CREATE TABLE [dbo].[Dim_UnitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Unitname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Dim_Unit_TypeSet'
CREATE TABLE [dbo].[Dim_Unit_TypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Dim_LocationSet'
CREATE TABLE [dbo].[Dim_LocationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Room] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bridge_UnitSet'
CREATE TABLE [dbo].[Bridge_UnitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dim_UnitId] int  NOT NULL,
    [Dim_Unit_TypeId] int  NOT NULL,
    [Dim_LocationId] int  NOT NULL
);
GO

-- Creating table 'Dim_EventSet'
CREATE TABLE [dbo].[Dim_EventSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [EventDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bridge_EventSet'
CREATE TABLE [dbo].[Bridge_EventSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dim_Unit_TypeId] int  NOT NULL,
    [Dim_EventId] int  NOT NULL
);
GO

-- Creating table 'Fact_Unit_LogSet'
CREATE TABLE [dbo].[Fact_Unit_LogSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Bridge_UnitId] int  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [Bridge_EventId] int  NOT NULL
);
GO

-- Creating table 'Fact_Unit_DataSet'
CREATE TABLE [dbo].[Fact_Unit_DataSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Bridge_UnitId] int  NOT NULL,
    [SoapLevel] int  NOT NULL,
    [Awake] int  NOT NULL,
    [Flush] int  NOT NULL,
    [Soap] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Dim_UnitSet'
ALTER TABLE [dbo].[Dim_UnitSet]
ADD CONSTRAINT [PK_Dim_UnitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dim_Unit_TypeSet'
ALTER TABLE [dbo].[Dim_Unit_TypeSet]
ADD CONSTRAINT [PK_Dim_Unit_TypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dim_LocationSet'
ALTER TABLE [dbo].[Dim_LocationSet]
ADD CONSTRAINT [PK_Dim_LocationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bridge_UnitSet'
ALTER TABLE [dbo].[Bridge_UnitSet]
ADD CONSTRAINT [PK_Bridge_UnitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dim_EventSet'
ALTER TABLE [dbo].[Dim_EventSet]
ADD CONSTRAINT [PK_Dim_EventSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bridge_EventSet'
ALTER TABLE [dbo].[Bridge_EventSet]
ADD CONSTRAINT [PK_Bridge_EventSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fact_Unit_LogSet'
ALTER TABLE [dbo].[Fact_Unit_LogSet]
ADD CONSTRAINT [PK_Fact_Unit_LogSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fact_Unit_DataSet'
ALTER TABLE [dbo].[Fact_Unit_DataSet]
ADD CONSTRAINT [PK_Fact_Unit_DataSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Dim_UnitId] in table 'Bridge_UnitSet'
ALTER TABLE [dbo].[Bridge_UnitSet]
ADD CONSTRAINT [FK_Dim_UnitBridge_Unit]
    FOREIGN KEY ([Dim_UnitId])
    REFERENCES [dbo].[Dim_UnitSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_UnitBridge_Unit'
CREATE INDEX [IX_FK_Dim_UnitBridge_Unit]
ON [dbo].[Bridge_UnitSet]
    ([Dim_UnitId]);
GO

-- Creating foreign key on [Dim_Unit_TypeId] in table 'Bridge_UnitSet'
ALTER TABLE [dbo].[Bridge_UnitSet]
ADD CONSTRAINT [FK_Dim_Unit_TypeBridge_Unit]
    FOREIGN KEY ([Dim_Unit_TypeId])
    REFERENCES [dbo].[Dim_Unit_TypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_Unit_TypeBridge_Unit'
CREATE INDEX [IX_FK_Dim_Unit_TypeBridge_Unit]
ON [dbo].[Bridge_UnitSet]
    ([Dim_Unit_TypeId]);
GO

-- Creating foreign key on [Dim_LocationId] in table 'Bridge_UnitSet'
ALTER TABLE [dbo].[Bridge_UnitSet]
ADD CONSTRAINT [FK_Dim_LocationBridge_Unit]
    FOREIGN KEY ([Dim_LocationId])
    REFERENCES [dbo].[Dim_LocationSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_LocationBridge_Unit'
CREATE INDEX [IX_FK_Dim_LocationBridge_Unit]
ON [dbo].[Bridge_UnitSet]
    ([Dim_LocationId]);
GO

-- Creating foreign key on [Dim_Unit_TypeId] in table 'Bridge_EventSet'
ALTER TABLE [dbo].[Bridge_EventSet]
ADD CONSTRAINT [FK_Dim_Unit_TypeBridge_Event]
    FOREIGN KEY ([Dim_Unit_TypeId])
    REFERENCES [dbo].[Dim_Unit_TypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_Unit_TypeBridge_Event'
CREATE INDEX [IX_FK_Dim_Unit_TypeBridge_Event]
ON [dbo].[Bridge_EventSet]
    ([Dim_Unit_TypeId]);
GO

-- Creating foreign key on [Dim_EventId] in table 'Bridge_EventSet'
ALTER TABLE [dbo].[Bridge_EventSet]
ADD CONSTRAINT [FK_Dim_EventBridge_Event]
    FOREIGN KEY ([Dim_EventId])
    REFERENCES [dbo].[Dim_EventSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_EventBridge_Event'
CREATE INDEX [IX_FK_Dim_EventBridge_Event]
ON [dbo].[Bridge_EventSet]
    ([Dim_EventId]);
GO

-- Creating foreign key on [Bridge_UnitId] in table 'Fact_Unit_LogSet'
ALTER TABLE [dbo].[Fact_Unit_LogSet]
ADD CONSTRAINT [FK_Bridge_UnitFact_Unit_Log]
    FOREIGN KEY ([Bridge_UnitId])
    REFERENCES [dbo].[Bridge_UnitSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bridge_UnitFact_Unit_Log'
CREATE INDEX [IX_FK_Bridge_UnitFact_Unit_Log]
ON [dbo].[Fact_Unit_LogSet]
    ([Bridge_UnitId]);
GO

-- Creating foreign key on [Bridge_EventId] in table 'Fact_Unit_LogSet'
ALTER TABLE [dbo].[Fact_Unit_LogSet]
ADD CONSTRAINT [FK_Bridge_EventFact_Unit_Log]
    FOREIGN KEY ([Bridge_EventId])
    REFERENCES [dbo].[Bridge_EventSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bridge_EventFact_Unit_Log'
CREATE INDEX [IX_FK_Bridge_EventFact_Unit_Log]
ON [dbo].[Fact_Unit_LogSet]
    ([Bridge_EventId]);
GO

-- Creating foreign key on [Bridge_UnitId] in table 'Fact_Unit_DataSet'
ALTER TABLE [dbo].[Fact_Unit_DataSet]
ADD CONSTRAINT [FK_Bridge_UnitFact_Unit_Data]
    FOREIGN KEY ([Bridge_UnitId])
    REFERENCES [dbo].[Bridge_UnitSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bridge_UnitFact_Unit_Data'
CREATE INDEX [IX_FK_Bridge_UnitFact_Unit_Data]
ON [dbo].[Fact_Unit_DataSet]
    ([Bridge_UnitId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------