CREATE TABLE [dbo].[FileUsers] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [FileId] INT NOT NULL,
    [UserId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FileUsers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_FileUsers_SharedFiles] FOREIGN KEY ([FileId]) REFERENCES [dbo].[SharedFiles] ([Id])
);

CREATE TABLE [dbo].[SharedFiles] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [RecordNo]    VARCHAR (30)  NOT NULL,
    [FileName]    VARCHAR (150) NOT NULL,
    [Description] VARCHAR (500) NOT NULL,
    [ShareState]  BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [UserName]     VARCHAR (20)    NOT NULL,
    [FirstName]    VARCHAR (50)    NOT NULL,
    [LastName]     VARCHAR (50)    NOT NULL,
    [Email]        VARCHAR (50)    NOT NULL,
    [PasswordHash] VARBINARY (500) NOT NULL,
    [PasswordSalt] VARBINARY (500) NOT NULL,
    [Status]       BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NOT NULL,
    [OperationClaimId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

