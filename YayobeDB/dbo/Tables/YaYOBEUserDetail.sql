CREATE TABLE [dbo].[YaYOBEUserDetail]
(
	[UserDetailId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY
	[First Name] nvarchar(50)  NOT NULL,
	[Last Name] nvarchar(50) NOT NULL,
	[Email Address] nvarchar(50) NOT NULL,
	[PhoneNumber_Cell] varchar(50)  NOT NULL,
    [PhoneNumber_Home] varchar(50)  NOT NULL,
	[Description] [int] nvarchar(50) NOT NULL,
)
