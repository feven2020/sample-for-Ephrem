CREATE TABLE [dbo].[YaYoBEgUsers]
(
	[Username] nvarchar(50) NOT NULL PRIMARY KEY,
	[PasswordHash] varbinary(max) NOT NULL,
	[PasswordSalt] [varbinary](max) NOT NULL,
	[UserRolesId] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL

)
