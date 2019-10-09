CREATE TABLE [dbo].[CustomerInfo] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]        VARCHAR (50)  NOT NULL,
    [LastName]         VARCHAR (50)  NOT NULL,
    [EmailAddress]     VARCHAR (100) NOT NULL,
    [DateOfBirth]      DATE          NOT NULL,
    [CarYear]          INT           NOT NULL,
    [CarMake]          VARCHAR (50)  NOT NULL,
    [CarModel]         VARCHAR (50)  NOT NULL,
    [DriveIntoxicated] BIT           NULL,
    [SpeedingTickets]  INT           NULL,
    [FullCoverage]     BIT           NULL,
    [InsQuote]         DECIMAL(16, 2)    NULL,
    CONSTRAINT [PK_CustomerInfo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

