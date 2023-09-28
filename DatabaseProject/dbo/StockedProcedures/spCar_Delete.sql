CREATE PROCEDURE [dbo].[spCar_Delete]
	@Id int 
AS
Begin
	Delete From [dbo].[Cars]
	WHERE Id=@Id;
end;
