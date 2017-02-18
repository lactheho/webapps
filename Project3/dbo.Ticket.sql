CREATE TABLE [dbo].[Ticket] (
    [EventName]     VARCHAR (50) NOT NULL,
    [EventType]     VARCHAR (50) NULL,
    [EventDate]     DATE         NULL,
    [Price]         MONEY        NULL,
    [Sold]          BIT          DEFAULT ((0)) NULL,
    [UserName]      VARCHAR (50) NULL,
    [SoldTo] VARCHAR(50) NULL , 
    PRIMARY KEY CLUSTERED ([EventName] ASC)
);

