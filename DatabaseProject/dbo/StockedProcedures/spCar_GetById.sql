CREATE PROCEDURE [dbo].[spCar_GetById]
	@Id int 
AS
Begin
	SELECT Id,Name,Description,Price From [dbo].[Cars]
	WHERE Id=@Id;
End;
