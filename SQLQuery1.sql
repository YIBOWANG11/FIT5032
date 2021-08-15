CREATE TABLE [dbo].[studentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'unitSet'
CREATE TABLE [dbo].[unitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Decription] nvarchar(max)  NOT NULL,
    [studentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'studentSet'
ALTER TABLE [dbo].[studentSet]
ADD CONSTRAINT [PK_studentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'unitSet'
ALTER TABLE [dbo].[unitSet]
ADD CONSTRAINT [PK_unitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [studentId] in table 'unitSet'
ALTER TABLE [dbo].[unitSet]
ADD CONSTRAINT [FK_studentunit]
    FOREIGN KEY ([studentId])
    REFERENCES [dbo].[studentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_studentunit'
CREATE INDEX [IX_FK_studentunit]
ON [dbo].[unitSet]
    ([studentId]);
GO