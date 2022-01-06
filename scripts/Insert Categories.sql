
INSERT INTO [dbo].[Categories]
( [Id], [Name], [UserId], [Icon], [DtCreated], [DtUpdate] )
VALUES
( NEWID(), 'Cartão', (select Id from Users where Username = 'user1'), '', GETDATE(), GETDATE() ),
( NEWID(), 'Fixo', (select Id from Users where Username = 'user1'), '' , GETDATE(), GETDATE()),
( NEWID(), 'Variável', (select Id from Users where Username = 'user1'), '' , GETDATE(), GETDATE())

GO

select * from [dbo].[Categories]

