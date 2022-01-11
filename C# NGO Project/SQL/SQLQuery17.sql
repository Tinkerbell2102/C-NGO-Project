/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [UserID]
      ,[Firstname]
      ,[Lastname]
      ,[Username]
      ,[Password]
      ,[Email]
      ,[ContactNumber]
      ,[OrgName]
      ,[Profile]
  FROM [6955_FA2_PRG521].[dbo].[Users]


  SELECT [Username],[Password] FROM Users WHERE [Username] like 'LaikinB' AND [Password] like 'ctu@2021'