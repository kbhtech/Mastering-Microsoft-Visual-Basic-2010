-- --------------------------------------------------
-- Date Created: 09/13/2009 22:03:45
-- Generated from EDMX file: C:\danijel\Mastering\9780470532874 version 1.0.0\9780470532874 c17\9780470532874 c17 code\MyEFProject\MyEFProject\BooksAndAuthors.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER ON;
SET ANSI_NULLS ON;
GO

USE [BooksAndAuthors]
GO
IF SCHEMA_ID('dbo') IS NULL EXECUTE('CREATE SCHEMA [dbo]')
GO

-- --------------------------------------------------
-- Dropping existing FK constraints
-- --------------------------------------------------

IF OBJECT_ID('dbo.FK_PersonAddress', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Addresses] DROP CONSTRAINT [FK_PersonAddress]
GO
IF OBJECT_ID('dbo.FK_PersonBook_Person', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonBook] DROP CONSTRAINT [FK_PersonBook_Person]
GO
IF OBJECT_ID('dbo.FK_PersonBook_Book', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonBook] DROP CONSTRAINT [FK_PersonBook_Book]
GO
IF OBJECT_ID('dbo.FK_TranslatorLanguages_Translator', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TranslatorLanguages] DROP CONSTRAINT [FK_TranslatorLanguages_Translator]
GO
IF OBJECT_ID('dbo.FK_TranslatorLanguages_Languages', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TranslatorLanguages] DROP CONSTRAINT [FK_TranslatorLanguages_Languages]
GO
IF OBJECT_ID('dbo.FK_BookSales', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SalesByMonth] DROP CONSTRAINT [FK_BookSales]
GO
IF OBJECT_ID('dbo.FK_Translator_inherits_Person', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persons_Translator] DROP CONSTRAINT [FK_Translator_inherits_Person]
GO
IF OBJECT_ID('dbo.FK_Author_inherits_Person', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persons_Author] DROP CONSTRAINT [FK_Author_inherits_Person]
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID('dbo.Books', 'U') IS NOT NULL
    DROP TABLE [dbo].[Books];
GO
IF OBJECT_ID('dbo.Persons', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO
IF OBJECT_ID('dbo.Addresses', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID('dbo.Languages', 'U') IS NOT NULL
    DROP TABLE [dbo].[Languages];
GO
IF OBJECT_ID('dbo.SalesByMonth', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalesByMonth];
GO
IF OBJECT_ID('dbo.Persons_Translator', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons_Translator];
GO
IF OBJECT_ID('dbo.Persons_Author', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons_Author];
GO
IF OBJECT_ID('dbo.PersonBook', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonBook];
GO
IF OBJECT_ID('dbo.TranslatorLanguages', 'U') IS NOT NULL
    DROP TABLE [dbo].[TranslatorLanguages];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [ISBN] varchar(13)  NOT NULL,
    [Title] nvarchar(4000)  NOT NULL,
    [PublishingDate] datetime  NOT NULL,
    [PageCount] int  NOT NULL
);
GO
-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [SSN] char(9)  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Phone_CountryCode] nvarchar(3)  NOT NULL,
    [Phone_AreaCode] nvarchar(3)  NOT NULL,
    [Phone_Number] nvarchar(max)  NOT NULL,
    [Phone_Extension] nvarchar(20)  NULL
);
GO
-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstLine] nvarchar(50)  NOT NULL,
    [SecondLine] nvarchar(50)  NULL,
    [City] nvarchar(50)  NOT NULL,
    [PostalCode] int  NOT NULL,
    [State] nvarchar(25)  NOT NULL,
    [Person_SSN] char(9)  NOT NULL
);
GO
-- Creating table 'Languages'
CREATE TABLE [dbo].[Languages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO
-- Creating table 'SalesByMonth'
CREATE TABLE [dbo].[SalesByMonth] (
    [Month] smallint  NOT NULL,
    [Year] smallint  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL,
    [CopiesSold] bigint  NOT NULL,
    [Book_ISBN] varchar(13)  NOT NULL
);
GO
-- Creating table 'Persons_Translator'
CREATE TABLE [dbo].[Persons_Translator] (
    [SSN] char(9)  NOT NULL
);
GO
-- Creating table 'Persons_Author'
CREATE TABLE [dbo].[Persons_Author] (
    [Signed] datetime  NOT NULL,
    [SSN] char(9)  NOT NULL
);
GO
-- Creating table 'PersonBook'
CREATE TABLE [dbo].[PersonBook] (
    [Persons_SSN] char(9)  NOT NULL,
    [Books_ISBN] varchar(13)  NOT NULL
);
GO
-- Creating table 'TranslatorLanguages'
CREATE TABLE [dbo].[TranslatorLanguages] (
    [Translator_SSN] char(9)  NOT NULL,
    [Languages_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all Primary Key Constraints
-- --------------------------------------------------

-- Creating primary key on [ISBN] in table 'Books'
ALTER TABLE [dbo].[Books] WITH NOCHECK
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([ISBN] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [SSN] in table 'Persons'
ALTER TABLE [dbo].[Persons] WITH NOCHECK
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([SSN] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [Id] in table 'Addresses'
ALTER TABLE [dbo].[Addresses] WITH NOCHECK
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([Id] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [Id] in table 'Languages'
ALTER TABLE [dbo].[Languages] WITH NOCHECK
ADD CONSTRAINT [PK_Languages]
    PRIMARY KEY CLUSTERED ([Id] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [Id] in table 'SalesByMonth'
ALTER TABLE [dbo].[SalesByMonth] WITH NOCHECK
ADD CONSTRAINT [PK_SalesByMonth]
    PRIMARY KEY CLUSTERED ([Id] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [SSN] in table 'Persons_Translator'
ALTER TABLE [dbo].[Persons_Translator] WITH NOCHECK
ADD CONSTRAINT [PK_Persons_Translator]
    PRIMARY KEY CLUSTERED ([SSN] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [SSN] in table 'Persons_Author'
ALTER TABLE [dbo].[Persons_Author] WITH NOCHECK
ADD CONSTRAINT [PK_Persons_Author]
    PRIMARY KEY CLUSTERED ([SSN] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [Persons_SSN], [Books_ISBN] in table 'PersonBook'
ALTER TABLE [dbo].[PersonBook] WITH NOCHECK
ADD CONSTRAINT [PK_PersonBook]
    PRIMARY KEY NONCLUSTERED ([Persons_SSN], [Books_ISBN] ASC)
    ON [PRIMARY]
GO
-- Creating primary key on [Translator_SSN], [Languages_Id] in table 'TranslatorLanguages'
ALTER TABLE [dbo].[TranslatorLanguages] WITH NOCHECK
ADD CONSTRAINT [PK_TranslatorLanguages]
    PRIMARY KEY NONCLUSTERED ([Translator_SSN], [Languages_Id] ASC)
    ON [PRIMARY]
GO

-- --------------------------------------------------
-- Creating all Foreign Key Constraints
-- --------------------------------------------------

-- Creating foreign key on [Person_SSN] in table 'Addresses'
ALTER TABLE [dbo].[Addresses] WITH NOCHECK
ADD CONSTRAINT [FK_PersonAddress]
    FOREIGN KEY ([Person_SSN])
    REFERENCES [dbo].[Persons]
        ([SSN])
    ON DELETE CASCADE ON UPDATE NO ACTION
GO
-- Creating foreign key on [Persons_SSN] in table 'PersonBook'
ALTER TABLE [dbo].[PersonBook] WITH NOCHECK
ADD CONSTRAINT [FK_PersonBook_Person]
    FOREIGN KEY ([Persons_SSN])
    REFERENCES [dbo].[Persons]
        ([SSN])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [Books_ISBN] in table 'PersonBook'
ALTER TABLE [dbo].[PersonBook] WITH NOCHECK
ADD CONSTRAINT [FK_PersonBook_Book]
    FOREIGN KEY ([Books_ISBN])
    REFERENCES [dbo].[Books]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [Translator_SSN] in table 'TranslatorLanguages'
ALTER TABLE [dbo].[TranslatorLanguages] WITH NOCHECK
ADD CONSTRAINT [FK_TranslatorLanguages_Translator]
    FOREIGN KEY ([Translator_SSN])
    REFERENCES [dbo].[Persons_Translator]
        ([SSN])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [Languages_Id] in table 'TranslatorLanguages'
ALTER TABLE [dbo].[TranslatorLanguages] WITH NOCHECK
ADD CONSTRAINT [FK_TranslatorLanguages_Languages]
    FOREIGN KEY ([Languages_Id])
    REFERENCES [dbo].[Languages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [Book_ISBN] in table 'SalesByMonth'
ALTER TABLE [dbo].[SalesByMonth] WITH NOCHECK
ADD CONSTRAINT [FK_BookSales]
    FOREIGN KEY ([Book_ISBN])
    REFERENCES [dbo].[Books]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [SSN] in table 'Persons_Translator'
ALTER TABLE [dbo].[Persons_Translator] WITH NOCHECK
ADD CONSTRAINT [FK_Translator_inherits_Person]
    FOREIGN KEY ([SSN])
    REFERENCES [dbo].[Persons]
        ([SSN])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO
-- Creating foreign key on [SSN] in table 'Persons_Author'
ALTER TABLE [dbo].[Persons_Author] WITH NOCHECK
ADD CONSTRAINT [FK_Author_inherits_Person]
    FOREIGN KEY ([SSN])
    REFERENCES [dbo].[Persons]
        ([SSN])
    ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

