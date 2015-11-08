
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/02/2015 22:40:27
-- Generated from EDMX file: C:\Users\mtkx\Desktop\Bachelor\Code\v8\GenerateDatabaseInfo\GenerateDatabaseInfo\LundbeckModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Lundbeck];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Dim_UnitBridge_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_Unit_LSet] DROP CONSTRAINT [FK_Dim_UnitBridge_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_Unit_TypeBridge_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_Unit_LSet] DROP CONSTRAINT [FK_Dim_Unit_TypeBridge_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_Unit_TypeBridge_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_Event_LSet] DROP CONSTRAINT [FK_Dim_Unit_TypeBridge_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_LocationBridge_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_Unit_LSet] DROP CONSTRAINT [FK_Dim_LocationBridge_Unit];
GO
IF OBJECT_ID(N'[dbo].[FK_Dim_EventBridge_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bridge_Event_LSet] DROP CONSTRAINT [FK_Dim_EventBridge_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_Bridge_UnitFact_Unit_Log]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fact_Unit_Log_LSet] DROP CONSTRAINT [FK_Bridge_UnitFact_Unit_Log];
GO
IF OBJECT_ID(N'[dbo].[FK_Bridge_EventFact_Unit_Log]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fact_Unit_Log_LSet] DROP CONSTRAINT [FK_Bridge_EventFact_Unit_Log];
GO
IF OBJECT_ID(N'[dbo].[FK_Bridge_UnitFact_Unit_Data]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fact_Unit_Data_LSet] DROP CONSTRAINT [FK_Bridge_UnitFact_Unit_Data];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Dim_Unit_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_Unit_LSet];
GO
IF OBJECT_ID(N'[dbo].[Dim_Unit_Type_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_Unit_Type_LSet];
GO
IF OBJECT_ID(N'[dbo].[Dim_Location_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_Location_LSet];
GO
IF OBJECT_ID(N'[dbo].[Bridge_Unit_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bridge_Unit_LSet];
GO
IF OBJECT_ID(N'[dbo].[Dim_Event_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dim_Event_LSet];
GO
IF OBJECT_ID(N'[dbo].[Bridge_Event_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bridge_Event_LSet];
GO
IF OBJECT_ID(N'[dbo].[Fact_Unit_Log_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fact_Unit_Log_LSet];
GO
IF OBJECT_ID(N'[dbo].[Fact_Unit_Data_LSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fact_Unit_Data_LSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Dim_Unit_LSet'
CREATE TABLE [dbo].[Dim_Unit_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Unitname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Dim_Unit_Type_LSet'
CREATE TABLE [dbo].[Dim_Unit_Type_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Dim_Location_LSet'
CREATE TABLE [dbo].[Dim_Location_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Room] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bridge_Unit_LSet'
CREATE TABLE [dbo].[Bridge_Unit_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dim_UnitId] int  NOT NULL,
    [Dim_Unit_TypeId] int  NOT NULL,
    [Dim_LocationId] int  NOT NULL
);
GO

-- Creating table 'Dim_Event_LSet'
CREATE TABLE [dbo].[Dim_Event_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [EventDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bridge_Event_LSet'
CREATE TABLE [dbo].[Bridge_Event_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dim_Unit_TypeId] int  NOT NULL,
    [Dim_EventId] int  NOT NULL
);
GO

-- Creating table 'Fact_Unit_Log_LSet'
CREATE TABLE [dbo].[Fact_Unit_Log_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Bridge_UnitId] int  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [Bridge_EventId] int  NOT NULL
);
GO

-- Creating table 'Fact_Unit_Data_LSet'
CREATE TABLE [dbo].[Fact_Unit_Data_LSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Bridge_UnitId] int  NOT NULL,
    [On] int  NOT NULL,
    [Off] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Dim_Unit_LSet'
ALTER TABLE [dbo].[Dim_Unit_LSet]
ADD CONSTRAINT [PK_Dim_Unit_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dim_Unit_Type_LSet'
ALTER TABLE [dbo].[Dim_Unit_Type_LSet]
ADD CONSTRAINT [PK_Dim_Unit_Type_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dim_Location_LSet'
ALTER TABLE [dbo].[Dim_Location_LSet]
ADD CONSTRAINT [PK_Dim_Location_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bridge_Unit_LSet'
ALTER TABLE [dbo].[Bridge_Unit_LSet]
ADD CONSTRAINT [PK_Bridge_Unit_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dim_Event_LSet'
ALTER TABLE [dbo].[Dim_Event_LSet]
ADD CONSTRAINT [PK_Dim_Event_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bridge_Event_LSet'
ALTER TABLE [dbo].[Bridge_Event_LSet]
ADD CONSTRAINT [PK_Bridge_Event_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fact_Unit_Log_LSet'
ALTER TABLE [dbo].[Fact_Unit_Log_LSet]
ADD CONSTRAINT [PK_Fact_Unit_Log_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fact_Unit_Data_LSet'
ALTER TABLE [dbo].[Fact_Unit_Data_LSet]
ADD CONSTRAINT [PK_Fact_Unit_Data_LSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Dim_UnitId] in table 'Bridge_Unit_LSet'
ALTER TABLE [dbo].[Bridge_Unit_LSet]
ADD CONSTRAINT [FK_Dim_UnitBridge_Unit]
    FOREIGN KEY ([Dim_UnitId])
    REFERENCES [dbo].[Dim_Unit_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_UnitBridge_Unit'
CREATE INDEX [IX_FK_Dim_UnitBridge_Unit]
ON [dbo].[Bridge_Unit_LSet]
    ([Dim_UnitId]);
GO

-- Creating foreign key on [Dim_Unit_TypeId] in table 'Bridge_Unit_LSet'
ALTER TABLE [dbo].[Bridge_Unit_LSet]
ADD CONSTRAINT [FK_Dim_Unit_TypeBridge_Unit]
    FOREIGN KEY ([Dim_Unit_TypeId])
    REFERENCES [dbo].[Dim_Unit_Type_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_Unit_TypeBridge_Unit'
CREATE INDEX [IX_FK_Dim_Unit_TypeBridge_Unit]
ON [dbo].[Bridge_Unit_LSet]
    ([Dim_Unit_TypeId]);
GO

-- Creating foreign key on [Dim_Unit_TypeId] in table 'Bridge_Event_LSet'
ALTER TABLE [dbo].[Bridge_Event_LSet]
ADD CONSTRAINT [FK_Dim_Unit_TypeBridge_Event]
    FOREIGN KEY ([Dim_Unit_TypeId])
    REFERENCES [dbo].[Dim_Unit_Type_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_Unit_TypeBridge_Event'
CREATE INDEX [IX_FK_Dim_Unit_TypeBridge_Event]
ON [dbo].[Bridge_Event_LSet]
    ([Dim_Unit_TypeId]);
GO

-- Creating foreign key on [Dim_LocationId] in table 'Bridge_Unit_LSet'
ALTER TABLE [dbo].[Bridge_Unit_LSet]
ADD CONSTRAINT [FK_Dim_LocationBridge_Unit]
    FOREIGN KEY ([Dim_LocationId])
    REFERENCES [dbo].[Dim_Location_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_LocationBridge_Unit'
CREATE INDEX [IX_FK_Dim_LocationBridge_Unit]
ON [dbo].[Bridge_Unit_LSet]
    ([Dim_LocationId]);
GO

-- Creating foreign key on [Dim_EventId] in table 'Bridge_Event_LSet'
ALTER TABLE [dbo].[Bridge_Event_LSet]
ADD CONSTRAINT [FK_Dim_EventBridge_Event]
    FOREIGN KEY ([Dim_EventId])
    REFERENCES [dbo].[Dim_Event_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Dim_EventBridge_Event'
CREATE INDEX [IX_FK_Dim_EventBridge_Event]
ON [dbo].[Bridge_Event_LSet]
    ([Dim_EventId]);
GO

-- Creating foreign key on [Bridge_UnitId] in table 'Fact_Unit_Log_LSet'
ALTER TABLE [dbo].[Fact_Unit_Log_LSet]
ADD CONSTRAINT [FK_Bridge_UnitFact_Unit_Log]
    FOREIGN KEY ([Bridge_UnitId])
    REFERENCES [dbo].[Bridge_Unit_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bridge_UnitFact_Unit_Log'
CREATE INDEX [IX_FK_Bridge_UnitFact_Unit_Log]
ON [dbo].[Fact_Unit_Log_LSet]
    ([Bridge_UnitId]);
GO

-- Creating foreign key on [Bridge_EventId] in table 'Fact_Unit_Log_LSet'
ALTER TABLE [dbo].[Fact_Unit_Log_LSet]
ADD CONSTRAINT [FK_Bridge_EventFact_Unit_Log]
    FOREIGN KEY ([Bridge_EventId])
    REFERENCES [dbo].[Bridge_Event_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bridge_EventFact_Unit_Log'
CREATE INDEX [IX_FK_Bridge_EventFact_Unit_Log]
ON [dbo].[Fact_Unit_Log_LSet]
    ([Bridge_EventId]);
GO

-- Creating foreign key on [Bridge_UnitId] in table 'Fact_Unit_Data_LSet'
ALTER TABLE [dbo].[Fact_Unit_Data_LSet]
ADD CONSTRAINT [FK_Bridge_UnitFact_Unit_Data]
    FOREIGN KEY ([Bridge_UnitId])
    REFERENCES [dbo].[Bridge_Unit_LSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bridge_UnitFact_Unit_Data'
CREATE INDEX [IX_FK_Bridge_UnitFact_Unit_Data]
ON [dbo].[Fact_Unit_Data_LSet]
    ([Bridge_UnitId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------