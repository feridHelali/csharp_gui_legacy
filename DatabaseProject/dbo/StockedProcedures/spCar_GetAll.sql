CREATE PROCEDURE [dbo].[spCar_GetAll]
AS
Begin
	SELECT Id,Name,Description,Price From [dbo].[Cars]
End;
