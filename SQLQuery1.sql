CREATE TABLE [dbo].[Users](
	[Id] int identity(1,1) not null,
	[FirstName] nvarchar (max) not null,
	[LastName] nvarchar (max) not null,
		[UserId] nvarchar (max) not null
	Primary key (Id)
	);
	GO

CREATE TABLE [dbo].[Activities](
	[Id] int identity(1,1) not null,
	[Name] nvarchar (max) not null,
	[Description] nvarchar (max) not null,
	[UserId] INT NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY (UserId) REFERENCES Users (Id)
	);
	GO