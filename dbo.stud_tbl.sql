CREATE TABLE [dbo].[stud_tbl] (
    [Id]       INT            NOT NULL IDENTITY,
    [Username] NVARCHAR (MAX) NOT NULL,	
    [Email]    NVARCHAR (MAX) NOT NULL,
    [Addres]   NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

