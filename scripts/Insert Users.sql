USE Expenses
-- Insert rows into table 'Users' in schema '[dbo]'
INSERT INTO [dbo].[Users]
    ( -- Columns to insert data into
    [dbo].[Id], [dbo].[Username], [dbo].[Password], [dbo].[Active]
    )
VALUES
    (NEWID(), 'user1', 'pass', 1),
    (NEWID(),'user2', 'pass', 1),
    (NEWID(), 'user3', 'pass', 0)
GO
select * from [dbo].[Users] order by Username
