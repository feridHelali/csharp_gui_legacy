CREATE PROCEDURE [dbo].[spCar_Update]
	@Id int,
	@Name VARCHAR(50),
	@Description VARCHAR(50),
	@Price Numeric(18,3)
AS
Begin
	UPDATE Cars
	SET Name=@Name,
		Description=@Description,
		Price=@Price
	WHERE Id=@Id;
End;
